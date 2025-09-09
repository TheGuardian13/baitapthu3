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
        double a, b, c, d, x1, x2;
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
            a= Convert.ToDouble(txtA.Text);
            b= Convert.ToDouble(txtB.Text);
            c= Convert.ToDouble(txtC.Text);
            d = b * b - 4 * a * c;
            if (d < 0)
                // MessageBox.Show("Phương trình vô nghiệm");
                txtKQ.Text = "Phương trình vô nghiệm";
            else if (d == 0)
            {
                x1 = -b / (2 * a);
                // MessageBox.Show("Phương trình có nghiệm kép: x1 = x2 = " + x1);
                txtKQ.Text = "Phương trình có nghiệm kép: x1 = x2 = " + Math.Round(x1,1);
            }
            else
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a); // Sử dụng Math để gọi các hàm toán học 
                // MessageBox.Show("Phương trình có hai nghiệm phân biệt: x1 = " + x1 + ", x2 = " + x2);
                txtKQ.Text = "Phương trình có hai nghiệm phân biệt: x1 = " + Math.Round(x1, 1) + ", x2 = " + Math.Round(x2, 1);
            }

        }
    }
}
