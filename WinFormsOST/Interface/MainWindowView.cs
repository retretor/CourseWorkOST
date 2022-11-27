using Queues;
using System.ComponentModel;
using System.Windows.Forms;
using OST_Labs.DataTypes.MultilevelFeedbackQueues;

namespace OST_Labs
{
    class MainWindowView : View
    {
        private readonly MainWindow form;
        public MainWindowView(Model model, Controller controller, MainWindow form) : base(model, controller)
        {
            this.form = form;
        }

        public override void DataBind()
        {
            // Cpu process
            Binding cpuText = new Binding("Text", Model.Cpu, "ActiveProcess");
            form.CpuText.DataBindings.Add(cpuText);
            // Device process
            Binding deviceText = new Binding("Text", Model.Device, "ActiveProcess");
            form.DeviceText.DataBindings.Add(deviceText);
            // Device 2 process
            Binding device2Text = new Binding("Text", Model.Device2, "ActiveProcess");
            form.Device2Text.DataBindings.Add(device2Text);
            // Occupied RAM
            Binding occupiedRamText = new Binding("Text", Model.Ram, "OccupiedSize");
            form.OccupiedRamText.DataBindings.Add(occupiedRamText);
            // Free RAM
            Binding freeRamText = new Binding("Text", Model.Ram, "FreeSize");
            form.FreeRamText.DataBindings.Add(freeRamText);
            // System clock
            Binding tasksText = new Binding("Text", Model.Clock, "Clock");
            form.TacktsText.DataBindings.Add(tasksText);
            // Timer Interval
            Binding timerIntervalText = new Binding("Text", form, "TimerInterval");
            form.timerInterval.DataBindings.Add(timerIntervalText);

            // Intensivity
            Binding intensity = new Binding("Value", Model.ModelSettings, "Intensity");
            intensity.ControlUpdateMode = ControlUpdateMode.Never;
            form.ProcessIntensivityNumeric.DataBindings.Add(intensity);
            // MinWorkTimeNumeric
            Binding minWorkTimeNumeric = new Binding("Value", Model.ModelSettings, "MinValueOfBurstTime");
            minWorkTimeNumeric.ControlUpdateMode = ControlUpdateMode.Never;
            form.MinWorkTimeNumeric.DataBindings.Add(minWorkTimeNumeric);
            // MaxWorkTimeNumeric
            Binding maxWorkTimeNumeric = new Binding("Value", Model.ModelSettings, "MaxValueOfBurstTime");
            maxWorkTimeNumeric.ControlUpdateMode = ControlUpdateMode.Never;
            form.MaxWorkTimeNumeric.DataBindings.Add(maxWorkTimeNumeric);
            // MinAddrSpaceNumeric
            Binding minAddrSpaceNumeric = new Binding("Value", Model.ModelSettings, "MinValueOfAddrSpace");
            minAddrSpaceNumeric.ControlUpdateMode = ControlUpdateMode.Never;
            form.MinAddrSpaceNumeric.DataBindings.Add(minAddrSpaceNumeric);
            // MaxAddrSpaceNumeric
            Binding maxAddrSpaceNumeric = new Binding("Value", Model.ModelSettings, "MaxValueOfAddrSpace");
            maxAddrSpaceNumeric.ControlUpdateMode = ControlUpdateMode.Never;
            form.MaxAddrSpaceNumeric.DataBindings.Add(maxAddrSpaceNumeric);
            // ValueOfRamSize
            Binding valueOfRamSize = new Binding("SelectedItem", Model.ModelSettings, "ValueOfRamSize", true);
            valueOfRamSize.ControlUpdateMode = ControlUpdateMode.Never;
            form.RamSize.DataBindings.Add(valueOfRamSize);
            
            Subscribe();

        }

        public override void DataUnbind()
        {
            form.CpuText.DataBindings.RemoveAt(0);
            form.DeviceText.DataBindings.RemoveAt(0);
            form.Device2Text.DataBindings.RemoveAt(0);
            form.OccupiedRamText.DataBindings.RemoveAt(0);
            form.FreeRamText.DataBindings.RemoveAt(0);
            form.TacktsText.DataBindings.RemoveAt(0);
            form.ProcessIntensivityNumeric.DataBindings.RemoveAt(0);
            form.MinWorkTimeNumeric.DataBindings.RemoveAt(0);
            form.MaxWorkTimeNumeric.DataBindings.RemoveAt(0);
            form.MinAddrSpaceNumeric.DataBindings.RemoveAt(0);
            form.MaxAddrSpaceNumeric.DataBindings.RemoveAt(0);
            form.RamSize.DataBindings.Clear();
            form.timerInterval.DataBindings.RemoveAt(0);
            Unsubscribe();
        }

        private void Subscribe()
        {
            Model.PropertyChanged += new PropertyChangedEventHandler(PropertyChangedHandler);
            Model.ReadyQueue.PropertyChanged += new PropertyChangedEventHandler(PropertyChangedHandler);
            form.PropertyChanged += new PropertyChangedEventHandler(PropertyChangedHandler);
        }
        private void Unsubscribe()
        {
            Model.PropertyChanged -= PropertyChangedHandler;
            Model.ReadyQueue.PropertyChanged -= PropertyChangedHandler;
            form.PropertyChanged -= PropertyChangedHandler;
        }
        private void PropertyChangedHandler(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "ReadyQueue":
                    UpdateListBox(Model.ReadyQueue.ReadyQueue, form.CpuQueueList);
                    break;
                case "ReadyQueue2":
                    UpdateListBox(Model.ReadyQueue.ReadyQueue2, form.CpuQueue2List);
                    break;
                case "ReadyQueue3":
                    UpdateListBox(Model.ReadyQueue.ReadyQueue3, form.CpuQueue3List);
                    break;
                case "ReadyQueue4":
                    UpdateListBox(Model.ReadyQueue.ReadyQueue4, form.CpuQueue4List);
                    break;
                case "DeviceQueue":
                    UpdateListBox(Model.DeviceQueue, form.DeviceQueueList);
                    break;
                case "Device2Queue":
                    UpdateListBox(Model.Device2Queue, form.Device2QueueList);
                    break;
                case "TimerInterval":
                    form.timer.Interval = form.TimerInterval;
                    form.timerInterval.Text = form.TimerInterval.ToString();
                    break;
            }
        }

        private void UpdateListBox(IQueueable<Process> queue, ListBox lb)
        {
            lb.Items.Clear();
            if (queue.Count != 0)
                lb.Items.AddRange(queue.ToArray());
        }
    }
}

