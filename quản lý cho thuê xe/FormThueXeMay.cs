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

namespace quản_lý_cho_thuê_xe
{
    public partial class Form3OXeMay : Form
    {
        public Form3OXeMay()
        {
            InitializeComponent();
        }

        private void Form3OXeMay_Load(object sender, EventArgs e)
        {
            DocFileThongTinXeMay();
            //truyền dữ liệu vào combocbox loại xe
            cmbLoaiXe.Items.Add("Honda Wave Alpha");
            cmbLoaiXe.Items.Add("Honda Cup");
            cmbLoaiXe.Items.Add("Air Blade");
            cmbLoaiXe.Items.Add("Yamaha Exciter");
            cmbLoaiXe.SelectedIndex = 0;
            //truyền dữ liệu vào combobox phương thức thuê
            cmbphuongthucthue.Items.Add("Ngắn Hạn");
            cmbphuongthucthue.Items.Add("Dài Hạn");
            cmbphuongthucthue.SelectedIndex = 0;
            //đưa dữ liệu vào listview
            lsvthuexemay.Columns.Add("STT", 50);
            lsvthuexemay.Columns.Add("Họ Và Tên", 170, HorizontalAlignment.Center);
            lsvthuexemay.Columns.Add("Số CMND/ID", 150, HorizontalAlignment.Center);
            lsvthuexemay.Columns.Add("Mã Số Xe", 100, HorizontalAlignment.Center);
            lsvthuexemay.Columns.Add("Loại Xe", 140, HorizontalAlignment.Center);
            lsvthuexemay.Columns.Add("Biển Số", 100, HorizontalAlignment.Center);
            lsvthuexemay.Columns.Add("Phương Thức Thuê", 150, HorizontalAlignment.Center);
            lsvthuexemay.Columns.Add("Time Start", 100, HorizontalAlignment.Center);
            lsvthuexemay.Columns.Add("Ngày Thuê", 100, HorizontalAlignment.Center);
            // tạo file thông tin xe máy
            //filethongtinxemay();
            DocFileThueXeMay();
        }
        // Tạo file chứa thông tin của xe máy
        private void filethongtinxemay()
        {
            StreamWriter GhiFile = new StreamWriter("ThongTinXeMay.TXT", false, Encoding.Unicode);
            string strmaxe;
            int loaixe;
            string bienso;
            Random rd = new Random(); 
            for (int i = 1; i <= 40; ++i) // tao 40 chiec xe may
            {
                strmaxe = "XM";
                strmaxe = i > 9 ? strmaxe + i.ToString() : strmaxe + "0" + i.ToString();
                //Tạo Mã Số Xe
                for (int j = 0; j < strmaxe.Length; ++j)
                {
                    GhiFile.Write(strmaxe[j]);
                }
                GhiFile.Write('-');
                // Tạo Loại xe
                if (i <= 10)
                {
                    loaixe = 0;
                }
                else if (i <= 20)
                {
                    loaixe = 1;
                }
                else if (i <= 30)
                {
                    loaixe = 2;
                }
                else
                {
                    loaixe = 3;
                }
                GhiFile.Write(char.Parse(loaixe.ToString()));
                GhiFile.Write('-');
                // Tạo Biển số xe
                bienso = "78L1 ";
                int so = rd.Next(1000, 10000);
                bienso += so.ToString();
                for (int j = 0; j < bienso.Length; ++j)
                {
                    GhiFile.Write(bienso[j]);
                }
                GhiFile.Write('\n');
            }
            GhiFile.Close();
        }
        // đọc file chứa thông tin xe máy và đưa vào lớp xe máy 
        private void DocFileThongTinXeMay()
        {
            StreamReader DocFile = new StreamReader("ThongTinXeMay.TXT", Encoding.Unicode);
            FileInfo finfor = new FileInfo("ThongTinXeMay.TXT");
            char[] kitu = new char[finfor.Length];
            int k = 0;
            while (!DocFile.EndOfStream)
            {
                kitu[k++] = (char)DocFile.Read();
            }
            string str = new string(kitu);
            string[] arrthongtinxemay = str.Split('\n');
            // đưa thông tin xe máy cho lớp 
            dv.arrthongtinxemay = new string[arrthongtinxemay.Length - 1, 3];
            for (int n = 0; n < arrthongtinxemay.Length - 1; ++n)
            {
                // Lấy thông tin từ 1 xe
                string[] arrthongtin1xe = arrthongtinxemay[n].Split('-');
                for (int m = 0; m < 3; ++m)
                {
                    // gán giá trị qua cho từng phần tử của mảng 2 chiều
                    dv.arrthongtinxemay[n, m] = arrthongtin1xe[m];
                }
            }
            DocFile.Close();
        }
        // Dựa Vào mã số xe để lấy ra biển số xe
        private string LayRaBienSoXe(string masoxe)
        {
            string biensoxe = null;
            int sodong = dv.arrthongtinxemay.Length / 3;
            for (int i = 0; i < sodong; ++i)
            {
                if (string.Compare(masoxe, dv.arrthongtinxemay[i, 0], true) == 0)
                {
                    biensoxe = dv.arrthongtinxemay[i, 2];
                    break;
                }
            }
            return biensoxe;
        }
        // Dựa vào mã số xe để lấy ra loại xe
        private int LayRaLoaiXe(string masoxe)
        {
            int loaixe = -1;
            int sodong = dv.arrthongtinxemay.Length / 3;
            for (int i = 0; i < sodong; ++i)
            {
                if (string.Compare(dv.arrthongtinxemay[i, 0], masoxe, true) == 0)
                {
                    loaixe = int.Parse(dv.arrthongtinxemay[i, 1]);
                    break;
                }
            }
            return loaixe;
        }
        // Hàm kiểm tra xem có mã số xe máy hay không
        private bool checkmasoxe(string masoxe)
        {
            int sodong = dv.arrthongtinxemay.Length / 3;
            for (int i = 0; i < sodong; ++i)
            {
                if (string.Compare(dv.arrthongtinxemay[i, 0], masoxe, true) == 0)
                {
                    return true;
                }
            }
            return false;
        }
        // Hàm Kiểm tra xem mã số xe này có trong listview hay chưa
        private bool Checkmasoxetronglistview(string masoxe)
        {
            int soluong = dv.arrthuexemay.Count;
            for (int i = 0; i < soluong; ++i)
            {
                if (string.Compare(masoxe, dv.arrthuexemay[i].MASOXE, true) == 0)
                {
                    return true; // có tồn tại trong listview
                }
            }
            return false;
        }
       

