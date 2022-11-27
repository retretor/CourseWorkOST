using System;

namespace OST_Labs
{
    public class Process : IComparable, IComparable<Process>
    {
        private readonly long _id;
        private readonly string _name;
        private readonly Random _random;
        private long arrivalTime;
        private long readyQueueArrivalTime;
        private long commonWaitingTime;
        // Statistics
        public long ArrivalTime
        {
            get { return arrivalTime; }
            set { arrivalTime = value; }
        }

        public long BurstTime { get; set; }
        public long WorkTime { get; private set; }
        public long QueueWorkTime { get; set; }

        public int Priority { get; set; }

        public void IncreasePriority()
        {
            Priority++;
            if(Priority > 4)
                Priority = 4;
        }
        public ProcessStatus ProcessStatus { get; set; }
        public long AddressSpace { get; }
        public event EventHandler FreeingAResource;

        public Process(long pId, long pAddressSpace)
        {
            _id = pId;
            AddressSpace = pAddressSpace;
            ProcessStatus = ProcessStatus.Ready;
            _name = "Process " + pId;
            Priority = 1;
            _random = new Random();
            Priority = 1;
        }
        public void IncreaseWorkTime()
        {
            if (WorkTime < BurstTime)
            {
                WorkTime++;
                QueueWorkTime++;
            }
            else
            {
                if (ProcessStatus == ProcessStatus.Running)
                {
                    ProcessStatus = _random.Next(0, 2) == 0 ? ProcessStatus.Terminated : ProcessStatus.Waiting;
                }
                else
                {
                    ProcessStatus = ProcessStatus.Ready;
                }
                OnFreeingAResource(this, null);
            }
        }

        public void ResetWorkTime()
        {
            WorkTime = 0;
            QueueWorkTime = 0;
        }

        public override string ToString()
        {
            return "Process ID: " + _id +
                   "; Process Name: " + _name +
                   "; Process Status: " + ProcessStatus +
                   "; Process Address Space: " + AddressSpace +
                   "; Process Burst Time: " + BurstTime + ";";
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            if (obj is Process otherProcess)
            {
                if (BurstTime < otherProcess.BurstTime)
                    return -1;
                return BurstTime < otherProcess.BurstTime ? 1 : 0;
            }
            throw new ArgumentException("Object is not a Process");
        }
        public int CompareTo(Process other)
        {
            if (other == null)
            {
                return 1;
            }
            return other.BurstTime.CompareTo(BurstTime);
        }

        private void OnFreeingAResource(object sender, EventArgs e)
        {
            if (FreeingAResource != null)
            {
                FreeingAResource(sender, e);
            }
        }

    }

    public enum ProcessStatus
    {
        Ready,
        Running,
        Waiting,
        Terminated
    }
}