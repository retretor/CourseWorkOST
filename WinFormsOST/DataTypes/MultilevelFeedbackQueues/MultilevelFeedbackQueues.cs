using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Queues;
using Structures;

namespace OST_Labs.DataTypes.MultilevelFeedbackQueues
{
    public class MultilevelFeedbackQueues
    {

        public MultilevelFeedbackQueues()
        {
            ReadyQueue = new PriorityQueue<Process, QueueableLinkedList<Process>>(new QueueableLinkedList<Process>());
            ReadyQueue2 = new PriorityQueue<Process, QueueableLinkedList<Process>>(new QueueableLinkedList<Process>());
            ReadyQueue3 = new PriorityQueue<Process, QueueableLinkedList<Process>>(new QueueableLinkedList<Process>());
            ReadyQueue4 = new PriorityQueue<Process, QueueableLinkedList<Process>>(new QueueableLinkedList<Process>());
            MaxTimeSession1 = 2;
            MaxTimeSession2 = 2 * MaxTimeSession1;
            MaxTimeSession3 = 2 * MaxTimeSession2;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string property = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
        private IQueueable<Process> _readyQueue;
        private IQueueable<Process> _readyQueue2;
        private IQueueable<Process> _readyQueue3;
        private IQueueable<Process> _readyQueue4;
        public int MaxTimeSession1 { get; private set; }
        public int MaxTimeSession2 { get; private set; }
        public int MaxTimeSession3 { get; private set; }
        public IQueueable<Process> ReadyQueue
        {
            get => _readyQueue;
            private set { _readyQueue = value; OnPropertyChanged(); }
        }
        public IQueueable<Process> ReadyQueue2
        {
            get => _readyQueue2;
            private set { _readyQueue2 = value; OnPropertyChanged(); }
        }
        public IQueueable<Process> ReadyQueue3
        {
            get => _readyQueue3;
            private set { _readyQueue3 = value; OnPropertyChanged(); }
        }
        public IQueueable<Process> ReadyQueue4
        {
            get => _readyQueue4;
            private set { _readyQueue4 = value; OnPropertyChanged(); }
        }

        public int Count => ReadyQueue.Count + ReadyQueue2.Count + ReadyQueue3.Count + ReadyQueue4.Count;

        public Process[] ToArray()
        {
            Process[] array = new Process[ReadyQueue.Count + ReadyQueue2.Count + ReadyQueue3.Count + ReadyQueue4.Count];
            int i = 0;
            foreach (Process process in _readyQueue.ToArray())
            {
                array[i] = process;
                i++;
            }
            foreach (Process process in _readyQueue2.ToArray())
            {
                array[i] = process;
                i++;
            }
            foreach (Process process in _readyQueue3.ToArray())
            {
                array[i] = process;
                i++;
            }
            foreach (Process process in _readyQueue4.ToArray())
            {
                array[i] = process;
                i++;
            }
            return array;
        }
        public void Put(Process process)
        {
            switch (process.Priority)
            {
                case 1:
                    ReadyQueue = ReadyQueue.Put(process);
                    break;
                case 2:
                    ReadyQueue2 = ReadyQueue2.Put(process);
                    break;
                case 3:
                    ReadyQueue3 = ReadyQueue3.Put(process);
                    break;
                case 4:
                    ReadyQueue4 = ReadyQueue4.Put(process);
                    break;
            }
        }
        public void Clear()
        {
            ReadyQueue = ReadyQueue.Clear();
            ReadyQueue2 = ReadyQueue2.Clear();
            ReadyQueue3 = ReadyQueue3.Clear();
            ReadyQueue4 = ReadyQueue4.Clear();
        }
        public Process Get()
        {
            if (ReadyQueue.Count > 0)
            {
                Process p = ReadyQueue.Item();
                ReadyQueue = ReadyQueue.Remove();
                return p;
            }
            if (ReadyQueue2.Count > 0)
            {
                Process p = ReadyQueue2.Item();
                ReadyQueue2 = ReadyQueue2.Remove();
                return p;
            }
            if (ReadyQueue3.Count > 0)
            {
                Process p = ReadyQueue3.Item();
                ReadyQueue3 = ReadyQueue3.Remove();
                return p;
            }
            if (ReadyQueue4.Count > 0)
            {
                Process p = ReadyQueue4.Item();
                ReadyQueue4 = ReadyQueue4.Remove();
                return p;
            }
            return null;
        }
    }
}