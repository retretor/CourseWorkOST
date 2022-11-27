using Queues;
using Structures;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using OST_Labs.DataTypes.MultilevelFeedbackQueues;

namespace OST_Labs
{

    public class Model : INotifyPropertyChanged
    {
        public SystemClock Clock { get; private set; }
        /**/
        public readonly Resource Cpu;
        /**/
        public readonly Resource Device;
        public readonly Resource Device2;
        private readonly IdGenerator _idGen;
        private readonly CpuScheduler _cpuScheduler;
        private readonly DeviceScheduler _deviceScheduler;
        private readonly DeviceScheduler _device2Scheduler;
        public Memory Ram { get; private set; }
        private readonly MemoryManager _memoryManager;
        private readonly Random _processRand;
        private readonly Random _random;
        public Settings ModelSettings { get; set; }
        public CollectStatistics Statistics;
        #region ReadyQueue

        public MultilevelFeedbackQueues ReadyQueue { get; private set; }

        #endregion
        #region DeviceQueue
        private IQueueable<Process> _deviceQueue;
        private IQueueable<Process> _device2Queue;
        public IQueueable<Process> DeviceQueue
        {
            get => _deviceQueue;
            private set { _deviceQueue = value; OnPropertyChanged(); }
        }
        public IQueueable<Process> Device2Queue
        {
            get => _device2Queue;
            private set { _device2Queue = value; OnPropertyChanged(); }
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string property = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }


        public Model()
        {
            Clock = new SystemClock();
            Cpu = new Resource();
            Device = new Resource();
            Device2 = new Resource();
            Ram = new Memory();
            _idGen = new IdGenerator();
            // ReadyQueue
            ReadyQueue = new MultilevelFeedbackQueues();
            _cpuScheduler = new CpuScheduler(Cpu, ReadyQueue);
            // DeviceQueue
            DeviceQueue = new FIFOQueue<Process, QueueableList<Process>>(new QueueableList<Process>());
            Device2Queue = new FIFOQueue<Process, QueueableList<Process>>(new QueueableList<Process>());
            _memoryManager = new MemoryManager();
            _deviceScheduler = new DeviceScheduler(Device, DeviceQueue);
            _device2Scheduler = new DeviceScheduler(Device2, Device2Queue);
            _processRand = new Random();
            ModelSettings = new Settings();
            
            Statistics = new CollectStatistics(ModelSettings);
        }

        public void SaveSettings()
        {
            Ram.Save(ModelSettings.ValueOfRamSize);
            _memoryManager.Save(Ram);
            Statistics.Save();
        }

        public void WorkingCycle()
        {
            Clock.WorkingCycle();
            if (_processRand.NextDouble() < ModelSettings.Intensity)
            {
                int allocatedMemory = _processRand.Next(ModelSettings.MinValueOfAddrSpace, ModelSettings.MaxValueOfAddrSpace + 1);
                if (_memoryManager.Allocate(allocatedMemory) != null)
                {
                    Process proc = new Process(_idGen.Id, allocatedMemory);
                    proc.BurstTime = _processRand.Next(ModelSettings.MinValueOfBurstTime,
                        ModelSettings.MaxValueOfBurstTime + 1);
                    Subscribe(proc);
                    ReadyQueue.Put(proc);
                    Statistics.AllProcessCount++;
                    Statistics.MaxQueueLength = Math.Max(Statistics.MaxQueueLength, ReadyQueue.Count);
                    Statistics.AvgQueueLength += ReadyQueue.Count;
                    if (Cpu.IsFree())
                    {
                        ReadyQueue = _cpuScheduler.Session();
                    }
                }
                else
                {
                    Statistics.RejectedProcessCount++;
                }
            }

            PrepareCpu();
            
            if (Cpu.IsFree())
            {
                Statistics.RestCpuTime++;
            }
            Statistics.WorkingCycle();
            
            Cpu.WorkingCycle();
            Device.WorkingCycle();
            Device2.WorkingCycle();
        }

        private void PrepareCpu()
        {
            if(Cpu.IsFree())
            {
                return;
            }
            if (CanCpuWork())
            {
                return;
            }
            Cpu.ActiveProcess.QueueWorkTime = 0;
            Cpu.ActiveProcess.IncreasePriority();
            ReadyQueue.Put(Cpu.ActiveProcess);
            Cpu.ActiveProcess = null;
            ReadyQueue = _cpuScheduler.Session();
        }

