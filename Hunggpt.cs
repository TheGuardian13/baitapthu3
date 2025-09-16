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
    public partial class Hunggpt : Form
    {
        bool daGiaixong = false;// Biến cờ để kiểm tra đã giải xong phương trình hay chưa
        double a, b, c, d, x1, x2;

        private void txtA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtB.Focus();   // Nhảy sang ô b
                e.Handled = true;
                e.SuppressKeyPress = true; // Ngăn không xuống dòng
            }
        }

        private void txtB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtC.Focus();   // Nhảy sang ô C
                e.Handled = true;
                e.SuppressKeyPress = true; // Ngăn không xuống dòng
            }
        }

        private void txtC_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnGiai.Focus();   // Nhảy sang nút Giải
                e.Handled = true;
                e.SuppressKeyPress = true; // Ngăn không xuống dòng
            }
        }

        private void btnGiai_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter &&  daGiaixong)
            {
                DialogResult tl = MessageBox.Show("Bạn có muốn giải phương trình khác không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (tl == DialogResult.Yes)
                {
                    btnClear.PerformClick(); // Giải phương trình khác
                    daGiaixong = false; // Đặt lại biến cờ
                }
                else
                    this.Close(); // Đóng form
            }


        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {

            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            txtKQ.Clear();
            txtA.Focus(); // Đưa con trỏ về ô nhập a

        }

        private void txtKQ_TextChanged_1(object sender, EventArgs e)
        {

        }

        public Hunggpt()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(txtA.Text);
                b = Convert.ToDouble(txtB.Text);
                c = Convert.ToDouble(txtC.Text);
                d = b * b - 4 * a * c;
                if (d < 0)
                    // MessageBox.Show("Phương trình vô nghiệm");
                    txtKQ.Text = "Phương trình vô nghiệm";
                else if (d == 0)
                {
                    x1 = -b / (2 * a);
                    // MessageBox.Show("Phương trình có nghiệm kép: x1 = x2 = " + x1);
                    txtKQ.Text = "Phương trình có nghiệm kép: x1 = x2 = " + Math.Round(x1, 1);
                }
                else
                {
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a); // Sử dụng Math để gọi các hàm toán học 
                                                        // MessageBox.Show("Phương trình có hai nghiệm phân biệt: x1 = " + x1 + ", x2 = " + x2);
                    txtKQ.Text = "Phương trình có hai nghiệm phân biệt: x1 = " + Math.Round(x1, 1) + ", x2 = " + Math.Round(x2, 1);
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số");
            }

        }
    }
}
