using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace OST_Labs
{
    public class CollectStatistics
    {
        #region Fields
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string property = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        private double _intensivity;
        private long _maxCpuWorkTime;
        private long _minCpuWorkTime;
        private long _allWorkTime;
        private long _allProcessCount;
        private long _rejectedProcessCount;
        private long _endedProcessCount;
        private long _maxQueueLength;
        private long _avgQueueLength;
        private long _restCpuTime;
        private long _loadedCpu;
        private long _systemPerformance;
        
        // for every field create property with get and set methods and call OnPropertyChanged() method in set method
        public double Intensivity
        {
            get { return _intensivity; }
            set
            {
                _intensivity = value;
                OnPropertyChanged();
            }
        }
        public long MaxCpuWorkTime
        {
            get { return _maxCpuWorkTime; }
            set
            {
                _maxCpuWorkTime = value;
                OnPropertyChanged();
            }
        }
        public long MinCpuWorkTime
        {
            get { return _minCpuWorkTime; }
            set
            {
                _minCpuWorkTime = value;
                OnPropertyChanged();
            }
        }
        public long AllWorkTime
        {
            get { return _allWorkTime; }
            set
            {
                _allWorkTime = value;
                OnPropertyChanged();
            }
        }
        public long AllProcessCount
        {
            get { return _allProcessCount; }
            set
            {
                _allProcessCount = value;
                OnPropertyChanged();
            }
        }
        public long RejectedProcessCount
        {
            get { return _rejectedProcessCount; }
            set
            {
                _rejectedProcessCount = value;
                OnPropertyChanged();
            }
        }
        public long EndedProcessCount
        {
            get { return _endedProcessCount; }
            set
            {
                _endedProcessCount = value;
                OnPropertyChanged();
            }
        }
        public long MaxQueueLength
        {
            get { return _maxQueueLength; }
            set
            {
                _maxQueueLength = value;
                OnPropertyChanged();
            }
        }

        private long countQueues = 0;
        private long queuesLength = 0;
        public long AvgQueueLength
        {
            get { return _avgQueueLength; }
            set
            {
                queuesLength += value;
                countQueues++;
                _avgQueueLength = queuesLength / countQueues;
                OnPropertyChanged();
            }
        }
        public long RestCpuTime
        {
            get { return _restCpuTime; }
            set
            {
                _restCpuTime = value;
                OnPropertyChanged();
            }
        }
        public long LoadedCpu
        {
            get { return _loadedCpu; }
            set
            {
                _loadedCpu = value;
                OnPropertyChanged();
            }
        }
        public long SystemPerformance
        {
            get { return _systemPerformance; }
            set
            {
                _systemPerformance = value;
                OnPropertyChanged();
            }
        }
        #endregion
        
        private readonly Settings _settings;

        public CollectStatistics(Settings settings)
        {
            Clear();
            this._settings = settings;
        }

        public void Save()
        {
            Intensivity = _settings.Intensity;
            MaxCpuWorkTime = _settings.MaxValueOfBurstTime;
            MinCpuWorkTime = _settings.MinValueOfBurstTime;
        }

        public void Clear()
        {
            Intensivity = 0;
            MaxCpuWorkTime = 0;
            MinCpuWorkTime = 0;
            AllWorkTime = 0;
            AllProcessCount = 0;
            RejectedProcessCount = 0;
            EndedProcessCount = 0;
            MaxQueueLength = 0;
            AvgQueueLength = 0;
            RestCpuTime = 0;
            LoadedCpu = 0;
            SystemPerformance = 0;

            countQueues = 0;
            queuesLength = 0;
        }

        public void WorkingCycle()
        {
            AllWorkTime++;
            // SystemPerformance in percents
            SystemPerformance = (EndedProcessCount * 100) / AllWorkTime;
            // LoadedCpu in percents
            LoadedCpu = (AllWorkTime - RestCpuTime) * 100 / AllWorkTime - 1;
        }
    }
}