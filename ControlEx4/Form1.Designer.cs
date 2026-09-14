namespace ControlEx4
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
            lblSelectPrompt = new Label();
            tabControl = new TabControl();
            tabMessage = new TabPage();
            txtCaption = new TextBox();
            lblCaption = new Label();
            txtMessage = new TextBox();
            lblMessage = new Label();
            tabButtons = new TabPage();
            radYesNoCancel = new RadioButton();
            radYesNo = new RadioButton();
            radRetryCancel = new RadioButton();
            radOKCancel = new RadioButton();
            radOK = new RadioButton();
            tabIcon = new TabPage();
            radWarning = new RadioButton();
            radQuestion = new RadioButton();
            radNone = new RadioButton();
            radInformation = new RadioButton();
            radError = new RadioButton();
            btnShow = new Button();
            grpTabLayout = new GroupBox();
            radBottom = new RadioButton();
            radRight = new RadioButton();
            radTop = new RadioButton();
            radLeft = new RadioButton();
            tabControl.SuspendLayout();
            tabMessage.SuspendLayout();
            tabButtons.SuspendLayout();
            tabIcon.SuspendLayout();
            grpTabLayout.SuspendLayout();
            SuspendLayout();
            // 
            // lblSelectPrompt
            // 
            lblSelectPrompt.AutoSize = true;
            lblSelectPrompt.Location = new Point(16, 15);
            lblSelectPrompt.Name = "lblSelectPrompt";
            lblSelectPrompt.Size = new Size(272, 20);
            lblSelectPrompt.TabIndex = 0;
            lblSelectPrompt.Text = "Select options to create a message box:";
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabMessage);
            tabControl.Controls.Add(tabButtons);
            tabControl.Controls.Add(tabIcon);
            tabControl.Location = new Point(16, 45);
            tabControl.Multiline = true;
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(346, 215);
            tabControl.TabIndex = 1;
            // 
            // tabMessage
            // 
            tabMessage.Controls.Add(txtCaption);
            tabMessage.Controls.Add(lblCaption);
            tabMessage.Controls.Add(txtMessage);
            tabMessage.Controls.Add(lblMessage);
            tabMessage.Location = new Point(4, 29);
            tabMessage.Name = "tabMessage";
            tabMessage.Padding = new Padding(3);
            tabMessage.Size = new Size(338, 182);
            tabMessage.TabIndex = 0;
            tabMessage.Text = "Message";
            tabMessage.UseVisualStyleBackColor = true;
            // 
            // txtCaption
            // 
            txtCaption.Location = new Point(15, 130);
            txtCaption.Name = "txtCaption";
            txtCaption.Size = new Size(308, 27);
            txtCaption.TabIndex = 3;
            txtCaption.Text = "TabControl Demo";
            // 
            // lblCaption
            // 
            lblCaption.AutoSize = true;
            lblCaption.Location = new Point(15, 105);
            lblCaption.Name = "lblCaption";
            lblCaption.Size = new Size(224, 20);
            lblCaption.TabIndex = 2;
            lblCaption.Text = "Enter a Caption for MessageBox:";
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(15, 35);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(308, 60);
            txtMessage.TabIndex = 1;
            txtMessage.Text = "Sample Message";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(15, 12);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(202, 20);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "Enter the message to display:";
            // 
            // tabButtons
            // 
            tabButtons.Controls.Add(radYesNoCancel);
            tabButtons.Controls.Add(radYesNo);
            tabButtons.Controls.Add(radRetryCancel);
            tabButtons.Controls.Add(radOKCancel);
            tabButtons.Controls.Add(radOK);
            tabButtons.Location = new Point(4, 29);
            tabButtons.Name = "tabButtons";
            tabButtons.Padding = new Padding(3);
            tabButtons.Size = new Size(338, 182);
            tabButtons.TabIndex = 1;
            tabButtons.Text = "Buttons";
            tabButtons.UseVisualStyleBackColor = true;
            // 
            // radYesNoCancel
            // 
            radYesNoCancel.AutoSize = true;
            radYesNoCancel.Location = new Point(20, 135);
            radYesNoCancel.Name = "radYesNoCancel";
            radYesNoCancel.Size = new Size(155, 24);
            radYesNoCancel.TabIndex = 4;
            radYesNoCancel.TabStop = true;
            radYesNoCancel.Text = "Yes, No and Cancel";
            radYesNoCancel.UseVisualStyleBackColor = true;
            // 
            // radYesNo
            // 
            radYesNo.AutoSize = true;
            radYesNo.Location = new Point(20, 105);
            radYesNo.Name = "radYesNo";
            radYesNo.Size = new Size(104, 24);
            radYesNo.TabIndex = 3;
            radYesNo.TabStop = true;
            radYesNo.Text = "Yes and No";
            radYesNo.UseVisualStyleBackColor = true;
            // 
            // radRetryCancel
            // 
            radRetryCancel.AutoSize = true;
            radRetryCancel.Location = new Point(20, 75);
            radRetryCancel.Name = "radRetryCancel";
            radRetryCancel.Size = new Size(141, 24);
            radRetryCancel.TabIndex = 2;
            radRetryCancel.TabStop = true;
            radRetryCancel.Text = "Retry and Cancel";
            radRetryCancel.UseVisualStyleBackColor = true;
            // 
            // radOKCancel
            // 
            radOKCancel.AutoSize = true;
            radOKCancel.Location = new Point(20, 45);
            radOKCancel.Name = "radOKCancel";
            radOKCancel.Size = new Size(127, 24);
            radOKCancel.TabIndex = 1;
            radOKCancel.TabStop = true;
            radOKCancel.Text = "OK and Cancel";
            radOKCancel.UseVisualStyleBackColor = true;
            // 
            // radOK
            // 
            radOK.AutoSize = true;
            radOK.Checked = true;
            radOK.Location = new Point(20, 15);
            radOK.Name = "radOK";
            radOK.Size = new Size(50, 24);
            radOK.TabIndex = 0;
            radOK.TabStop = true;
            radOK.Text = "OK";
            radOK.UseVisualStyleBackColor = true;
            // 
            // tabIcon
            // 
            tabIcon.Controls.Add(radWarning);
            tabIcon.Controls.Add(radQuestion);
            tabIcon.Controls.Add(radNone);
            tabIcon.Controls.Add(radInformation);
            tabIcon.Controls.Add(radError);
            tabIcon.Location = new Point(4, 29);
            tabIcon.Name = "tabIcon";
            tabIcon.Padding = new Padding(3);
            tabIcon.Size = new Size(338, 182);
            tabIcon.TabIndex = 2;
            tabIcon.Text = "Icon";
            tabIcon.UseVisualStyleBackColor = true;
            // 
            // radWarning
            // 
            radWarning.AutoSize = true;
            radWarning.Location = new Point(20, 135);
            radWarning.Name = "radWarning";
            radWarning.Size = new Size(85, 24);
            radWarning.TabIndex = 4;
            radWarning.TabStop = true;
            radWarning.Text = "Warning";
            radWarning.UseVisualStyleBackColor = true;
            // 
            // radQuestion
            // 
            radQuestion.AutoSize = true;
            radQuestion.Location = new Point(20, 105);
            radQuestion.Name = "radQuestion";
            radQuestion.Size = new Size(89, 24);
            radQuestion.TabIndex = 3;
            radQuestion.TabStop = true;
            radQuestion.Text = "Question";
            radQuestion.UseVisualStyleBackColor = true;
            // 
            // radNone
            // 
            radNone.AutoSize = true;
            radNone.Location = new Point(20, 75);
            radNone.Name = "radNone";
            radNone.Size = new Size(66, 24);
            radNone.TabIndex = 2;
            radNone.TabStop = true;
            radNone.Text = "None";
            radNone.UseVisualStyleBackColor = true;
            // 
            // radInformation
            // 
            radInformation.AutoSize = true;
            radInformation.Checked = true;
            radInformation.Location = new Point(20, 45);
            radInformation.Name = "radInformation";
            radInformation.Size = new Size(108, 24);
            radInformation.TabIndex = 1;
            radInformation.TabStop = true;
            radInformation.Text = "Information";
            radInformation.UseVisualStyleBackColor = true;
            // 
            // radError
            // 
            radError.AutoSize = true;
            radError.Location = new Point(20, 15);
            radError.Name = "radError";
            radError.Size = new Size(62, 24);
            radError.TabIndex = 0;
            radError.TabStop = true;
            radError.Text = "Error";
            radError.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(145, 268);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(90, 32);
            btnShow.TabIndex = 2;
            btnShow.Text = "Show!";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // grpTabLayout
            // 
            grpTabLayout.Controls.Add(radBottom);
            grpTabLayout.Controls.Add(radRight);
            grpTabLayout.Controls.Add(radTop);
            grpTabLayout.Controls.Add(radLeft);
            grpTabLayout.Location = new Point(16, 310);
            grpTabLayout.Name = "grpTabLayout";
            grpTabLayout.Size = new Size(346, 95);
            grpTabLayout.TabIndex = 3;
            grpTabLayout.TabStop = false;
            grpTabLayout.Text = "Tab Layout";
            // 
            // radBottom
            // 
            radBottom.AutoSize = true;
            radBottom.Location = new Point(180, 58);
            radBottom.Name = "radBottom";
            radBottom.Size = new Size(80, 24);
            radBottom.TabIndex = 3;
            radBottom.TabStop = true;
            radBottom.Text = "Bottom";
            radBottom.UseVisualStyleBackColor = true;
            radBottom.CheckedChanged += radBottom_CheckedChanged;
            // 
            // radRight
            // 
            radRight.AutoSize = true;
            radRight.Location = new Point(180, 25);
            radRight.Name = "radRight";
            radRight.Size = new Size(65, 24);
            radRight.TabIndex = 2;
            radRight.TabStop = true;
            radRight.Text = "Right";
            radRight.UseVisualStyleBackColor = true;
            radRight.CheckedChanged += radRight_CheckedChanged;
            // 
            // radTop
            // 
            radTop.AutoSize = true;
            radTop.Checked = true;
            radTop.Location = new Point(25, 58);
            radTop.Name = "radTop";
            radTop.Size = new Size(55, 24);
            radTop.TabIndex = 1;
            radTop.TabStop = true;
            radTop.Text = "Top";
            radTop.UseVisualStyleBackColor = true;
            radTop.CheckedChanged += radTop_CheckedChanged;
            // 
            // radLeft
            // 
            radLeft.AutoSize = true;
            radLeft.Location = new Point(25, 25);
            radLeft.Name = "radLeft";
            radLeft.Size = new Size(55, 24);
            radLeft.TabIndex = 0;
            radLeft.TabStop = true;
            radLeft.Text = "Left";
            radLeft.UseVisualStyleBackColor = true;
            radLeft.CheckedChanged += radLeft_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 420);
            Controls.Add(grpTabLayout);
            Controls.Add(btnShow);
            Controls.Add(tabControl);
            Controls.Add(lblSelectPrompt);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StepByStep2_17";
            tabControl.ResumeLayout(false);
            tabMessage.ResumeLayout(false);
            tabMessage.PerformLayout();
            tabButtons.ResumeLayout(false);
            tabButtons.PerformLayout();
            tabIcon.ResumeLayout(false);
            tabIcon.PerformLayout();
            grpTabLayout.ResumeLayout(false);
            grpTabLayout.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSelectPrompt;
        private TabControl tabControl;
        private TabPage tabMessage;
        private TabPage tabButtons;
        private TabPage tabIcon;
        private TextBox txtCaption;
        private Label lblCaption;
        private TextBox txtMessage;
        private Label lblMessage;
        private RadioButton radYesNoCancel;
        private RadioButton radYesNo;
        private RadioButton radRetryCancel;
        private RadioButton radOKCancel;
        private RadioButton radOK;
        private RadioButton radWarning;
        private RadioButton radQuestion;
        private RadioButton radNone;
        private RadioButton radInformation;
        private RadioButton radError;
        private Button btnShow;
        private GroupBox grpTabLayout;
        private RadioButton radBottom;
        private RadioButton radRight;
        private RadioButton radTop;
        private RadioButton radLeft;
    }
}
