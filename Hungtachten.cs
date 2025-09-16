using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitapthu3
{
    public partial class Hungtachten : Form
    {
        public Hungtachten()
        {
            InitializeComponent();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn làm mới không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Xóa nội dung trong các TextBox
                txtHoTen.Clear();
                txtHo.Clear();
                txtDem.Clear();
                txtTen.Clear();
            }
        }

        private void btnPhanTach_Click(object sender, EventArgs e)
        {
            string fullName = txtHoTen.Text.Trim(); // Lấy tên đầy đủ từ TextBox và loại bỏ khoảng trắng thừa
            if (string.IsNullOrEmpty(fullName))
            {
                MessageBox.Show("Vui lòng nhập tên đầy đủ.");
                return;
            }
            string[] nameParts = fullName.Split(' '); // Tách tên thành các phần dựa trên dấu cách
            if (nameParts.Length == 1)
                {
                // Nếu chỉ có một phần, coi đó là tên
                txtTen.Text = nameParts[0];
                txtHo.Text = "";
                txtDem.Text = "";
            }
            else if (nameParts.Length == 2)
            {
                // Nếu có hai phần, coi phần đầu là họ và phần sau là tên
                txtHo.Text = nameParts[0];
                txtTen.Text = nameParts[1];
                txtDem.Text = "";
            }
            else
            {
                // Nếu có nhiều hơn hai phần, phần đầu là họ, phần cuối là tên, các phần ở giữa là đệm
                txtHo.Text = nameParts[0];
                txtTen.Text = nameParts[nameParts.Length - 1];
                txtDem.Text = string.Join(" ", nameParts, 1, nameParts.Length - 2); // Nối các phần đệm lại với nhau, cú pháp: Join(separator, array, startIndex, count)

                /* Cách khác: Lấy đệm bằng vòng lặp for
                 string dem = "";
                for (int i = 1; i < nameParts.Length - 1; i++)
                {
                    dem += nameParts[i] + " ";
                }
                txtDem.Text = dem.Trim(); // Loại bỏ khoảng trắng thừa ở cuối
                */

            }
            {
                
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close(); // Đóng form hiện tại
            }
        }

        private void txtHoTen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnPhanTach.PerformClick(); // Kích hoạt sự kiện Click của nút btnPhanTach
                e.Handled = true; // Đánh dấu sự kiện đã được xử lý
                e.SuppressKeyPress = true; // Ngăn chặn tiếng "bíp" khi nhấn Enter và xóa ký tự xuống dòng nếu có multiline = true
            }
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập chữ cái, dấu cách và phím điều khiển (như Backspace)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Ngăn chặn ký tự không hợp lệ
                MessageBox.Show("Vui lòng chỉ nhập chữ cái và dấu cách.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
