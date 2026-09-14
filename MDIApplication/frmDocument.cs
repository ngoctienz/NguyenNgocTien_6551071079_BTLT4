using System.ComponentModel;

namespace MDIApplication
{
    public partial class frmDocument : Form
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string? FilePath { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsModified { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public RichTextBox Editor => richTextBox1;

        public frmDocument()
        {
            InitializeComponent();
        }

        public void OpenFile(string path)
        {
            try
            {
                if (Path.GetExtension(path).Equals(".rtf", StringComparison.OrdinalIgnoreCase))
                {
                    richTextBox1.LoadFile(path, RichTextBoxStreamType.RichText);
                }
                else
                {
                    richTextBox1.LoadFile(path, RichTextBoxStreamType.PlainText);
                }
                FilePath = path;
                Text = path;
                IsModified = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể mở tập tin:\n{ex.Message}", "Lỗi mở file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SaveFile(string path)
        {
            try
            {
                if (Path.GetExtension(path).Equals(".rtf", StringComparison.OrdinalIgnoreCase))
                {
                    richTextBox1.SaveFile(path, RichTextBoxStreamType.RichText);
                }
                else
                {
                    richTextBox1.SaveFile(path, RichTextBoxStreamType.PlainText);
                }
                FilePath = path;
                Text = path;
                IsModified = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể lưu tập tin:\n{ex.Message}", "Lỗi lưu file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SetFont(Font font)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.SelectionFont = font;
            }
            else
            {
                richTextBox1.Font = font;
            }
        }

        public void SetColor(Color color)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.SelectionColor = color;
            }
            else
            {
                richTextBox1.ForeColor = color;
            }
        }

        private void richTextBox1_TextChanged(object? sender, EventArgs e)
        {
            IsModified = true;
        }

        private void frmDocument_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (IsModified)
            {
                DialogResult result = MessageBox.Show(
                    $"Bạn có muốn lưu các thay đổi cho tài liệu \"{Text}\" không?",
                    "Lưu tài liệu",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (string.IsNullOrEmpty(FilePath))
                    {
                        using SaveFileDialog sfd = new SaveFileDialog();
                        sfd.Filter = "Rich Text Files (*.rtf)|*.rtf|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                        sfd.Title = "Lưu tài liệu";
                        if (sfd.ShowDialog(this) == DialogResult.OK)
                        {
                            SaveFile(sfd.FileName);
                        }
                        else
                        {
                            e.Cancel = true;
                        }
                    }
                    else
                    {
                        SaveFile(FilePath);
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
