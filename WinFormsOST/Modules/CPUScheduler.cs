using OST_Labs.DataTypes.MultilevelFeedbackQueues;
using Queues;

namespace OST_Labs
{
    public class CpuScheduler
    {
        private Resource _resource;
        private MultilevelFeedbackQueues _queue;

        public CpuScheduler(Resource resource, MultilevelFeedbackQueues queue)
        {
            _resource = resource;
            _queue = queue;
        }

        public MultilevelFeedbackQueues Session()
        {
            Process process = _queue.Get();
            if (process == null)
            {
                return _queue;
            }

            process.ProcessStatus = ProcessStatus.Running;
            _resource.ActiveProcess = process;
            return _queue;
        }
    }
}