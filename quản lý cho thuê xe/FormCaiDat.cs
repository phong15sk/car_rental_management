using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace quản_lý_cho_thuê_xe
{
    public partial class FormCaiDat : Form
    {
        public FormCaiDat()
        {
            InitializeComponent();
        }

        private void FormCaiDat_Load(object sender, EventArgs e)
        {
            cmbgiamxedap.Items.Add("0");
            cmbgiamxedap.Items.Add("5");
            cmbgiamxedap.Items.Add("10");
            cmbgiamxedap.Items.Add("15");
            cmbgiamxedap.Items.Add("20");
            cmbgiamxedap.SelectedIndex = 0;
            cmbgiamxemay.Items.Add("0");
            cmbgiamxemay.Items.Add("5");
            cmbgiamxemay.Items.Add("10");
            cmbgiamxemay.Items.Add("15");
            cmbgiamxemay.Items.Add("20");
            cmbgiamxemay.SelectedIndex = 0;
            DocFileGiaThueXe();
            DuaDuLieuLenForm();
        }
        DichVu dv = new DichVu();
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int check = 0;
            if (txtGiaXeDap.Text.Length == 0)
            {
                check = 1;
            }
            if (txtgiaxemay.Text.Length == 0)
            {
                check = 1;
            }
            if (check == 0)
            {
                try
                {
                    dv.giathuexedap = double.Parse(txtGiaXeDap.Text);
                    dv.giathuexemay = double.Parse(txtgiaxemay.Text);
                    dv.Giamgiaxedap = double.Parse(cmbgiamxedap.SelectedItem.ToString());
                    dv.Giamgiaxemay = double.Parse(cmbgiamxemay.SelectedItem.ToString());
                    GhiFileGiaThueXe();
                    MessageBox.Show("\nBạn Đã Cập Nhật Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch
                {
                    txtGiaXeDap.Clear();
                    txtgiaxemay.Clear();
                    MessageBox.Show("Lỗi Nhập Dữ Liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui Lòng Điền Đầy Đủ Thông Tin Phía Trên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GhiFileGiaThueXe()
        {
            StreamWriter GhiFile = new StreamWriter("BangGiaThueXe.TXT", false, Encoding.Unicode);
            string str1 = "giá thuê xe đạp : ";
            string str2 = "giá thuê xe máy : ";
            str1 += dv.giathuexedap.ToString() + " : " + "giảm giá : " + cmbgiamxedap.SelectedItem.ToString();
            str2 += dv.giathuexemay.ToString() + " : " + "giảm giá : " + cmbgiamxemay.SelectedItem.ToString();
            for (int i = 0; i < str1.Length; ++i)
            {
                GhiFile.Write(str1[i]);
            }
            GhiFile.Write('\n');
            for (int i = 0; i < str2.Length; ++i)
            {
                GhiFile.Write(str2[i]);
            }
            GhiFile.Close();
        }
        private void DocFileGiaThueXe()
        {
            StreamReader DocFile = new StreamReader("BangGiaThueXe.TXT", Encoding.Unicode);
            FileInfo finfor = new FileInfo("BangGiaThueXe.TXT");
            char[] kitu = new char[finfor.Length];
            int k = 0;
            while (!DocFile.EndOfStream)
            {
                kitu[k++] = (char)DocFile.Read();
            }
            string str = new string(kitu);
            string[] arr = str.Split('\n');
            string[] giathuexedap = arr[0].Split(':');
            string[] giathuexemay = arr[1].Split(':');
            dv.giathuexedap = double.Parse(giathuexedap[1]);
            dv.Giamgiaxedap = double.Parse(giathuexedap[3]);
            dv.giathuexemay = double.Parse(giathuexemay[1]);
            dv.Giamgiaxemay = double.Parse(giathuexemay[3]);
            DocFile.Close();
        }
        private void DuaDuLieuLenForm()
        {
            txtGiaXeDap.Text = dv.giathuexedap.ToString();
            txtgiaxemay.Text = dv.giathuexemay.ToString();
            cmbgiamxedap.SelectedIndex = (int)(dv.Giamgiaxedap / 5 );
            cmbgiamxemay.SelectedIndex = (int)(dv.Giamgiaxemay / 5);
            // dấu , trong textbox
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value1 = decimal.Parse(txtGiaXeDap.Text, System.Globalization.NumberStyles.AllowThousands);
            txtGiaXeDap.Text = String.Format(culture, "{0:N0}", value1);
            txtGiaXeDap.Select(txtGiaXeDap.Text.Length, 0);
            decimal value2 = decimal.Parse(txtgiaxemay.Text, System.Globalization.NumberStyles.AllowThousands);
            txtgiaxemay.Text = String.Format(culture, "{0:N0}", value2);
            txtgiaxemay.Select(txtGiaXeDap.Text.Length, 0);
        }
    }
}
