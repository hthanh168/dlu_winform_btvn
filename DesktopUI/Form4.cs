using System;
using System.Windows.Forms;

namespace HoangDucThanh_2212460_Trang56
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void rbNam_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbNam.Checked)
            {
                MessageBox.Show("Giới tính của bạn là: " + rbNam.Text);
            }
        }

        private void rbNu_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbNu.Checked)
            {
                MessageBox.Show("Giới tính của bạn là: " + rbNu.Text);
            }
        }
    }
}
