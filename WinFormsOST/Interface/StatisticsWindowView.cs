using Queues;
using System.ComponentModel;
using System.Windows.Forms;

namespace OST_Labs
{
    class StatisticsWindowView : View
    {
        private readonly Statistics _form;
        public StatisticsWindowView(Model model, Controller controller, Statistics form) : base(model, controller)
        {
            this._form = form;
        }

        public override void DataBind()
        {
            Binding intensivity = new Binding("Text", Model.Statistics, "Intensivity");
            _form.Intensivity.DataBindings.Add(intensivity);

            Binding maxCpuWorkTime = new Binding("Text", Model.Statistics, "MaxCpuWorkTime");
            _form.MaxCpuWorkTime.DataBindings.Add(maxCpuWorkTime);

            Binding minCpuWorkTime = new Binding("Text", Model.Statistics, "MinCpuWorkTime");
            _form.MinCpuWorkTime.DataBindings.Add(minCpuWorkTime);

            Binding allWorkTime = new Binding("Text", Model.Statistics, "AllWorkTime");
            _form.allWorkTime.DataBindings.Add(allWorkTime);

            Binding allProcessCount = new Binding("Text", Model.Statistics, "AllProcessCount");
            _form.AllProcessCount.DataBindings.Add(allProcessCount);
            
            Binding rejectedProcessCount = new Binding("Text", Model.Statistics, "RejectedProcessCount");
            _form.rejectedProcessCount.DataBindings.Add(rejectedProcessCount);
            
            Binding endedProcessCount = new Binding("Text", Model.Statistics, "EndedProcessCount");
            _form.EndedProcessCount.DataBindings.Add(endedProcessCount);
            
            Binding maxQueueLength = new Binding("Text", Model.Statistics, "MaxQueueLength");
            _form.maxQueueLength.DataBindings.Add(maxQueueLength);
            
            Binding avgQueueLength = new Binding("Text", Model.Statistics, "AvgQueueLength");
            _form.avgQueueLength.DataBindings.Add(avgQueueLength);
            
            Binding restCpuTime = new Binding("Text", Model.Statistics, "RestCpuTime");
            _form.RestCpuTime.DataBindings.Add(restCpuTime);
            
            Binding loadedCpu = new Binding("Text", Model.Statistics, "LoadedCpu");
            _form.LoadedCpu.DataBindings.Add(loadedCpu);
            
            Binding systemPerformance = new Binding("Text", Model.Statistics, "SystemPerformance");
            _form.SystemPerformance.DataBindings.Add(systemPerformance);
        }

        public override void DataUnbind()
        {
            _form.allWorkTime.DataBindings.RemoveAt(0);
            _form.AllProcessCount.DataBindings.RemoveAt(0);
            _form.EndedProcessCount.DataBindings.RemoveAt(0);
            _form.Intensivity.DataBindings.RemoveAt(0);
            _form.MaxCpuWorkTime.DataBindings.RemoveAt(0);
            _form.MinCpuWorkTime.DataBindings.RemoveAt(0);
            _form.rejectedProcessCount.DataBindings.RemoveAt(0);
            _form.avgQueueLength.DataBindings.RemoveAt(0);
            _form.maxQueueLength.DataBindings.RemoveAt(0);
            _form.RestCpuTime.DataBindings.RemoveAt(0);
            _form.LoadedCpu.DataBindings.RemoveAt(0);
            _form.SystemPerformance.DataBindings.RemoveAt(0);
        }
    }
}