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
    public partial class FormTinhTien : Form
    {
        public FormTinhTien()
        {
            InitializeComponent();
        }
        public string hovaten, socmnd, masoxe, phuongthucthue;
        public DateTime timestart;
        public DateTime timeend;
        public bool CheckXeDap = false, CheckXeMay = false;
        private void FormTinhTien_Load(object sender, EventArgs e)
        {
            timeend = DateTime.Now;
            txtHoVaTen.Text = hovaten;
            txtcmnd.Text = socmnd;
            txtmasoxe.Text = masoxe;
            txttimestart.Text = timestart.ToString("h:mm tt") + " - " + timestart.ToString("dd/MM/yyyy");
            txttimeend.Text = timeend.ToString("h:mm tt") + " - " + timeend.ToString("dd/MM/yyyy");
            DocFileGiaThueXe();
            TimeSpan ThoiGianThue = ThoiGianThueXe();
            int songay;
            songay = ThoiGianThue.Days;
            // điền thông tin vào form thanh toán
            txtgio.Text = (ThoiGianThue.Hours + songay * 24).ToString();
            txtphut.Text = ThoiGianThue.Minutes.ToString();
            if (phuongthucthue == "Ngắn Hạn")
            {
                ckbNganHan.Checked = true;
            }
            else
            {
                ckbdaihan.Checked = true;
            }
            double sogiothue = ThoiGianThue.Hours + (ThoiGianThue.Minutes / 60.0) + songay * 24;
            double tongtien;
            if (CheckXeDap == true)
            {
                tongtien = sogiothue * dv.giathuexedap;
                if (sogiothue >= 24 && ckbdaihan.Checked == true)
                {
                    tongtien -= (dv.Giamgiaxedap / 100) * tongtien;
                }
                txttienmotgio.Text = dv.giathuexedap.ToString();
            }
            else
            {
                tongtien = sogiothue * dv.giathuexemay;
                if (sogiothue >= 24 && ckbdaihan.Checked == true)
                {
                    tongtien -= (dv.Giamgiaxemay / 100) * tongtien;
                }
                txttienmotgio.Text = dv.giathuexemay.ToString();
            }
            // dấu , trong textbox
            txttongtien.Text = ((int)tongtien).ToString();
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value1 = decimal.Parse(txttongtien.Text, System.Globalization.NumberStyles.AllowThousands);
            txttongtien.Text = String.Format(culture, "{0:N0}", value1);
            txttongtien.Select(txttongtien.Text.Length, 0);
            decimal value2 = decimal.Parse(txttienmotgio.Text, System.Globalization.NumberStyles.AllowThousands);
            txttienmotgio.Text = String.Format(culture, "{0:N0}", value2);
            txttienmotgio.Select(txttienmotgio.Text.Length, 0);
            
        }
        private TimeSpan ThoiGianThueXe()
        {
            TimeSpan interval = timeend.Subtract(timestart);
            return interval;
        }
        DichVu dv = new DichVu();
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

        private void btntool_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCaiDat tools = new FormCaiDat();
            tools.ShowDialog();
            this.Show();
        }
            
    }
}