        private bool CanCpuWork()
        {
            if (Cpu.ActiveProcess.Priority == 1)
            {
                if (Cpu.ActiveProcess.QueueWorkTime + 1 <= ReadyQueue.MaxTimeSession1)
                {
                    return true;
                }
                return false;
            }
            if (Cpu.ActiveProcess.Priority == 2)
            {
                if (Cpu.ActiveProcess.QueueWorkTime + 1 <= ReadyQueue.MaxTimeSession2)
                {
                    return true;
                }
                return false;
            }
            if (Cpu.ActiveProcess.Priority == 3)
            {
                if (Cpu.ActiveProcess.QueueWorkTime + 1 <= ReadyQueue.MaxTimeSession3)
                {
                    return true;
                }
                return false;
            }
            return true;
        }

        public void Clear()
        {
            Cpu.Clear();
            Device.Clear();
            Device2.Clear();
            Ram.Clear();
            Clock.Clear();
            _idGen.Clear();
            ReadyQueue.Clear();
            DeviceQueue = DeviceQueue.Clear();
            Device2Queue = Device2Queue.Clear();
            Statistics.Clear();
        }

        private void FreeingAResourceEventHandler(object sender, EventArgs e)
        {
            Process p = sender as Process;
            switch (p.ProcessStatus)
            {
                case ProcessStatus.Ready:
                    int device = 1;
                    if (Device.ActiveProcess == p)
                    {
                        Device.Clear();
                        device = 1;
                    }
                    else if (Device2.ActiveProcess == p)
                    {
                        Device2.Clear();
                        device = 2;
                    }
                    p.BurstTime = _processRand.Next(ModelSettings.MinValueOfBurstTime,
                        ModelSettings.MaxValueOfBurstTime + 1);
                    p.ResetWorkTime();
                    p.Priority = 1;
                    ReadyQueue.Put(p);
                    if (Cpu.IsFree())
                    {
                        ReadyQueue = _cpuScheduler.Session();
                    }

                    if (device == 1 && DeviceQueue.Count != 0)
                    {
                        DeviceQueue = _deviceScheduler.Session();
                    }
                    if (device == 2 && Device2Queue.Count != 0)
                    {
                        Device2Queue = _device2Scheduler.Session();
                    }
                    break;
                
                case ProcessStatus.Terminated:
                    Statistics.EndedProcessCount++;
                    Cpu.Clear();
                    ReadyQueue = _cpuScheduler.Session();
                    _memoryManager.Free(p);
                    Unsubscribe(p);
                    break;
                
                case ProcessStatus.Waiting:
                    Cpu.Clear();
                    Statistics.EndedProcessCount++;
                    p.BurstTime = _processRand.Next(ModelSettings.MinValueOfBurstTime,
                        ModelSettings.MaxValueOfBurstTime + 1);
                    p.ResetWorkTime();

                    if(NeedLessTime(DeviceQueue, Device2Queue))
                    {
                        DeviceQueue = DeviceQueue.Put(p);
                        if (Device.IsFree())
                        {
                            DeviceQueue = _deviceScheduler.Session();
                        }
                    }
                    else
                    {
                        Device2Queue = Device2Queue.Put(p);
                        if (Device2.IsFree())
                        {
                            Device2Queue = _device2Scheduler.Session();
                        }
                    }
                    if (ReadyQueue.Count != 0)
                    {
                        ReadyQueue = _cpuScheduler.Session();
                    }
                    break;
                default:
                    break;
            }
        }

        private bool NeedLessTime(IQueueable<Process> deviceQueue, IQueueable<Process> device2Queue)
        {
            long device1Time = 0;
            foreach (var process in deviceQueue.ToArray())
            {
                device1Time += process.BurstTime;
            }
            device1Time += Device.ActiveProcess?.BurstTime ?? 0 - Device.ActiveProcess?.WorkTime ?? 0;
            long device2Time = 0;
            foreach (var process in device2Queue.ToArray())
            {
                device2Time += process.BurstTime;
            }
            device2Time += Device2.ActiveProcess?.BurstTime ?? 0 - Device2.ActiveProcess?.WorkTime ?? 0;
            return device1Time < device2Time;
        }

        private void Subscribe(Process p)
        {
            if (p != null)
            {
                p.FreeingAResource += FreeingAResourceEventHandler;
            }
        }

        private void Unsubscribe(Process p)
        {
            if (p != null)
            {
                p.FreeingAResource -= FreeingAResourceEventHandler;
            }
        }
    }
}