        // Hàm kiểm tra thông tin đã chính xác chưa
        private bool KiemTraThongTin()
        {
            if (txthovaten.Text.Length == 0)
            {
                MessageBox.Show("Vui Lòng Nhập Vào Họ Và Tên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txthovaten.Focus();
                return false;
            }
            if (txtmasoxe.Text.Length == 0)
            {
                MessageBox.Show("Vui Lòng Nhập Vào Mã Số Xe", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txthovaten.Focus();
                return false;
            }
            if (txtsocmnd.Text.Length == 0)
            {
                MessageBox.Show("Vui Lòng Nhập Vào Số CMND", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtsocmnd.Focus();
                return false;
            }
            if (checkmasoxe(txtmasoxe.Text) == false)
            {
                MessageBox.Show("Không Có Mã Số Xe Này !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmasoxe.Clear();
                txtmasoxe.Focus();
                return false;
            }
            if (LayRaLoaiXe(txtmasoxe.Text) != cmbLoaiXe.SelectedIndex)
            {
                MessageBox.Show("Mã Số Xe Và Loại Xe Này Không Trùng Khớp \nLoại Xe Này Là: " + cmbLoaiXe.Items[LayRaLoaiXe(txtmasoxe.Text)], "Lỗi");
                DialogResult ketqua = MessageBox.Show("Bạn Có Muốn Thay Đổi Loại Xe Này Không ?", "Thông Báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (ketqua == DialogResult.Yes)
                {
                    cmbLoaiXe.SelectedIndex = LayRaLoaiXe(txtmasoxe.Text);
                }
                return false;
            }
            if (Checkmasoxetronglistview(txtmasoxe.Text) == true)
            {
                MessageBox.Show("Xe Này Đã Cho Thuê ! Xin vui lòng chọn xe khác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmasoxe.Clear();
                txtmasoxe.Focus();
                return false;
            }  
            return true;
        }
        // Đưa thông tin vào lớp thuê xe máy
        private void DuaDuLieuVaoLopThueXeMay(ref ThueXeMay xemay)
        {
            xemay.HOVATEN = txthovaten.Text;
            xemay.MASOXE = txtmasoxe.Text;
            xemay.BIENSOXE = LayRaBienSoXe(xemay.MASOXE);
            xemay.PHUONGTHUCTHUE = cmbphuongthucthue.SelectedItem.ToString();
            xemay.SOCMND = txtsocmnd.Text;
            xemay.LOAIXE = cmbLoaiXe.SelectedItem.ToString();
            xemay.TIMESTART = DateTime.Now;
        }
        // đưa thông tin vào listview
        int STT = 0;
        private void DuaDuLieuVaoListViewItem(ThueXeMay xemay, out ListViewItem lsvitem)
        {
            STT++;
            lsvitem = new ListViewItem(STT.ToString());
            lsvitem.SubItems.Add(xemay.HOVATEN);
            lsvitem.SubItems.Add(xemay.SOCMND);
            lsvitem.SubItems.Add(xemay.MASOXE);
            lsvitem.SubItems.Add(xemay.LOAIXE);
            lsvitem.SubItems.Add(xemay.BIENSOXE);
            lsvitem.SubItems.Add(xemay.PHUONGTHUCTHUE);
            lsvitem.SubItems.Add(xemay.TIMESTART.ToString("h:mm tt"));
            //MessageBox.Show(xemay.TIMESTART.ToString("h:mm tt"));
            lsvitem.SubItems.Add(xemay.TIMESTART.ToString("dd/MM/yyyy"));
        }
        // Hàm tự động chọn mã số xe khi thay đổi loại xe
        private void cmbLoaiXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            int soluong = dv.arrthongtinxemay.Length / 3;
            for (int i = 0; i < soluong; ++i)
            {
                if (dv.arrthongtinxemay[i, 1] == cmbLoaiXe.SelectedIndex.ToString())
                {
                    if (Checkmasoxetronglistview(dv.arrthongtinxemay[i, 0]) == false)
                    {
                        txtmasoxe.Text = dv.arrthongtinxemay[i, 0];
                        break;
                    }
                }
            }
        }
        // hàm đặt lại mặt định
        private void MatDinh()
        {
            txthovaten.Clear();
            txtsocmnd.Clear();
            cmbLoaiXe.SelectedIndex = 0;
        }  
        DichVu dv = new DichVu(); // khai báo lớp dịch vụ
        private void btnthuexe_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTin() == true)
            {
                ThueXeMay xemay = new ThueXeMay();
                DuaDuLieuVaoLopThueXeMay(ref xemay);
                dv.arrthuexemay.Add(xemay);
                ListViewItem lsvitem;
                DuaDuLieuVaoListViewItem(xemay, out lsvitem);
                lsvthuexemay.Items.Add(lsvitem);
                MatDinh();
            }

        }

        private void lsvthuexemay_DoubleClick(object sender, EventArgs e)
        {
            txthovaten.Text = lsvthuexemay.SelectedItems[0].SubItems[1].Text;
            txtsocmnd.Text = lsvthuexemay.SelectedItems[0].SubItems[2].Text;
            txtmasoxe.Text = lsvthuexemay.SelectedItems[0].SubItems[3].Text;
            cmbLoaiXe.SelectedItem = lsvthuexemay.SelectedItems[0].SubItems[4].Text;
            cmbphuongthucthue.SelectedItem = lsvthuexemay.SelectedItems[0].SubItems[6].Text;
        }
       // Hàm danh sách người thuê thông tin xe máy lưu vào file
        private void GhiDanhSachNguoiThueVaoFile()
        {
            StreamWriter GhiFile = new StreamWriter("DanhSachThueXeMay.TXT", false, Encoding.Unicode);
            int soluong = dv.arrthuexemay.Count;
            for(int i = 0; i < soluong; ++i)
            {
                for(int j = 0; j < dv.arrthuexemay[i].HOVATEN.Length; ++j)
                {
                    GhiFile.Write(dv.arrthuexemay[i].HOVATEN[j]);
                }
                GhiFile.Write('-');
                for(int k = 0; k < dv.arrthuexemay[i].SOCMND.Length; ++k)
                {
                    GhiFile.Write(dv.arrthuexemay[i].SOCMND[k]);
                }
                GhiFile.Write('-');
                for(int l = 0; l < dv.arrthuexemay[i].MASOXE.Length; ++l)
                {
                    GhiFile.Write(dv.arrthuexemay[i].MASOXE[l]);
                }
                GhiFile.Write('-');
                for(int m = 0; m < dv.arrthuexemay[i].LOAIXE.Length; ++m)
                {
                    GhiFile.Write(dv.arrthuexemay[i].LOAIXE[m]);
                }
                GhiFile.Write('-');
                for(int n = 0; n < dv.arrthuexemay[i].BIENSOXE.Length; ++n)
                {
                    GhiFile.Write(dv.arrthuexemay[i].BIENSOXE[n]);
                }
                GhiFile.Write('-');
                for(int a = 0; a < dv.arrthuexemay[i].PHUONGTHUCTHUE.Length; ++a)
                {
                    GhiFile.Write(dv.arrthuexemay[i].PHUONGTHUCTHUE[a]);
                }
                GhiFile.Write('-');
                for(int b = 0; b < lsvthuexemay.Items[i].SubItems[7].Text.Length; ++b)
                {
                    GhiFile.Write(lsvthuexemay.Items[i].SubItems[7].Text[b]);
                }
                GhiFile.Write('-');
                for(int c = 0; c < dv.arrthuexemay[i].TIMESTART.ToString("dd/MM/yyyy").Length; ++c)
                {
                    GhiFile.Write(dv.arrthuexemay[i].TIMESTART.ToString("dd/MM/yyyy")[c]);
                }
                GhiFile.Write('\n');
            }
            GhiFile.Close();
        }

        private void Form3OXeMay_FormClosing(object sender, FormClosingEventArgs e)
        {
            GhiDanhSachNguoiThueVaoFile();
        }

        // hàm đọc file đưa vào form
        private void DocFileThueXeMay()
        {
            // Tạo đối tượng đọc file
            StreamReader DocFile = new StreamReader("DanhSachThueXeMay.TXT", Encoding.Unicode);
            // đọc thông tin từ file
            FileInfo finfor = new FileInfo("DanhSachThueXeMay.TXT");
            // sắp xếp các ô nhớ thích hợp để nhận các kí tự từ file
            char[] kitu = new char[finfor.Length];
            int k = 0;
            while (!DocFile.EndOfStream) //trong khi khi chưa đến kí tự ở cuối file
            {
                kitu[k++] = (char)DocFile.Read();
            }
            // Đưa mảng kí tự vào chuỗi
            string str = new string(kitu);
            // Tạo một mảng chuỗi mỗi phần tử là thông tin của một người thuê
            string[] arr = str.Split('\n');
            for (int i = 0; i < arr.Length - 1; ++i)
            {
                string[] arr2 = arr[i].Split('-');
                ThueXeMay xemay = new ThueXeMay();
                xemay.HOVATEN = arr2[0];
                xemay.SOCMND = arr2[1];
                xemay.MASOXE = arr2[2];
                xemay.LOAIXE = arr2[3];
                xemay.BIENSOXE = arr2[4];
                xemay.PHUONGTHUCTHUE = arr2[5]; 
                xemay.TIMESTART = DateTime.Parse(arr2[6] + arr2[7]);
                dv.arrthuexemay.Add(xemay);
                ListViewItem lsvitem;
                DuaDuLieuVaoListViewItem(dv.arrthuexemay[i], out lsvitem);
                lsvthuexemay.Items.Add(lsvitem);
            }
            DocFile.Close();
            // đưa dữ liệu từ lớp vào listview
        } 
    }
}
