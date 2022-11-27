using System.ComponentModel;

namespace OST_Labs
{
    partial class Statistics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.allWorkTime = new System.Windows.Forms.TextBox();
            this.Intensivity = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.MinCpuWorkTime = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.MaxCpuWorkTime = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.AllProcessCount = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.rejectedProcessCount = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.RestCpuTime = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.LoadedCpu = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.SystemPerformance = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.EndedProcessCount = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.maxQueueLength = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.avgQueueLength = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(175, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Общее время работы системы";
            // 
            // allWorkTime
            // 
            this.allWorkTime.Location = new System.Drawing.Point(193, 98);
            this.allWorkTime.Name = "allWorkTime";
            this.allWorkTime.ReadOnly = true;
            this.allWorkTime.Size = new System.Drawing.Size(77, 20);
            this.allWorkTime.TabIndex = 6;
            // 
            // Intensivity
            // 
            this.Intensivity.Location = new System.Drawing.Point(12, 54);
            this.Intensivity.Name = "Intensivity";
            this.Intensivity.ReadOnly = true;
            this.Intensivity.Size = new System.Drawing.Size(165, 20);
            this.Intensivity.TabIndex = 13;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(12, 12);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(165, 36);
            this.textBox8.TabIndex = 12;
            this.textBox8.Text = "Интенсивность поступления процессов";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MinCpuWorkTime
            // 
            this.MinCpuWorkTime.Location = new System.Drawing.Point(193, 54);
            this.MinCpuWorkTime.Name = "MinCpuWorkTime";
            this.MinCpuWorkTime.ReadOnly = true;
            this.MinCpuWorkTime.Size = new System.Drawing.Size(165, 20);
            this.MinCpuWorkTime.TabIndex = 15;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(193, 12);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(165, 36);
            this.textBox9.TabIndex = 14;
            this.textBox9.Text = "Минимальное время работы на ЦП";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MaxCpuWorkTime
            // 
            this.MaxCpuWorkTime.Location = new System.Drawing.Point(369, 54);
            this.MaxCpuWorkTime.Name = "MaxCpuWorkTime";
            this.MaxCpuWorkTime.ReadOnly = true;
            this.MaxCpuWorkTime.Size = new System.Drawing.Size(165, 20);
            this.MaxCpuWorkTime.TabIndex = 17;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(369, 12);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(165, 36);
            this.textBox11.TabIndex = 16;
            this.textBox11.Text = "Максимальное время работы на ЦП";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AllProcessCount
            // 
            this.AllProcessCount.Location = new System.Drawing.Point(193, 124);
            this.AllProcessCount.Name = "AllProcessCount";
            this.AllProcessCount.ReadOnly = true;
            this.AllProcessCount.Size = new System.Drawing.Size(77, 20);
            this.AllProcessCount.TabIndex = 19;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(12, 124);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(175, 20);
            this.textBox13.TabIndex = 18;
            this.textBox13.Text = "Число поступивших процессов";
            // 
            // rejectedProcessCount
            // 
            this.rejectedProcessCount.Location = new System.Drawing.Point(193, 150);
            this.rejectedProcessCount.Name = "rejectedProcessCount";
            this.rejectedProcessCount.ReadOnly = true;
            this.rejectedProcessCount.Size = new System.Drawing.Size(77, 20);
            this.rejectedProcessCount.TabIndex = 21;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(12, 150);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(175, 20);
            this.textBox14.TabIndex = 20;
            this.textBox14.Text = "Число отвергнутых процессов";
            // 
            // RestCpuTime
            // 
            this.RestCpuTime.Location = new System.Drawing.Point(457, 98);
            this.RestCpuTime.Name = "RestCpuTime";
            this.RestCpuTime.ReadOnly = true;
            this.RestCpuTime.Size = new System.Drawing.Size(77, 20);
            this.RestCpuTime.TabIndex = 23;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(276, 98);
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(175, 20);
            this.textBox16.TabIndex = 22;
            this.textBox16.Text = "Время простоя ЦП";
            // 
            // LoadedCpu
            // 
            this.LoadedCpu.Location = new System.Drawing.Point(457, 124);
            this.LoadedCpu.Name = "LoadedCpu";
            this.LoadedCpu.ReadOnly = true;
            this.LoadedCpu.Size = new System.Drawing.Size(77, 20);
            this.LoadedCpu.TabIndex = 25;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(276, 124);
            this.textBox17.Name = "textBox17";
            this.textBox17.ReadOnly = true;
            this.textBox17.Size = new System.Drawing.Size(175, 20);
            this.textBox17.TabIndex = 24;
            this.textBox17.Text = "Загруженность ЦП";
            // 
            // SystemPerformance
            // 
            this.SystemPerformance.Location = new System.Drawing.Point(457, 150);
            this.SystemPerformance.Name = "SystemPerformance";
            this.SystemPerformance.ReadOnly = true;
            this.SystemPerformance.Size = new System.Drawing.Size(77, 20);
            this.SystemPerformance.TabIndex = 27;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(276, 150);
            this.textBox18.Name = "textBox18";
            this.textBox18.ReadOnly = true;
            this.textBox18.Size = new System.Drawing.Size(175, 20);
            this.textBox18.TabIndex = 26;
            this.textBox18.Text = "Производительность системы";
            // 
            // EndedProcessCount
            // 
            this.EndedProcessCount.Location = new System.Drawing.Point(457, 176);
            this.EndedProcessCount.Multiline = true;
            this.EndedProcessCount.Name = "EndedProcessCount";
            this.EndedProcessCount.ReadOnly = true;
            this.EndedProcessCount.Size = new System.Drawing.Size(77, 36);
            this.EndedProcessCount.TabIndex = 29;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(276, 176);
            this.textBox19.Multiline = true;
            this.textBox19.Name = "textBox19";
            this.textBox19.ReadOnly = true;
            this.textBox19.Size = new System.Drawing.Size(175, 36);
            this.textBox19.TabIndex = 28;
            this.textBox19.Text = "Число завершенных процессов";
            this.textBox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maxQueueLength
            // 
            this.maxQueueLength.Location = new System.Drawing.Point(193, 176);
            this.maxQueueLength.Multiline = true;
            this.maxQueueLength.Name = "maxQueueLength";
            this.maxQueueLength.ReadOnly = true;
            this.maxQueueLength.Size = new System.Drawing.Size(77, 36);
            this.maxQueueLength.TabIndex = 31;
            this.maxQueueLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(12, 176);
            this.textBox21.Multiline = true;
            this.textBox21.Name = "textBox21";
            this.textBox21.ReadOnly = true;
            this.textBox21.Size = new System.Drawing.Size(175, 36);
            this.textBox21.TabIndex = 30;
            this.textBox21.Text = "Максимальная длина очереди готовых провессов";
            this.textBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // avgQueueLength
            // 
            this.avgQueueLength.Location = new System.Drawing.Point(193, 218);
            this.avgQueueLength.Multiline = true;
            this.avgQueueLength.Name = "avgQueueLength";
            this.avgQueueLength.ReadOnly = true;
            this.avgQueueLength.Size = new System.Drawing.Size(77, 36);
            this.avgQueueLength.TabIndex = 33;
            this.avgQueueLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(12, 218);
            this.textBox23.Multiline = true;
            this.textBox23.Name = "textBox23";
            this.textBox23.ReadOnly = true;
            this.textBox23.Size = new System.Drawing.Size(175, 36);
            this.textBox23.TabIndex = 32;
            this.textBox23.Text = "Средняя длина очереди готовых провессов";
            this.textBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 258);
            this.Controls.Add(this.avgQueueLength);
            this.Controls.Add(this.textBox23);
            this.Controls.Add(this.maxQueueLength);
            this.Controls.Add(this.textBox21);
            this.Controls.Add(this.EndedProcessCount);
            this.Controls.Add(this.textBox19);
            this.Controls.Add(this.SystemPerformance);
            this.Controls.Add(this.textBox18);
            this.Controls.Add(this.LoadedCpu);
            this.Controls.Add(this.textBox17);
            this.Controls.Add(this.RestCpuTime);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.rejectedProcessCount);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.AllProcessCount);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.MaxCpuWorkTime);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.MinCpuWorkTime);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.Intensivity);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.allWorkTime);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Statistics";
            this.Text = "Сводка";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public System.Windows.Forms.TextBox avgQueueLength;
        private System.Windows.Forms.TextBox textBox23;

        public System.Windows.Forms.TextBox maxQueueLength;
        private System.Windows.Forms.TextBox textBox21;

        public System.Windows.Forms.TextBox EndedProcessCount;
        private System.Windows.Forms.TextBox textBox19;

        public System.Windows.Forms.TextBox SystemPerformance;
        private System.Windows.Forms.TextBox textBox18;

        public System.Windows.Forms.TextBox LoadedCpu;
        private System.Windows.Forms.TextBox textBox17;

        public System.Windows.Forms.TextBox RestCpuTime;
        private System.Windows.Forms.TextBox textBox16;

        public System.Windows.Forms.TextBox rejectedProcessCount;
        private System.Windows.Forms.TextBox textBox14;

        public System.Windows.Forms.TextBox AllProcessCount;
        private System.Windows.Forms.TextBox textBox13;

        public System.Windows.Forms.TextBox MaxCpuWorkTime;
        private System.Windows.Forms.TextBox textBox11;

        public System.Windows.Forms.TextBox MinCpuWorkTime;
        private System.Windows.Forms.TextBox textBox9;

        private System.Windows.Forms.TextBox textBox8;

        public System.Windows.Forms.TextBox allWorkTime;

        public System.Windows.Forms.TextBox Intensivity;

        private System.Windows.Forms.TextBox textBox1;

        #endregion
    }
}