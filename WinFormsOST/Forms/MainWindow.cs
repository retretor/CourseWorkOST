using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Timers;
using System.Windows.Forms;

namespace OST_Labs
{
    public partial class MainWindow : Form
    {
        private readonly MainWindowView _mainWindowView;
        private Model _model;
        private Statistics _statisticsWindow = null;
        private bool _isCanAutoWork;
        private bool _isPaused;

        public double TimerInterval
        {
            get => timer.Interval;
            private set
            {
                timer.Interval = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            _model = new Model();
            _mainWindowView = new MainWindowView(_model, new Controller(), this);
            _mainWindowView.DataBind();
            Prepare();
        }

        private void Prepare()
        {
            // Settings
            UpdateSettings();
            
            // Buttons
            SaveSettingsButton.Enabled = true;
            EndSeanseButton.Enabled = false;
            WorkCycleButton.Enabled = false;
            PauseButton.Enabled = false;
            SettingsPanel.Enabled = true;
            
            // Interval buttons
            timerInterval.Enabled = radioButton2.Checked;
            timerPlus.Enabled = radioButton2.Checked;
            timerMinus.Enabled = radioButton2.Checked;
            timerMorePlus.Enabled = radioButton2.Checked;
            timerMoreMinus.Enabled = radioButton2.Checked;
            resetIntervalButton.Enabled = radioButton2.Checked;
            timerText.Enabled = radioButton2.Checked;
            
            // Booleans
            _isCanAutoWork = false;
            _isPaused = false;
        }

        private void SaveSettingsButton_Click(object sender, EventArgs e)
        {
            SessionPreparation();
            _mainWindowView.ReactToUserActions(ModelOperations.SaveSettings);
        }

        private void WorkCycleButton_Click(object sender, EventArgs e)
        {
            _mainWindowView.ReactToUserActions(ModelOperations.WorkingCycle);
        }

        private void EndSessionButton_Click(object sender, EventArgs e)
        {
            _mainWindowView.ReactToUserActions(ModelOperations.EndOfSession);
            EndOfSession();
            UpdateSettings();
        }

        private void SessionPreparation()
        {
            // Buttons
            SaveSettingsButton.Enabled = false;
            EndSeanseButton.Enabled = true;
            WorkCycleButton.Enabled = radioButton1.Checked;
            PauseButton.Enabled = radioButton2.Checked;
            SettingsPanel.Enabled = false;
            // AutoWork
            _isCanAutoWork = true;
            _isPaused = false;
            // RadioButtons
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
        }

        private void EndOfSession()
        {
            // Buttons
            EndSeanseButton.Enabled = false;
            SaveSettingsButton.Enabled = true;
            WorkCycleButton.Enabled = false;
            PauseButton.Enabled = false;
            SettingsPanel.Enabled = true;
            // AutoWork
            _isCanAutoWork = false;
            if(_isPaused)
                PauseButton_Click(null, null);
            // RadioButtons
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
        }

        private void UpdateSettings()
        {
            ProcessIntensivityNumeric.Value = 0.5m;
            MinWorkTimeNumeric.Value = MinWorkTimeNumeric.Minimum;
            MaxWorkTimeNumeric.Value = MaxWorkTimeNumeric.Minimum;
            MinAddrSpaceNumeric.Value = MinAddrSpaceNumeric.Minimum;
            MaxAddrSpaceNumeric.Value = MaxAddrSpaceNumeric.Minimum;
            RamSize.SelectedItem = RamSize.Items[0];
        }

        private void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (radioButton2.Checked && _isCanAutoWork && !_isPaused)
            {
                _mainWindowView.ReactToUserActions(ModelOperations.WorkingCycle);
            }
        }

        private void timerMoreMinus_Click(object sender, EventArgs e)
        {
            if (TimerInterval > 1000)
                TimerInterval -= 1000;
            else
                TimerInterval = 100;

        }

        private void timerMinus_Click(object sender, EventArgs e)
        {
            if (TimerInterval > 100)
                TimerInterval -= 100;
        }

        private void timerMorePlus_Click(object sender, EventArgs e)
        {
            TimerInterval += 1000;
        }

        private void timerPlus_Click(object sender, EventArgs e)
        {
            TimerInterval += 100;
        }
        private void resetIntervalButton_Click(object sender, EventArgs e)
        {
            TimerInterval = 1000;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            timerInterval.Enabled = radioButton2.Checked;
            timerPlus.Enabled = radioButton2.Checked;
            timerMinus.Enabled = radioButton2.Checked;
            timerMorePlus.Enabled = radioButton2.Checked;
            timerMoreMinus.Enabled = radioButton2.Checked;
            resetIntervalButton.Enabled = radioButton2.Checked;
            timerText.Enabled = radioButton2.Checked;
        }

        private void openStatisticButton_Click(object sender, EventArgs e)
        {
            _statisticsWindow = new Statistics(_model);
            _statisticsWindow.Show();
        }

        private void newWindowChecker_Elapsed(object sender, ElapsedEventArgs e)
        {
            if(_statisticsWindow != null && _statisticsWindow.IsDisposed)
            {
                _statisticsWindow = null;
            }
            
            if(_statisticsWindow != null)
            {
                _statisticsWindow.Update();
                //_statisticsWindow.Refresh();
            }
            
            StatisticButtonCheck();
        }

        private void StatisticButtonCheck()
        {
            openStatisticButton.Enabled = _statisticsWindow == null;
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            _isPaused = !_isPaused;
            ChangeButtonColor(_isPaused, PauseButton);
            if(_isPaused)
                PauseButton.Text = "Старт";
            else
                PauseButton.Text = "Пауза";
            
            WorkCycleButton.Enabled = _isPaused;
        }

        private void ChangeButtonColor(bool param, Button button)
        {
            if (param)
            {
                button.BackColor = SystemColors.ActiveCaption;
            }
            else
            {
                button.BackColor = SystemColors.Control;
                button.UseVisualStyleBackColor = true;
            }
        }
    }
}
