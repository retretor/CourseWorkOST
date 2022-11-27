using System;
using System.Windows.Forms;

namespace OST_Labs
{
    public partial class Statistics : Form
    {
        private readonly Model _model;
        private readonly StatisticsWindowView _statisticsWindowView;
        public Statistics(Model model)
        {
            InitializeComponent();
            _model = model;
            _statisticsWindowView = new StatisticsWindowView(_model, null, this);
            _statisticsWindowView.DataBind();
        }
    }
}