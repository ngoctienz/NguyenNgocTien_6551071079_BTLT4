namespace UseMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Start();
        }

        #region Các sự kiện Button từ bài 14 (2ListBox)

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text.Trim();
            if (string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Vui lòng nhập tên sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return;
            }

            lstLopA.Items.Add(ten);
            txtTen.Clear();
            txtTen.Focus();
        }

        private void btnChuyenChonQuaPhai_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstLopA.SelectedItems.Count; i++)
            {
                lstLopB.Items.Add(lstLopA.SelectedItems[i]!);
            }
            for (int j = lstLopA.SelectedItems.Count - 1; j >= 0; j--)
            {
                lstLopA.Items.Remove(lstLopA.SelectedItems[j]!);
            }
        }

        private void btnChuyenHetQuaPhai_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstLopA.Items.Count; i++)
            {
                lstLopB.Items.Add(lstLopA.Items[i]!);
            }
            lstLopA.Items.Clear();
        }

        private void btnChuyenChonQuaTrai_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstLopB.SelectedItems.Count; i++)
            {
                lstLopA.Items.Add(lstLopB.SelectedItems[i]!);
            }
            for (int j = lstLopB.SelectedItems.Count - 1; j >= 0; j--)
            {
                lstLopB.Items.Remove(lstLopB.SelectedItems[j]!);
            }
        }

        private void btnChuyenHetQuaTrai_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstLopB.Items.Count; i++)
            {
                lstLopA.Items.Add(lstLopB.Items[i]!);
            }
            lstLopB.Items.Clear();
        }

        private void btnXoaLopA_Click(object sender, EventArgs e)
        {
            if (lstLopA.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa trong Lớp A!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            for (int i = lstLopA.SelectedItems.Count - 1; i >= 0; i--)
            {
                lstLopA.Items.Remove(lstLopA.SelectedItems[i]!);
            }
        }

        private void btnXoaLopB_Click(object sender, EventArgs e)
        {
            if (lstLopB.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa trong Lớp B!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            for (int i = lstLopB.SelectedItems.Count - 1; i >= 0; i--)
            {
                lstLopB.Items.Remove(lstLopB.SelectedItems[i]!);
            }
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát chương trình?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");
        }

        #endregion

        #region Các sự kiện MenuStrip gọi lại xử lý của Button

        private void cậpNhậtLớpAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCapNhat_Click(sender, e);
        }

        private void cậpNhậtLớpBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text.Trim();
            if (string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Vui lòng nhập tên sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return;
            }

            lstLopB.Items.Add(ten);
            txtTen.Clear();
            txtTen.Focus();
        }

        private void chuyểnPhầnTửChọnSangLớpAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnChuyenChonQuaTrai_Click(sender, e);
        }

        private void chuyểnPhầnTửChọnSangLớpBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnChuyenChonQuaPhai_Click(sender, e);
        }

        private void chuyểnHếtDsSangLớpAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnChuyenHetQuaTrai_Click(sender, e);
        }

        private void chuyểnHếtDsSangLớpBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnChuyenHetQuaPhai_Click(sender, e);
        }

        private void xóaDanhSáchLớpAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnXoaLopA_Click(sender, e);
        }

        private void xóaDanhSáchLớpBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnXoaLopB_Click(sender, e);
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Chương trình: Quản lý danh sách sinh viên 2 ListBox (Sử dụng Menu)\n" +
                "Sinh viên thực hiện: Ngọc Tiên\n" +
                "Môn học: Lập trình Windows 1",
                "Thông tin sinh viên",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void kếtThúcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnKetThuc_Click(sender, e);
        }

        #endregion
    }
}
