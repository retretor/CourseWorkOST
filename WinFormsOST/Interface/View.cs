using System;

namespace OST_Labs
{
    abstract class View : IDisposable
    {
        protected View(Model model, Controller controller = null)
        {
            Model = model;
            Controller = controller;
        }

        protected readonly Model Model;

        private Controller Controller { get; set; }
        
        public void ReactToUserActions(ModelOperations modelOperation)
        {
            Controller.Execute(modelOperation, Model);
        }
        public void Dispose()
        {
            DataUnbind();
        }

        public abstract void DataBind();
        public abstract void DataUnbind();
    }
}
