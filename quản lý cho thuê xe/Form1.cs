using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quản_lý_cho_thuê_xe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnXeMay_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3OXeMay fxemay = new Form3OXeMay();
            fxemay.ShowDialog();
            this.Show();
        }

        private void btnthuexedap_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormThueXeDap fxedap = new FormThueXeDap();
            fxedap.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDanhSachNguoiThue fdanhsach = new FormDanhSachNguoiThue();
            fdanhsach.ShowDialog();
            this.Show();
        }

        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDanhSachNguoiThue formthanhtoan = new FormDanhSachNguoiThue();
            formthanhtoan.ShowDialog();
            this.Show();
        }

      
    }
}
