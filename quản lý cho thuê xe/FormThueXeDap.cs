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
    public partial class FormThueXeDap : Form
    {
        public FormThueXeDap()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // truyền dữ liệu vào combobox
            cmbphuongthucthue.Items.Add("Ngắn Hạn");
            cmbphuongthucthue.Items.Add("Dài Hạn");
            cmbphuongthucthue.SelectedIndex = 0;
            // truyền dữ liệu vào listview
            lsvthuexedap.Columns.Add("STT", 50);
            lsvthuexedap.Columns.Add("Họ Và Tên", 200, HorizontalAlignment.Center);
            lsvthuexedap.Columns.Add("Số CMND/ID", 200, HorizontalAlignment.Center);
            lsvthuexedap.Columns.Add("Mã Số Xe", 100, HorizontalAlignment.Center);
            lsvthuexedap.Columns.Add("Phương Thức Thuê", 150, HorizontalAlignment.Center);
            lsvthuexedap.Columns.Add("Time Start", 130, HorizontalAlignment.Center);
            lsvthuexedap.Columns.Add("Ngày Thuê", 130, HorizontalAlignment.Center);
            // Tạo 1 lần rồi thôi
            //Filemasoxedap();
            mangmasoxedap();
            DocFileDanhSachThueVaoMang();
        }
        // Tạo Mã số xe cho 50 chiếc xe đạp và ghi vào file
        private void Filemasoxedap()
        {
            // Tạo đối tượng quản lý để ghi file
            StreamWriter GhiFile = new StreamWriter("MaSoXeDap.TXT", false, Encoding.Unicode);
            string str;
            for (int i = 1; i <= 50; ++i)
            {
                str = "XD0";
                str = i > 9 ? str + i.ToString() : str + "0" + i.ToString(); 
                for (int j = 0; j < str.Length; ++j)
                {
                    GhiFile.Write(str[j]);
                }
                GhiFile.Write('\n');
            }
            GhiFile.Close();
        }
      
        // đưa mã số xe đạp vào mảng mã số ;
        private void mangmasoxedap()
        {
            //đọc mã số xe đạp
            // tạo đối tượng quản lý file để đọc
            StreamReader docfile = new StreamReader("MaSoXeDap.TXT", Encoding.Unicode);
            // khai báo mảng 1 chiều các kí tự
            char[] arrkitu;
            // lấy thông tin từ file
            FileInfo finfor = new FileInfo("MaSoXeDap.TXT");
            // phân phối vùng nhớ cho mảng kí tự
            arrkitu = new char[finfor.Length];
            int k = 0;
            while (!docfile.EndOfStream)
            {
                arrkitu[k++] = (char)docfile.Read();
            }
            // đưa vào chuỗi
            string str = new string(arrkitu);
            // đưa vào mảng mã số xe đạp
            dv.arrrmaxedap = str.Split('\n');
        }
      
        // hàm kiểm tra xem mã số xe có trong file hay không 
        private bool kiemtramasoxetrongfile()
        {
            // check xe đạp
            for (int i = 0; i < dv.arrrmaxedap.Length; ++i)
            {
                if (string.Compare(txtmasoxe.Text, dv.arrrmaxedap[i], true) == 0)
                {
                    return true;
                }
            }
                return false;
        }
        // hàm kiểm tra xem mã số xe đã tồn tại trong listview hay chưa
        private bool kiemtramasoxetronglistview(string masoxe)
        {
            // check xe đạp
            for (int i = 0; i < dv.arrthuexedap.Count; ++i)
            {
                if (string.Compare(masoxe, dv.arrthuexedap[i].MASOXE, true) == 0)
                {
                    return true;
                }
            }
            return false;
        }
        // hàm kiểm tra tất cả dữ liệu nhập đã hợp lệ chưa
        private bool kiemtrahople()
        {
            if (txtnguoithue.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập vào tên người thuê", "Lỗi!",  MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnguoithue.Focus();
                return false;
            }
            if (txtsocmnd.Text.Length == 0)
            {
                MessageBox.Show("Bạn Phải nhập vào Số CMND/ID", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtsocmnd.Focus();
                return false;
            }
            if (kiemtramasoxetrongfile() == false)
            {
                MessageBox.Show("Bạn phải nhập đúng mã số xe", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmasoxe.Clear();
                txtmasoxe.Focus();
                return false;
            }
            if (kiemtramasoxetronglistview(txtmasoxe.Text) == true)
            {
                MessageBox.Show("Xe này đã cho thuê", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmasoxe.Clear();
                txtmasoxe.Focus();
                return false;
            }
            return true;
        }
        // hàm đưa dữ liệu vào lớp thuê xe đạp 
        private void duadulieuvaolopthuexedap(ref ThueXeDap xedap)
        {
            xedap.HOVATEN = txtnguoithue.Text;
            xedap.MASOXE = txtmasoxe.Text;
            xedap.SOCMND = txtsocmnd.Text;
            xedap.PHUONGTHUCTHUE = cmbphuongthucthue.SelectedItem.ToString();
            xedap.TIMESTART = DateTime.Now;
        }
        // hàm đưa dữ liệu từ lớp thuê xe đạp vào listview
        private void duadulieuvaolistviewitem(ref ThueXeDap xedap,ref ListViewItem lsvitem)
        {
            // đưa dữ liệu vào vào 1 dòng chính là listviewitem , xem listviewitem như một mảng một chiều
            lsvitem.SubItems.Add(xedap.HOVATEN); // thêm vào cột 2
            lsvitem.SubItems.Add(xedap.SOCMND);
            lsvitem.SubItems.Add(xedap.MASOXE);
            lsvitem.SubItems.Add(xedap.PHUONGTHUCTHUE);
            lsvitem.SubItems.Add(xedap.TIMESTART.ToString("h:mm tt"));
            lsvitem.SubItems.Add(xedap.TIMESTART.ToString("dd/MM/yyyy"));
        }
        // khai báo lớp dịch vụ 
        DichVu dv = new DichVu();
        int STT = 0; // đánh số thứ tự  
        private void btnbatdauthue_Click(object sender, EventArgs e)
        {
            // kiểm tra xem thông tin đã hợp lệ chưa
            if (kiemtrahople() == true)
            {
                STT++;
                ThueXeDap xedap = new ThueXeDap();
                // đưa dữ liệu vào lớp thuê xe đạp
                duadulieuvaolopthuexedap(ref xedap);
                // đưa dữ liệu vào mảng thuê xe đạp
                dv.arrthuexedap.Add(xedap);
                // đưa dữ liệu vào listviewitem
                ListViewItem lsvitem = new ListViewItem(STT.ToString());// thêm vào cột 1
                duadulieuvaolistviewitem(ref xedap, ref lsvitem);
                // đưa dữ liệu vào listview (danh sách thuê xe đạp)
                lsvthuexedap.Items.Add(lsvitem);
            }
            // Đặt lại biến đếm bằng 0 của nút auto
            dem = 0;
        }
        // Hàm đưa dữ liệu lên trên khi biết chỉ số index
        private void DuaThongTinLenTren(int index)
        {
            txtnguoithue.Text = lsvthuexedap.Items[index].SubItems[1].Text;
            txtsocmnd.Text = lsvthuexedap.Items[index].SubItems[2].Text;
            txtmasoxe.Text = lsvthuexedap.Items[index].SubItems[3].Text;
            cmbphuongthucthue.Text = lsvthuexedap.Items[index].SubItems[4].Text;
        }
        // hàm truyền dữ liệu lên trên khi nhấn vào một đối tượng trong listview
        private void lsvthuexedap_DoubleClick(object sender, EventArgs e)
        {
            // Lây ra số lượng trong listview
            int soluong = lsvthuexedap.Items.Count;
            for (int i = 0; i < soluong; ++i)
            {
                if (lsvthuexedap.Items[i].Selected == true)
                {
                    DuaThongTinLenTren(i);
                    break;
                }
            }
        }
        // biến đếm để kiểm tra xem có ấn nút auto tiếp ko
        int dem = 0;
        private void btnauto_Click(object sender, EventArgs e)
        {
            int soluong = dv.arrrmaxedap.Length;
            for (; dem < soluong; ++dem)
            {
                if (kiemtramasoxetronglistview(dv.arrrmaxedap[dem]) == false)
                {
                    txtmasoxe.Text = dv.arrrmaxedap[dem];
                    break;
                }
            }
            dem++;
            if (dem == 51)
            {
                dem = 0;
            }
                
        }
       // Ghi File để lưu trữ danh sách người thuê
        private void TaoFileDanhSachNguoiThue()
        {
            StreamWriter GhiFile = new StreamWriter("DanhSachNguoiThueXeDap.TXT", false, Encoding.Unicode);
            int soluong = dv.arrthuexedap.Count;
            for (int i = 0; i < soluong; ++i)
            {
                for (int j = 0; j < dv.arrthuexedap[i].HOVATEN.Length; ++j)
                {
                    GhiFile.Write(dv.arrthuexedap[i].HOVATEN[j]);
                }
                GhiFile.Write('-');
                for (int k = 0; k < dv.arrthuexedap[i].SOCMND.Length; ++k)
                {
                    GhiFile.Write(dv.arrthuexedap[i].SOCMND[k]);
                }
                GhiFile.Write('-');
                for (int l = 0; l < dv.arrthuexedap[i].MASOXE.Length; ++l)
                {
                    GhiFile.Write(dv.arrthuexedap[i].MASOXE[l]);
                }
                GhiFile.Write('-');
                for (int m = 0; m < dv.arrthuexedap[i].PHUONGTHUCTHUE.Length; ++m)
                {
                    GhiFile.Write(dv.arrthuexedap[i].PHUONGTHUCTHUE[m]);
                }
                GhiFile.Write('-');
                for (int n = 0; n < lsvthuexedap.Items[i].SubItems[5].Text.Length; ++n)
                {
                    GhiFile.Write(lsvthuexedap.Items[i].SubItems[5].Text[n]);
                }
                GhiFile.Write('-');
                for (int n = 0; n < lsvthuexedap.Items[i].SubItems[6].Text.Length; ++n)
                {
                    GhiFile.Write(lsvthuexedap.Items[i].SubItems[6].Text[n]);
                }
                GhiFile.Write('\n');
            }
            GhiFile.Close();
        }

        // Đọc File danh sách người thuê vào mảng và listview
        private void DocFileDanhSachThueVaoMang()
        {
            StreamReader DocFile = new StreamReader("DanhSachNguoiThueXeDap.TXT", Encoding.Unicode);
            FileInfo finfor = new FileInfo("DanhSachNguoiThueXeDap.TXT");
            char[] kitu = new char[finfor.Length];
            int k = 0;
            while (!DocFile.EndOfStream)
            {
                kitu[k++] = (char)DocFile.Read();
            }
            string str = new string(kitu);
            string[] arr1 = str.Split('\n');
            for (int i = 0; i < arr1.Length - 1; ++i)
            {
                string[] arr2 = arr1[i].Split('-');
                ThueXeDap xedap = new ThueXeDap();
                xedap.HOVATEN = arr2[0];
                xedap.SOCMND = arr2[1];
                xedap.MASOXE = arr2[2];
                xedap.PHUONGTHUCTHUE = arr2[3];
                // chú ý: Phải cập nhật ngày tháng trước
                //Ngày thuê
                //thời gian
                xedap.TIMESTART = DateTime.Parse(arr2[4] + arr2[5]);
                dv.arrthuexedap.Add(xedap);
                ListViewItem item = new ListViewItem((++STT).ToString());
                duadulieuvaolistviewitem(ref xedap, ref item);
                lsvthuexedap.Items.Add(item);
            }
            DocFile.Close();
        }
        private void FormThueXeDap_FormClosing(object sender, FormClosingEventArgs e)
        {
            TaoFileDanhSachNguoiThue();
        }    
    }
}
