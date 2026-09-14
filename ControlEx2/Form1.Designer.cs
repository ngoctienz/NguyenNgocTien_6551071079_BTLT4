namespace ControlEx2
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
            lblPrompt = new Label();
            mcTravelDates = new MonthCalendar();
            lblTravelDates = new Label();
            lblProductLaunch = new Label();
            dtpLaunchDate = new DateTimePicker();
            rbLongDate = new RadioButton();
            rbShortDate = new RadioButton();
            SuspendLayout();
            // 
            // lblPrompt
            // 
            lblPrompt.AutoSize = true;
            lblPrompt.Location = new Point(16, 12);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(165, 15);
            lblPrompt.TabIndex = 0;
            lblPrompt.Text = "Select the days you will travel:";
            // 
            // mcTravelDates
            // 
            mcTravelDates.Location = new Point(16, 35);
            mcTravelDates.MaxSelectionCount = 30;
            mcTravelDates.Name = "mcTravelDates";
            mcTravelDates.TabIndex = 1;
            mcTravelDates.DateChanged += mcTravelDates_DateChanged;
            mcTravelDates.DateSelected += mcTravelDates_DateSelected;
            // 
            // lblTravelDates
            // 
            lblTravelDates.AutoSize = true;
            lblTravelDates.Location = new Point(255, 38);
            lblTravelDates.Name = "lblTravelDates";
            lblTravelDates.Size = new Size(58, 15);
            lblTravelDates.TabIndex = 2;
            lblTravelDates.Text = "StartDate:";
            // 
            // lblProductLaunch
            // 
            lblProductLaunch.AutoSize = true;
            lblProductLaunch.Location = new Point(16, 210);
            lblProductLaunch.Name = "lblProductLaunch";
            lblProductLaunch.Size = new Size(122, 15);
            lblProductLaunch.TabIndex = 3;
            lblProductLaunch.Text = "Product Launch Date:";
            // 
            // dtpLaunchDate
            // 
            dtpLaunchDate.Format = DateTimePickerFormat.Long;
            dtpLaunchDate.Location = new Point(16, 232);
            dtpLaunchDate.Name = "dtpLaunchDate";
            dtpLaunchDate.Size = new Size(227, 23);
            dtpLaunchDate.TabIndex = 4;
            // 
            // rbLongDate
            // 
            rbLongDate.AutoSize = true;
            rbLongDate.Checked = true;
            rbLongDate.Location = new Point(16, 265);
            rbLongDate.Name = "rbLongDate";
            rbLongDate.Size = new Size(79, 19);
            rbLongDate.TabIndex = 5;
            rbLongDate.TabStop = true;
            rbLongDate.Text = "Long Date";
            rbLongDate.UseVisualStyleBackColor = true;
            rbLongDate.CheckedChanged += rbLongDate_CheckedChanged;
            // 
            // rbShortDate
            // 
            rbShortDate.AutoSize = true;
            rbShortDate.Location = new Point(115, 265);
            rbShortDate.Name = "rbShortDate";
            rbShortDate.Size = new Size(80, 19);
            rbShortDate.TabIndex = 6;
            rbShortDate.Text = "Short Date";
            rbShortDate.UseVisualStyleBackColor = true;
            rbShortDate.CheckedChanged += rbShortDate_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 305);
            Controls.Add(rbShortDate);
            Controls.Add(rbLongDate);
            Controls.Add(dtpLaunchDate);
            Controls.Add(lblProductLaunch);
            Controls.Add(lblTravelDates);
            Controls.Add(mcTravelDates);
            Controls.Add(lblPrompt);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StepByStep2_13";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrompt;
        private MonthCalendar mcTravelDates;
        private Label lblTravelDates;
        private Label lblProductLaunch;
        private DateTimePicker dtpLaunchDate;
        private RadioButton rbLongDate;
        private RadioButton rbShortDate;
    }
}
