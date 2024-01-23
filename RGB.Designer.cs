namespace WinFormsApp2
{
    partial class RGB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            redLB = new Label();
            greenLB = new Label();
            blueLB = new Label();
            trackBar1 = new TrackBar();
            trackBar2 = new TrackBar();
            trackBar3 = new TrackBar();
            redCB = new CheckBox();
            greenCB = new CheckBox();
            blueCB = new CheckBox();
            redValLB = new Label();
            greenValLB = new Label();
            blValLB = new Label();
            saveBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            SuspendLayout();
            // 
            // redLB
            // 
            redLB.AutoSize = true;
            redLB.Location = new Point(40, 262);
            redLB.Name = "redLB";
            redLB.Size = new Size(28, 15);
            redLB.TabIndex = 0;
            redLB.Text = "RED";
            // 
            // greenLB
            // 
            greenLB.AutoSize = true;
            greenLB.Location = new Point(40, 341);
            greenLB.Name = "greenLB";
            greenLB.Size = new Size(43, 15);
            greenLB.TabIndex = 1;
            greenLB.Text = "GREEN";
            greenLB.Click += label2_Click;
            // 
            // blueLB
            // 
            blueLB.AutoSize = true;
            blueLB.Location = new Point(40, 416);
            blueLB.Name = "blueLB";
            blueLB.Size = new Size(34, 15);
            blueLB.TabIndex = 2;
            blueLB.Text = "BLUE";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(91, 262);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(270, 45);
            trackBar1.TabIndex = 3;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(91, 341);
            trackBar2.Maximum = 100;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(270, 45);
            trackBar2.TabIndex = 4;
            trackBar2.Scroll += trackBar2_Scroll;
            // 
            // trackBar3
            // 
            trackBar3.Location = new Point(91, 416);
            trackBar3.Maximum = 100;
            trackBar3.Name = "trackBar3";
            trackBar3.Size = new Size(270, 45);
            trackBar3.TabIndex = 5;
            trackBar3.Scroll += trackBar3_Scroll;
            // 
            // redCB
            // 
            redCB.AutoSize = true;
            redCB.Location = new Point(367, 262);
            redCB.Name = "redCB";
            redCB.Size = new Size(43, 19);
            redCB.TabIndex = 6;
            redCB.Text = "red";
            redCB.UseVisualStyleBackColor = true;
            redCB.CheckedChanged += redCB_CheckedChanged;
            // 
            // greenCB
            // 
            greenCB.AutoSize = true;
            greenCB.Location = new Point(367, 341);
            greenCB.Name = "greenCB";
            greenCB.Size = new Size(56, 19);
            greenCB.TabIndex = 7;
            greenCB.Text = "green";
            greenCB.UseVisualStyleBackColor = true;
            greenCB.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // blueCB
            // 
            blueCB.AutoSize = true;
            blueCB.Location = new Point(367, 416);
            blueCB.Name = "blueCB";
            blueCB.Size = new Size(49, 19);
            blueCB.TabIndex = 8;
            blueCB.Text = "blue";
            blueCB.UseVisualStyleBackColor = true;
            blueCB.CheckedChanged += blueCB_CheckedChanged;
            // 
            // redValLB
            // 
            redValLB.AutoSize = true;
            redValLB.Location = new Point(422, 262);
            redValLB.Name = "redValLB";
            redValLB.Size = new Size(16, 15);
            redValLB.TabIndex = 9;
            redValLB.Text = "l1";
            redValLB.Click += redValLB_Click;
            // 
            // greenValLB
            // 
            greenValLB.AutoSize = true;
            greenValLB.Location = new Point(422, 341);
            greenValLB.Name = "greenValLB";
            greenValLB.Size = new Size(16, 15);
            greenValLB.TabIndex = 10;
            greenValLB.Text = "l2";
            greenValLB.Click += greenValLB_Click;
            // 
            // blValLB
            // 
            blValLB.AutoSize = true;
            blValLB.Location = new Point(422, 416);
            blValLB.Name = "blValLB";
            blValLB.Size = new Size(16, 15);
            blValLB.TabIndex = 11;
            blValLB.Text = "l3";
            blValLB.Click += blValLB_Click;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(197, 467);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(75, 23);
            saveBtn.TabIndex = 12;
            saveBtn.Text = "SAVE";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // RGB
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 504);
            Controls.Add(saveBtn);
            Controls.Add(blValLB);
            Controls.Add(greenValLB);
            Controls.Add(redValLB);
            Controls.Add(blueCB);
            Controls.Add(greenCB);
            Controls.Add(redCB);
            Controls.Add(trackBar3);
            Controls.Add(trackBar2);
            Controls.Add(trackBar1);
            Controls.Add(blueLB);
            Controls.Add(greenLB);
            Controls.Add(redLB);
            Name = "RGB";
            Text = "RGB";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label redLB;
        private Label greenLB;
        private Label blueLB;
        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private TrackBar trackBar3;
        private CheckBox redCB;
        private CheckBox greenCB;
        private CheckBox blueCB;
        private Label redValLB;
        private Label greenValLB;
        private Label blValLB;
        private Button saveBtn;
    }
}