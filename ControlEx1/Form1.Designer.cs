namespace ControlEx1
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
            inputColor = new DomainUpDown();
            inputSize = new NumericUpDown();
            lblColor = new Label();
            lblSize = new Label();
            exText = new Label();
            ((System.ComponentModel.ISupportInitialize)inputSize).BeginInit();
            SuspendLayout();
            // 
            // inputColor
            // 
            inputColor.Location = new Point(203, 45);
            inputColor.Name = "inputColor";
            inputColor.Size = new Size(200, 27);
            inputColor.TabIndex = 0;
            inputColor.Text = "Red";
            inputColor.SelectedItemChanged += inputColor_SelectedItemChanged;
            // 
            // inputSize
            // 
            inputSize.Location = new Point(203, 135);
            inputSize.Name = "inputSize";
            inputSize.Size = new Size(200, 27);
            inputSize.TabIndex = 1;
            inputSize.ValueChanged += inputSize_ValueChanged;
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblColor.Location = new Point(100, 52);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(46, 20);
            lblColor.TabIndex = 2;
            lblColor.Text = "Color";
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSize.Location = new Point(100, 142);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(36, 20);
            lblSize.TabIndex = 3;
            lblSize.Text = "Size";
            // 
            // exText
            // 
            exText.Dock = DockStyle.Bottom;
            exText.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            exText.Location = new Point(0, 221);
            exText.Name = "exText";
            exText.Size = new Size(505, 99);
            exText.TabIndex = 4;
            exText.Text = "Sample Text";
            exText.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 320);
            Controls.Add(exText);
            Controls.Add(lblSize);
            Controls.Add(lblColor);
            Controls.Add(inputSize);
            Controls.Add(inputColor);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)inputSize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DomainUpDown inputColor;
        private NumericUpDown inputSize;
        private Label lblColor;
        private Label lblSize;
        private Label exText;
    }
}
