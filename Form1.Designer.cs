namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            trackBar1 = new TrackBar();
            label1 = new Label();
            progressBar1 = new ProgressBar();
            monthCalendar1 = new MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Location = new Point(19, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(141, 74);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Location = new Point(337, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(261, 95);
            panel2.TabIndex = 1;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(12, 345);
            trackBar1.Maximum = 110;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(323, 45);
            trackBar1.TabIndex = 2;
            
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(346, 355);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(19, 245);
            progressBar1.Maximum = 110;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(365, 23);
            progressBar1.TabIndex = 4;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(577, 222);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 5;
         //   monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 402);
            Controls.Add(monthCalendar1);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            Controls.Add(trackBar1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            ShowIcon = false;
            Text = "Hello Ed";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TrackBar trackBar1;
        private Label label1;
        private ProgressBar progressBar1;
        private MonthCalendar monthCalendar1;
    }
}