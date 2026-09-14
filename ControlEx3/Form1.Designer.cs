namespace ControlEx3
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
            components = new System.ComponentModel.Container();
            lblIndicator = new Label();
            prgIndicator = new ProgressBar();
            lblPercentage = new Label();
            lblSeparator = new Label();
            lblSpeed = new Label();
            trkSpeed = new TrackBar();
            tmrTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)trkSpeed).BeginInit();
            SuspendLayout();
            // 
            // lblIndicator
            // 
            lblIndicator.AutoSize = true;
            lblIndicator.Location = new Point(23, 24);
            lblIndicator.Name = "lblIndicator";
            lblIndicator.Size = new Size(131, 20);
            lblIndicator.TabIndex = 0;
            lblIndicator.Text = "Progress Indicator:";
            // 
            // prgIndicator
            // 
            prgIndicator.Location = new Point(23, 56);
            prgIndicator.Margin = new Padding(3, 4, 3, 4);
            prgIndicator.Name = "prgIndicator";
            prgIndicator.Size = new Size(337, 31);
            prgIndicator.TabIndex = 1;
            // 
            // lblPercentage
            // 
            lblPercentage.AutoSize = true;
            lblPercentage.Location = new Point(23, 104);
            lblPercentage.Name = "lblPercentage";
            lblPercentage.Size = new Size(178, 20);
            lblPercentage.TabIndex = 2;
            lblPercentage.Text = "Percentage Complete: 0%";
            // 
            // lblSeparator
            // 
            lblSeparator.BorderStyle = BorderStyle.Fixed3D;
            lblSeparator.Location = new Point(11, 141);
            lblSeparator.Name = "lblSeparator";
            lblSeparator.Size = new Size(360, 3);
            lblSeparator.TabIndex = 3;
            // 
            // lblSpeed
            // 
            lblSpeed.AutoSize = true;
            lblSpeed.Location = new Point(23, 168);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.Size = new Size(318, 20);
            lblSpeed.TabIndex = 4;
            lblSpeed.Text = "Slide the TrackBar to control processing speed:";
            // 
            // trkSpeed
            // 
            trkSpeed.Location = new Point(23, 207);
            trkSpeed.Margin = new Padding(3, 4, 3, 4);
            trkSpeed.Name = "trkSpeed";
            trkSpeed.Size = new Size(337, 56);
            trkSpeed.TabIndex = 5;
            trkSpeed.TickStyle = TickStyle.TopLeft;
            trkSpeed.Value = 1;
            trkSpeed.Scroll += trkSpeed_Scroll;
            // 
            // tmrTimer
            // 
            tmrTimer.Enabled = true;
            tmrTimer.Tick += tmrTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 287);
            Controls.Add(trkSpeed);
            Controls.Add(lblSpeed);
            Controls.Add(lblSeparator);
            Controls.Add(lblPercentage);
            Controls.Add(prgIndicator);
            Controls.Add(lblIndicator);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StepByStep2_15";
            ((System.ComponentModel.ISupportInitialize)trkSpeed).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIndicator;
        private ProgressBar prgIndicator;
        private Label lblPercentage;
        private Label lblSeparator;
        private Label lblSpeed;
        private TrackBar trkSpeed;
        private System.Windows.Forms.Timer tmrTimer;
    }
}
