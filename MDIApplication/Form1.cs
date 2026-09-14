namespace MDIApplication
{
    public partial class Form1 : Form
    {
        private int _documentCounter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            // Khởi tạo 3 tài liệu mẫu giống như trong ảnh minh họa sách giáo trình (Page 512)
            LoadDemoDocuments();
        }

        private void LoadDemoDocuments()
        {
            // Tài liệu 1: New Document
            _documentCounter++;
            frmDocument doc1 = new frmDocument
            {
                MdiParent = this,
                Text = "New Document",
                Size = new Size(420, 260)
            };
            doc1.Editor.Text = "This is a new document.\nYou can edit text and format font/color here.";
            doc1.IsModified = false;
            doc1.Show();

            // Tài liệu 2: About.rtf
            frmDocument doc2 = new frmDocument
            {
                MdiParent = this,
                Text = @"C:\BookProjects\Que\70-316\02\Code\316C02\bin\Debug\About.rtf",
                Size = new Size(420, 260)
            };
            doc2.Editor.Text = "About MDI Application Demo\nExam 70-316: Developing Windows-Based Applications with Microsoft Visual C# .NET.";
            doc2.IsModified = false;
            doc2.Show();

            // Tài liệu 3: MCSDNET Exam 70-316.rtf (Active document in screenshot)
            frmDocument doc3 = new frmDocument
            {
                MdiParent = this,
                Text = @"C:\Documents and Settings\Administrator\Desktop\MCSDNET Exam 70-316.rtf",
                Size = new Size(460, 300)
            };

            // Tạo nội dung RichText giống chính xác hình chụp Page 512
            SetupSampleRtfContent(doc3.Editor);
            doc3.IsModified = false;
            doc3.Show();

            // Sắp xếp dạng Cascade và kích hoạt Document 3
            this.LayoutMdi(MdiLayout.Cascade);
            doc3.Activate();
        }

        private void SetupSampleRtfContent(RichTextBox rtb)
        {
            rtb.Clear();

            // Tiêu đề 1
            rtb.SelectionFont = new Font("Segoe UI", 13F, FontStyle.Bold);
            rtb.SelectionColor = Color.Black;
            rtb.AppendText("Implementing Windows-based Applications with Microsoft Visual C# .NET and Microsoft Visual Studio .NET\n\n");

            // Tiêu đề 2
            rtb.SelectionFont = new Font("Segoe UI", 11F, FontStyle.Bold);
            rtb.SelectionColor = Color.Black;
            rtb.AppendText("Creating User Services\n\n");

            // Đoạn văn bản
            rtb.SelectionFont = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            rtb.SelectionColor = Color.Black;
            rtb.AppendText("Create a Windows Form by using the Windows Forms Designer.\n\n");

            // Bullet point
            rtb.SelectionFont = new Font("Segoe UI", 9F, FontStyle.Regular);
            rtb.SelectionBullet = true;
            rtb.AppendText("Add and set properties on a Windows Form.\n");
            rtb.AppendText("Use menus, toolbars, and status bars.\n");
            rtb.AppendText("Create Multiple Document Interface (MDI) applications.\n");
            rtb.SelectionBullet = false;

            // Đưa con trỏ về đầu
            rtb.Select(0, 0);
        }

        #region File Menu Events

        private void newToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            _documentCounter++;
            frmDocument child = new frmDocument
            {
                MdiParent = this,
                Text = _documentCounter == 1 ? "New Document" : $"New Document {_documentCounter}"
            };
            child.Show();
        }

        private void openToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Rich Text Files (*.rtf)|*.rtf|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            ofd.FilterIndex = 1;
            ofd.Title = "Open Document";

            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                frmDocument child = new frmDocument
                {
                    MdiParent = this
                };
                child.OpenFile(ofd.FileName);
                child.Show();
            }
        }

        private void saveToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            if (ActiveMdiChild is frmDocument doc)
            {
                if (string.IsNullOrEmpty(doc.FilePath))
                {
                    saveAsToolStripMenuItem_Click(sender, e);
                }
                else
                {
                    doc.SaveFile(doc.FilePath);
                    MessageBox.Show("Đã lưu tập tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Không có tài liệu nào đang mở để lưu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void saveAsToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            if (ActiveMdiChild is frmDocument doc)
            {
                using SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Rich Text Files (*.rtf)|*.rtf|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                sfd.FilterIndex = 1;
                sfd.Title = "Save Document As";
                sfd.FileName = Path.GetFileName(doc.FilePath ?? $"{doc.Text}.rtf");

                if (sfd.ShowDialog(this) == DialogResult.OK)
                {
                    doc.SaveFile(sfd.FileName);
                    MessageBox.Show("Đã lưu tập tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Không có tài liệu nào đang mở để lưu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void exitToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Format Menu Events

        private void fontToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            if (ActiveMdiChild is frmDocument doc)
            {
                using FontDialog fd = new FontDialog();
                fd.ShowColor = true;
                fd.Font = doc.Editor.SelectionFont ?? doc.Editor.Font;
                fd.Color = doc.Editor.SelectionColor;

                if (fd.ShowDialog(this) == DialogResult.OK)
                {
                    doc.SetFont(fd.Font);
                    doc.SetColor(fd.Color);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng mở hoặc chọn một tài liệu con để định dạng font.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void colorToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            if (ActiveMdiChild is frmDocument doc)
            {
                using ColorDialog cd = new ColorDialog();
                cd.Color = doc.Editor.SelectionColor;

                if (cd.ShowDialog(this) == DialogResult.OK)
                {
                    doc.SetColor(cd.Color);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng mở hoặc chọn một tài liệu con để đổi màu chữ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Window Menu Events (Layout & Management)

        private void tileHorizontallyToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticallyToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascadeToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        #endregion

        #region Help Menu Events

        private void aboutToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            MessageBox.Show(
                "StepByStep2_22: Creating an MDI Application\n" +
                "Textbook: Developing and Implementing Windows-Based Applications with Microsoft Visual C# .NET (Exam 70-316 - Page 512)\n\n" +
                "Chức năng chính:\n" +
                "- Cửa sổ cha MDI Container (IsMdiContainer = true)\n" +
                "- Quản lý và mở nhiều cửa sổ con (MdiParent = this)\n" +
                "- Menu Window tự động liệt kê các form con (MdiWindowListItem)\n" +
                "- Sắp xếp cửa sổ: Cascade, Tile Horizontally, Tile Vertically\n" +
                "- Soạn thảo và định dạng văn bản RichText (Font, Color)\n" +
                "- Mở và Lưu tập tin (.rtf, .txt)",
                "About StepByStep2_22",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        #endregion
    }
}
