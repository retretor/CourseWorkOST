namespace OST_Labs
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CpuText = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.DeviceText = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.RamSize = new System.Windows.Forms.ComboBox();
            this.ProcessIntensivityNumeric = new System.Windows.Forms.NumericUpDown();
            this.MinWorkTimeNumeric = new System.Windows.Forms.NumericUpDown();
            this.MaxWorkTimeNumeric = new System.Windows.Forms.NumericUpDown();
            this.MinAddrSpaceNumeric = new System.Windows.Forms.NumericUpDown();
            this.MaxAddrSpaceNumeric = new System.Windows.Forms.NumericUpDown();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.FreeRamText = new System.Windows.Forms.TextBox();
            this.OccupiedRamText = new System.Windows.Forms.TextBox();
            this.TacktsText = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SaveSettingsButton = new System.Windows.Forms.Button();
            this.WorkCycleButton = new System.Windows.Forms.Button();
            this.EndSeanseButton = new System.Windows.Forms.Button();
            this.openStatisticButton = new System.Windows.Forms.Button();
            this.CpuQueueList = new System.Windows.Forms.ListBox();
            this.DeviceQueueList = new System.Windows.Forms.ListBox();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.timer = new System.Timers.Timer();
            this.timerInterval = new System.Windows.Forms.TextBox();
            this.timerText = new System.Windows.Forms.TextBox();
            this.timerMoreMinus = new System.Windows.Forms.Button();
            this.timerMinus = new System.Windows.Forms.Button();
            this.timerPlus = new System.Windows.Forms.Button();
            this.timerMorePlus = new System.Windows.Forms.Button();
            this.resetIntervalButton = new System.Windows.Forms.Button();
            this.newWindowChecker = new System.Timers.Timer();
            this.Device2QueueList = new System.Windows.Forms.ListBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.Device2Text = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.PauseButton = new System.Windows.Forms.Button();
            this.CpuQueue2List = new System.Windows.Forms.ListBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.CpuQueue3List = new System.Windows.Forms.ListBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.CpuQueue4List = new System.Windows.Forms.ListBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessIntensivityNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinWorkTimeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxWorkTimeNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinAddrSpaceNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxAddrSpaceNumeric)).BeginInit();
            this.SettingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newWindowChecker)).BeginInit();
            this.SuspendLayout();
            // 
            // CpuText
            // 
            this.CpuText.Location = new System.Drawing.Point(12, 126);
            this.CpuText.Name = "CpuText";
            this.CpuText.ReadOnly = true;
            this.CpuText.Size = new System.Drawing.Size(604, 20);
            this.CpuText.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 0);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(117, 82);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Интенсивность поступления процессов";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(123, 0);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(117, 82);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Минимальное значение промежутка работы на ЦП";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(246, 0);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(117, 82);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "Максимальное значение промежутка работы на ЦП";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(369, 0);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(117, 82);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "Размер оперативной памяти";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(492, 0);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(117, 82);
            this.textBox6.TabIndex = 5;
            this.textBox6.Text = "Минимальный размер адресного пространства процесса";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(615, 0);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(117, 82);
            this.textBox7.TabIndex = 6;
            this.textBox7.Text = "Максимальный размер адресного пространства процесса";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(12, 100);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(604, 20);
            this.textBox8.TabIndex = 7;
            this.textBox8.Text = "Центральный процессор";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(627, 100);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(604, 20);
            this.textBox9.TabIndex = 8;
            this.textBox9.Text = "Внешнее устройство 1";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DeviceText
            // 
            this.DeviceText.Location = new System.Drawing.Point(627, 126);
            this.DeviceText.Name = "DeviceText";
            this.DeviceText.ReadOnly = true;
            this.DeviceText.Size = new System.Drawing.Size(604, 20);
            this.DeviceText.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(627, 152);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(604, 19);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "Очередь к внешнему устройству 1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(12, 152);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(604, 19);
            this.textBox10.TabIndex = 10;
            this.textBox10.Text = "Очередь 1 к ЦП";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RamSize
            // 
            this.RamSize.FormattingEnabled = true;
            this.RamSize.Items.AddRange(new object[] { "1000", "2000", "4000", "8000", "16000", "32000" });
            this.RamSize.Location = new System.Drawing.Point(369, 58);
            this.RamSize.Name = "RamSize";
            this.RamSize.Size = new System.Drawing.Size(117, 21);
            this.RamSize.TabIndex = 14;
            // 
            // ProcessIntensivityNumeric
            // 
            this.ProcessIntensivityNumeric.DecimalPlaces = 1;
            this.ProcessIntensivityNumeric.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            this.ProcessIntensivityNumeric.Location = new System.Drawing.Point(3, 59);
            this.ProcessIntensivityNumeric.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            this.ProcessIntensivityNumeric.Name = "ProcessIntensivityNumeric";
            this.ProcessIntensivityNumeric.Size = new System.Drawing.Size(117, 20);
            this.ProcessIntensivityNumeric.TabIndex = 15;
            // 
            // MinWorkTimeNumeric
            // 
            this.MinWorkTimeNumeric.Location = new System.Drawing.Point(123, 59);
            this.MinWorkTimeNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.MinWorkTimeNumeric.Name = "MinWorkTimeNumeric";
            this.MinWorkTimeNumeric.Size = new System.Drawing.Size(117, 20);
            this.MinWorkTimeNumeric.TabIndex = 16;
            this.MinWorkTimeNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // MaxWorkTimeNumeric
            // 
            this.MaxWorkTimeNumeric.Location = new System.Drawing.Point(246, 59);
            this.MaxWorkTimeNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.MaxWorkTimeNumeric.Name = "MaxWorkTimeNumeric";
            this.MaxWorkTimeNumeric.Size = new System.Drawing.Size(117, 20);
            this.MaxWorkTimeNumeric.TabIndex = 17;
            this.MaxWorkTimeNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // MinAddrSpaceNumeric
            // 
            this.MinAddrSpaceNumeric.Location = new System.Drawing.Point(492, 59);
            this.MinAddrSpaceNumeric.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.MinAddrSpaceNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.MinAddrSpaceNumeric.Name = "MinAddrSpaceNumeric";
            this.MinAddrSpaceNumeric.Size = new System.Drawing.Size(117, 20);
            this.MinAddrSpaceNumeric.TabIndex = 18;
            this.MinAddrSpaceNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // MaxAddrSpaceNumeric
            // 
            this.MaxAddrSpaceNumeric.Location = new System.Drawing.Point(615, 58);
            this.MaxAddrSpaceNumeric.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.MaxAddrSpaceNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.MaxAddrSpaceNumeric.Name = "MaxAddrSpaceNumeric";
            this.MaxAddrSpaceNumeric.Size = new System.Drawing.Size(117, 20);
            this.MaxAddrSpaceNumeric.TabIndex = 19;
            this.MaxAddrSpaceNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(12, 434);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(236, 20);
            this.textBox12.TabIndex = 21;
            this.textBox12.Text = "Размер свободной памяти";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(12, 459);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(236, 20);
            this.textBox13.TabIndex = 22;
            this.textBox13.Text = "Размер занятой памяти";
            // 
            // FreeRamText
            // 
            this.FreeRamText.Location = new System.Drawing.Point(258, 434);
            this.FreeRamText.Name = "FreeRamText";
            this.FreeRamText.ReadOnly = true;
            this.FreeRamText.Size = new System.Drawing.Size(113, 20);
            this.FreeRamText.TabIndex = 23;
            // 
            // OccupiedRamText
            // 
            this.OccupiedRamText.Location = new System.Drawing.Point(258, 459);
            this.OccupiedRamText.Name = "OccupiedRamText";
            this.OccupiedRamText.ReadOnly = true;
            this.OccupiedRamText.Size = new System.Drawing.Size(113, 20);
            this.OccupiedRamText.TabIndex = 24;
            // 
            // TacktsText
            // 
            this.TacktsText.Location = new System.Drawing.Point(258, 485);
            this.TacktsText.Name = "TacktsText";
            this.TacktsText.ReadOnly = true;
            this.TacktsText.Size = new System.Drawing.Size(113, 20);
            this.TacktsText.TabIndex = 25;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(381, 434);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(117, 20);
            this.textBox14.TabIndex = 26;
            this.textBox14.Text = "Режим работы";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(381, 459);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 17);
            this.radioButton1.TabIndex = 27;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ручной";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(381, 485);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(109, 17);
            this.radioButton2.TabIndex = 28;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Автоматический";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // SaveSettingsButton
            // 
            this.SaveSettingsButton.BackColor = System.Drawing.SystemColors.Control;
            this.SaveSettingsButton.Location = new System.Drawing.Point(12, 542);
            this.SaveSettingsButton.Name = "SaveSettingsButton";
            this.SaveSettingsButton.Size = new System.Drawing.Size(113, 45);
            this.SaveSettingsButton.TabIndex = 29;
            this.SaveSettingsButton.Text = "Сохранение настроек";
            this.SaveSettingsButton.UseVisualStyleBackColor = true;
            this.SaveSettingsButton.Click += new System.EventHandler(this.SaveSettingsButton_Click);
            // 
            // WorkCycleButton
            // 
            this.WorkCycleButton.Location = new System.Drawing.Point(135, 542);
            this.WorkCycleButton.Name = "WorkCycleButton";
            this.WorkCycleButton.Size = new System.Drawing.Size(113, 45);
            this.WorkCycleButton.TabIndex = 30;
            this.WorkCycleButton.Text = "Рабочий такт";
            this.WorkCycleButton.UseVisualStyleBackColor = true;
            this.WorkCycleButton.Click += new System.EventHandler(this.WorkCycleButton_Click);
            // 
            // EndSeanseButton
            // 
            this.EndSeanseButton.Location = new System.Drawing.Point(381, 542);
            this.EndSeanseButton.Name = "EndSeanseButton";
            this.EndSeanseButton.Size = new System.Drawing.Size(113, 45);
            this.EndSeanseButton.TabIndex = 31;
            this.EndSeanseButton.Text = "Завершение сеанса";
            this.EndSeanseButton.UseVisualStyleBackColor = true;
            this.EndSeanseButton.Click += new System.EventHandler(this.EndSessionButton_Click);
            // 
            // openStatisticButton
            // 
            this.openStatisticButton.Location = new System.Drawing.Point(508, 542);
            this.openStatisticButton.Name = "openStatisticButton";
            this.openStatisticButton.Size = new System.Drawing.Size(113, 45);
            this.openStatisticButton.TabIndex = 32;
            this.openStatisticButton.Text = "Сводка";
            this.openStatisticButton.UseVisualStyleBackColor = true;
            this.openStatisticButton.Click += new System.EventHandler(this.openStatisticButton_Click);
            // 
            // CpuQueueList
            // 
            this.CpuQueueList.FormattingEnabled = true;
            this.CpuQueueList.Location = new System.Drawing.Point(12, 172);
            this.CpuQueueList.Name = "CpuQueueList";
            this.CpuQueueList.Size = new System.Drawing.Size(604, 43);
            this.CpuQueueList.TabIndex = 33;
            // 
            // DeviceQueueList
            // 
            this.DeviceQueueList.FormattingEnabled = true;
            this.DeviceQueueList.Location = new System.Drawing.Point(627, 172);
            this.DeviceQueueList.Name = "DeviceQueueList";
            this.DeviceQueueList.Size = new System.Drawing.Size(604, 173);
            this.DeviceQueueList.TabIndex = 34;
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.Controls.Add(this.MinAddrSpaceNumeric);
            this.SettingsPanel.Controls.Add(this.RamSize);
            this.SettingsPanel.Controls.Add(this.MaxWorkTimeNumeric);
            this.SettingsPanel.Controls.Add(this.MinWorkTimeNumeric);
            this.SettingsPanel.Controls.Add(this.textBox5);
            this.SettingsPanel.Controls.Add(this.textBox6);
            this.SettingsPanel.Controls.Add(this.ProcessIntensivityNumeric);
            this.SettingsPanel.Controls.Add(this.MaxAddrSpaceNumeric);
            this.SettingsPanel.Controls.Add(this.textBox7);
            this.SettingsPanel.Controls.Add(this.textBox4);
            this.SettingsPanel.Controls.Add(this.textBox3);
            this.SettingsPanel.Controls.Add(this.textBox2);
            this.SettingsPanel.Location = new System.Drawing.Point(12, 12);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(1219, 82);
            this.SettingsPanel.TabIndex = 35;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(12, 485);
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(236, 20);
            this.textBox15.TabIndex = 36;
            this.textBox15.Text = "Такт";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000D;
            this.timer.SynchronizingObject = this;
            this.timer.Elapsed += new System.Timers.ElapsedEventHandler(this.timer_Elapsed);
            // 
            // timerInterval
            // 
            this.timerInterval.Location = new System.Drawing.Point(258, 511);
            this.timerInterval.Name = "timerInterval";
            this.timerInterval.ReadOnly = true;
            this.timerInterval.Size = new System.Drawing.Size(113, 20);
            this.timerInterval.TabIndex = 37;
            // 
            // timerText
            // 
            this.timerText.Location = new System.Drawing.Point(12, 511);
            this.timerText.Name = "timerText";
            this.timerText.ReadOnly = true;
            this.timerText.Size = new System.Drawing.Size(236, 20);
            this.timerText.TabIndex = 38;
            this.timerText.Text = "Период работы (мс)";
            // 
            // timerMoreMinus
            // 
            this.timerMoreMinus.Location = new System.Drawing.Point(381, 511);
            this.timerMoreMinus.Name = "timerMoreMinus";
            this.timerMoreMinus.Size = new System.Drawing.Size(45, 20);
            this.timerMoreMinus.TabIndex = 39;
            this.timerMoreMinus.Text = "-1000";
            this.timerMoreMinus.UseVisualStyleBackColor = true;
            this.timerMoreMinus.Click += new System.EventHandler(this.timerMoreMinus_Click);
            // 
            // timerMinus
            // 
            this.timerMinus.Location = new System.Drawing.Point(426, 511);
            this.timerMinus.Name = "timerMinus";
            this.timerMinus.Size = new System.Drawing.Size(45, 20);
            this.timerMinus.TabIndex = 40;
            this.timerMinus.Text = "-100";
            this.timerMinus.UseVisualStyleBackColor = true;
            this.timerMinus.Click += new System.EventHandler(this.timerMinus_Click);
            // 
            // timerPlus
            // 
            this.timerPlus.Location = new System.Drawing.Point(516, 511);
            this.timerPlus.Name = "timerPlus";
            this.timerPlus.Size = new System.Drawing.Size(45, 20);
            this.timerPlus.TabIndex = 41;
            this.timerPlus.Text = "+100";
            this.timerPlus.UseVisualStyleBackColor = true;
            this.timerPlus.Click += new System.EventHandler(this.timerPlus_Click);
            // 
            // timerMorePlus
            // 
            this.timerMorePlus.Location = new System.Drawing.Point(561, 511);
            this.timerMorePlus.Name = "timerMorePlus";
            this.timerMorePlus.Size = new System.Drawing.Size(45, 20);
            this.timerMorePlus.TabIndex = 42;
            this.timerMorePlus.Text = "+1000";
            this.timerMorePlus.UseVisualStyleBackColor = true;
            this.timerMorePlus.Click += new System.EventHandler(this.timerMorePlus_Click);
            // 
            // resetIntervalButton
            // 
            this.resetIntervalButton.Location = new System.Drawing.Point(471, 511);
            this.resetIntervalButton.Name = "resetIntervalButton";
            this.resetIntervalButton.Size = new System.Drawing.Size(45, 20);
            this.resetIntervalButton.TabIndex = 49;
            this.resetIntervalButton.Text = "0";
            this.resetIntervalButton.UseVisualStyleBackColor = true;
            this.resetIntervalButton.Click += new System.EventHandler(this.resetIntervalButton_Click);
            // 
            // newWindowChecker
            // 
            this.newWindowChecker.Enabled = true;
            this.newWindowChecker.SynchronizingObject = this;
            this.newWindowChecker.Elapsed += new System.Timers.ElapsedEventHandler(this.newWindowChecker_Elapsed);
            // 
            // Device2QueueList
            // 
            this.Device2QueueList.FormattingEnabled = true;
            this.Device2QueueList.Location = new System.Drawing.Point(627, 419);
            this.Device2QueueList.Name = "Device2QueueList";
            this.Device2QueueList.Size = new System.Drawing.Size(604, 173);
            this.Device2QueueList.TabIndex = 53;
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(627, 398);
            this.textBox20.Multiline = true;
            this.textBox20.Name = "textBox20";
            this.textBox20.ReadOnly = true;
            this.textBox20.Size = new System.Drawing.Size(604, 19);
            this.textBox20.TabIndex = 52;
            this.textBox20.Text = "Очередь к внешнему устройству 2";
            this.textBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Device2Text
            // 
            this.Device2Text.Location = new System.Drawing.Point(627, 372);
            this.Device2Text.Name = "Device2Text";
            this.Device2Text.ReadOnly = true;
            this.Device2Text.Size = new System.Drawing.Size(604, 20);
            this.Device2Text.TabIndex = 51;
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(627, 347);
            this.textBox22.Multiline = true;
            this.textBox22.Name = "textBox22";
            this.textBox22.ReadOnly = true;
            this.textBox22.Size = new System.Drawing.Size(604, 20);
            this.textBox22.TabIndex = 50;
            this.textBox22.Text = "Внешнее устройство 2";
            this.textBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PauseButton
            // 
            this.PauseButton.BackColor = System.Drawing.SystemColors.Control;
            this.PauseButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PauseButton.Location = new System.Drawing.Point(258, 542);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(113, 45);
            this.PauseButton.TabIndex = 54;
            this.PauseButton.Text = "Пауза";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // CpuQueue2List
            // 
            this.CpuQueue2List.FormattingEnabled = true;
            this.CpuQueue2List.Location = new System.Drawing.Point(12, 241);
            this.CpuQueue2List.Name = "CpuQueue2List";
            this.CpuQueue2List.Size = new System.Drawing.Size(604, 43);
            this.CpuQueue2List.TabIndex = 56;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(12, 221);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(604, 19);
            this.textBox11.TabIndex = 55;
            this.textBox11.Text = "Очередь 2 к ЦП";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CpuQueue3List
            // 
            this.CpuQueue3List.FormattingEnabled = true;
            this.CpuQueue3List.Location = new System.Drawing.Point(12, 310);
            this.CpuQueue3List.Name = "CpuQueue3List";
            this.CpuQueue3List.Size = new System.Drawing.Size(604, 43);
            this.CpuQueue3List.TabIndex = 58;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(12, 290);
            this.textBox16.Multiline = true;
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(604, 19);
            this.textBox16.TabIndex = 57;
            this.textBox16.Text = "Очередь 3 к ЦП";
            this.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CpuQueue4List
            // 
            this.CpuQueue4List.FormattingEnabled = true;
            this.CpuQueue4List.Location = new System.Drawing.Point(12, 379);
            this.CpuQueue4List.Name = "CpuQueue4List";
            this.CpuQueue4List.Size = new System.Drawing.Size(604, 43);
            this.CpuQueue4List.TabIndex = 60;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(12, 359);
            this.textBox17.Multiline = true;
            this.textBox17.Name = "textBox17";
            this.textBox17.ReadOnly = true;
            this.textBox17.Size = new System.Drawing.Size(604, 19);
            this.textBox17.TabIndex = 59;
            this.textBox17.Text = "Очередь 4 к ЦП";
            this.textBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1239, 599);
            this.Controls.Add(this.CpuQueue4List);
            this.Controls.Add(this.textBox17);
            this.Controls.Add(this.CpuQueue3List);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.CpuQueue2List);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.Device2QueueList);
            this.Controls.Add(this.textBox20);
            this.Controls.Add(this.Device2Text);
            this.Controls.Add(this.textBox22);
            this.Controls.Add(this.resetIntervalButton);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.timerMorePlus);
            this.Controls.Add(this.timerPlus);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.timerMinus);
            this.Controls.Add(this.timerMoreMinus);
            this.Controls.Add(this.timerText);
            this.Controls.Add(this.timerInterval);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.SettingsPanel);
            this.Controls.Add(this.DeviceQueueList);
            this.Controls.Add(this.CpuQueueList);
            this.Controls.Add(this.openStatisticButton);
            this.Controls.Add(this.EndSeanseButton);
            this.Controls.Add(this.WorkCycleButton);
            this.Controls.Add(this.SaveSettingsButton);
            this.Controls.Add(this.TacktsText);
            this.Controls.Add(this.OccupiedRamText);
            this.Controls.Add(this.FreeRamText);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.DeviceText);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.CpuText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.ProcessIntensivityNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinWorkTimeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxWorkTimeNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinAddrSpaceNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxAddrSpaceNumeric)).EndInit();
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newWindowChecker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public System.Windows.Forms.ListBox CpuQueue2List;
        private System.Windows.Forms.TextBox textBox11;
        public System.Windows.Forms.ListBox CpuQueue3List;
        private System.Windows.Forms.TextBox textBox16;
        public System.Windows.Forms.ListBox CpuQueue4List;
        private System.Windows.Forms.TextBox textBox17;

        public System.Windows.Forms.Button PauseButton;

        public System.Windows.Forms.ListBox Device2QueueList;
        private System.Windows.Forms.TextBox textBox20;
        public System.Windows.Forms.TextBox Device2Text;
        private System.Windows.Forms.TextBox textBox22;

        public System.Timers.Timer newWindowChecker;

        private System.Windows.Forms.Button resetIntervalButton;

        private System.Windows.Forms.TextBox timerText;
        private System.Windows.Forms.Button timerMoreMinus;
        private System.Windows.Forms.Button timerMinus;
        private System.Windows.Forms.Button timerPlus;
        private System.Windows.Forms.Button timerMorePlus;

        public System.Windows.Forms.TextBox timerInterval;

        public System.Timers.Timer timer;

        #endregion

        public System.Windows.Forms.TextBox CpuText;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        public System.Windows.Forms.TextBox DeviceText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button WorkCycleButton;
        private System.Windows.Forms.Button EndSeanseButton;
        private System.Windows.Forms.Button openStatisticButton;
        public System.Windows.Forms.TextBox FreeRamText;
        public System.Windows.Forms.TextBox OccupiedRamText;
        public System.Windows.Forms.TextBox TacktsText;
        public System.Windows.Forms.ComboBox RamSize;
        public System.Windows.Forms.NumericUpDown ProcessIntensivityNumeric;
        public System.Windows.Forms.NumericUpDown MinWorkTimeNumeric;
        public System.Windows.Forms.NumericUpDown MaxWorkTimeNumeric;
        public System.Windows.Forms.NumericUpDown MinAddrSpaceNumeric;
        public System.Windows.Forms.NumericUpDown MaxAddrSpaceNumeric;
        public System.Windows.Forms.ListBox CpuQueueList;
        public System.Windows.Forms.ListBox DeviceQueueList;
        private System.Windows.Forms.Panel SettingsPanel;
        public System.Windows.Forms.Button SaveSettingsButton;
        private System.Windows.Forms.TextBox textBox15;
    }
}

