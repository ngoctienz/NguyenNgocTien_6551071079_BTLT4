namespace _2ListBox
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
            lblTenSV = new Label();
            txtTen = new TextBox();
            btnCapNhat = new Button();
            lstLopA = new ListBox();
            lstLopB = new ListBox();
            btnChuyenChonQuaPhai = new Button();
            btnChuyenHetQuaPhai = new Button();
            btnChuyenChonQuaTrai = new Button();
            btnChuyenHetQuaTrai = new Button();
            btnXoaLopA = new Button();
            btnKetThuc = new Button();
            btnXoaLopB = new Button();
            menuStrip1 = new MenuStrip();
            cậpNhậtToolStripMenuItem = new ToolStripMenuItem();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTenSV
            // 
            lblTenSV.AutoSize = true;
            lblTenSV.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTenSV.Location = new Point(38, 51);
            lblTenSV.Name = "lblTenSV";
            lblTenSV.Size = new Size(60, 20);
            lblTenSV.TabIndex = 0;
            lblTenSV.Text = "Tên SV:";
            // 
            // txtTen
            // 
            txtTen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtTen.Location = new Point(123, 48);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(245, 27);
            txtTen.TabIndex = 1;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCapNhat.Location = new Point(395, 46);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(110, 31);
            btnCapNhat.TabIndex = 2;
            btnCapNhat.Text = "Cập Nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // lstLopA
            // 
            lstLopA.FormattingEnabled = true;
            lstLopA.Location = new Point(28, 94);
            lstLopA.Name = "lstLopA";
            lstLopA.SelectionMode = SelectionMode.MultiExtended;
            lstLopA.Size = new Size(160, 204);
            lstLopA.TabIndex = 3;
            // 
            // lstLopB
            // 
            lstLopB.FormattingEnabled = true;
            lstLopB.Location = new Point(320, 94);
            lstLopB.Name = "lstLopB";
            lstLopB.SelectionMode = SelectionMode.MultiExtended;
            lstLopB.Size = new Size(195, 204);
            lstLopB.TabIndex = 8;
            // 
            // btnChuyenChonQuaPhai
            // 
            btnChuyenChonQuaPhai.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnChuyenChonQuaPhai.Location = new Point(233, 101);
            btnChuyenChonQuaPhai.Name = "btnChuyenChonQuaPhai";
            btnChuyenChonQuaPhai.Size = new Size(50, 32);
            btnChuyenChonQuaPhai.TabIndex = 4;
            btnChuyenChonQuaPhai.Text = ">";
            btnChuyenChonQuaPhai.UseVisualStyleBackColor = true;
            btnChuyenChonQuaPhai.Click += btnChuyenChonQuaPhai_Click;
            // 
            // btnChuyenHetQuaPhai
            // 
            btnChuyenHetQuaPhai.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnChuyenHetQuaPhai.Location = new Point(233, 146);
            btnChuyenHetQuaPhai.Name = "btnChuyenHetQuaPhai";
            btnChuyenHetQuaPhai.Size = new Size(50, 32);
            btnChuyenHetQuaPhai.TabIndex = 5;
            btnChuyenHetQuaPhai.Text = ">>";
            btnChuyenHetQuaPhai.UseVisualStyleBackColor = true;
            btnChuyenHetQuaPhai.Click += btnChuyenHetQuaPhai_Click;
            // 
            // btnChuyenChonQuaTrai
            // 
            btnChuyenChonQuaTrai.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnChuyenChonQuaTrai.Location = new Point(233, 206);
            btnChuyenChonQuaTrai.Name = "btnChuyenChonQuaTrai";
            btnChuyenChonQuaTrai.Size = new Size(50, 32);
            btnChuyenChonQuaTrai.TabIndex = 6;
            btnChuyenChonQuaTrai.Text = "<";
            btnChuyenChonQuaTrai.UseVisualStyleBackColor = true;
            btnChuyenChonQuaTrai.Click += btnChuyenChonQuaTrai_Click;
            // 
            // btnChuyenHetQuaTrai
            // 
            btnChuyenHetQuaTrai.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnChuyenHetQuaTrai.Location = new Point(233, 251);
            btnChuyenHetQuaTrai.Name = "btnChuyenHetQuaTrai";
            btnChuyenHetQuaTrai.Size = new Size(50, 32);
            btnChuyenHetQuaTrai.TabIndex = 7;
            btnChuyenHetQuaTrai.Text = "<<";
            btnChuyenHetQuaTrai.UseVisualStyleBackColor = true;
            btnChuyenHetQuaTrai.Click += btnChuyenHetQuaTrai_Click;
            // 
            // btnXoaLopA
            // 
            btnXoaLopA.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoaLopA.Location = new Point(38, 316);
            btnXoaLopA.Name = "btnXoaLopA";
            btnXoaLopA.Size = new Size(130, 34);
            btnXoaLopA.TabIndex = 9;
            btnXoaLopA.Text = "Xóa Lớp A";
            btnXoaLopA.UseVisualStyleBackColor = true;
            btnXoaLopA.Click += btnXoaLopA_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnKetThuc.Location = new Point(206, 316);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(110, 34);
            btnKetThuc.TabIndex = 10;
            btnKetThuc.Text = "Kết Thúc";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // btnXoaLopB
            // 
            btnXoaLopB.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoaLopB.Location = new Point(360, 316);
            btnXoaLopB.Name = "btnXoaLopB";
            btnXoaLopB.Size = new Size(145, 34);
            btnXoaLopB.TabIndex = 11;
            btnXoaLopB.Text = "Xóa Lớp B";
            btnXoaLopB.UseVisualStyleBackColor = true;
            btnXoaLopB.Click += btnXoaLopB_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(128, 255, 255);
            menuStrip1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cậpNhậtToolStripMenuItem, hệThốngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(549, 28);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // cậpNhậtToolStripMenuItem
            // 
            cậpNhậtToolStripMenuItem.Name = "cậpNhậtToolStripMenuItem";
            cậpNhậtToolStripMenuItem.Size = new Size(85, 24);
            cậpNhậtToolStripMenuItem.Text = "Cập nhật";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(88, 24);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.FromArgb(192, 255, 255);
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 370);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(549, 26);
            statusStrip1.TabIndex = 13;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(36, 20);
            toolStripStatusLabel1.Text = "N/A";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(164, 20);
            toolStripStatusLabel2.Text = "Desgined by Ngọc Tiên";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick_1;
            // 
            // Form1
            // 
            AcceptButton = btnCapNhat;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 396);
            Controls.Add(statusStrip1);
            Controls.Add(btnXoaLopB);
            Controls.Add(btnKetThuc);
            Controls.Add(btnXoaLopA);
            Controls.Add(btnChuyenHetQuaTrai);
            Controls.Add(btnChuyenChonQuaTrai);
            Controls.Add(btnChuyenHetQuaPhai);
            Controls.Add(btnChuyenChonQuaPhai);
            Controls.Add(lstLopB);
            Controls.Add(lstLopA);
            Controls.Add(btnCapNhat);
            Controls.Add(txtTen);
            Controls.Add(lblTenSV);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Cập Nhật 2 ListBox";
            FormClosing += Form1_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTenSV;
        private TextBox txtTen;
        private Button btnCapNhat;
        private ListBox lstLopA;
        private Button btnChuyenChonQuaPhai;
        private Button btnChuyenHetQuaPhai;
        private Button btnChuyenChonQuaTrai;
        private Button btnChuyenHetQuaTrai;
        private ListBox lstLopB;
        private Button btnXoaLopA;
        private Button btnKetThuc;
        private Button btnXoaLopB;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cậpNhậtToolStripMenuItem;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Timer timer1;
    }
}
