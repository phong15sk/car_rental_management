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
    public partial class FormDanhSachNguoiThue : Form
    {
        public FormDanhSachNguoiThue()
        {
            InitializeComponent();
        }
        DichVu dv = new DichVu();
        private void FormDanhSachNguoiThue_Load(object sender, EventArgs e)
        {
            lsvXeDap.Columns.Add("STT", 50);
            lsvXeDap.Columns.Add("Họ Và Tên", 200, HorizontalAlignment.Center);
            lsvXeDap.Columns.Add("Số CMND/ID", 200, HorizontalAlignment.Center);
            lsvXeDap.Columns.Add("Mã Số Xe", 100, HorizontalAlignment.Center);
            lsvXeDap.Columns.Add("Phương Thức Thuê", 180, HorizontalAlignment.Center);
            lsvXeDap.Columns.Add("Time Start", 130, HorizontalAlignment.Center);
            lsvXeDap.Columns.Add("Ngày Thuê", 130, HorizontalAlignment.Center);
            DocFileDanhSachThueVaoMang();
            lsvXeMay.Columns.Add("STT", 50);
            lsvXeMay.Columns.Add("Họ Và Tên", 170, HorizontalAlignment.Center);
            lsvXeMay.Columns.Add("Số CMND/ID", 150, HorizontalAlignment.Center);
            lsvXeMay.Columns.Add("Mã Số Xe", 100, HorizontalAlignment.Center);
            lsvXeMay.Columns.Add("Loại Xe", 140, HorizontalAlignment.Center);
            lsvXeMay.Columns.Add("Biển Số", 100, HorizontalAlignment.Center);
            lsvXeMay.Columns.Add("Phương Thức Thuê", 160, HorizontalAlignment.Center);
            lsvXeMay.Columns.Add("Time Start", 100, HorizontalAlignment.Center);
            lsvXeMay.Columns.Add("Ngày Thuê", 100, HorizontalAlignment.Center);
            DocFileThueXeMay();
            
        }
        private void duadulieuvaolistviewitem(ref ThueXeDap xedap, ref ListViewItem lsvitem)
        {
            // đưa dữ liệu vào vào 1 dòng chính là listviewitem , xem listviewitem như một mảng một chiều
            lsvitem.SubItems.Add(xedap.HOVATEN); // thêm vào cột 2
            lsvitem.SubItems.Add(xedap.SOCMND);
            lsvitem.SubItems.Add(xedap.MASOXE);
            lsvitem.SubItems.Add(xedap.PHUONGTHUCTHUE);
            lsvitem.SubItems.Add(xedap.TIMESTART.ToString("h:mm tt"));
            lsvitem.SubItems.Add(xedap.TIMESTART.ToString("dd/MM/yyyy"));
        }
        int STT = 0;
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
                lsvXeDap.Items.Add(item);
            }
            DocFile.Close();
        }
        int STT2 = 0;
        private void DuaDuLieuVaoListViewItem(ThueXeMay xemay, out ListViewItem lsvitem)
        {
            STT2++;
            lsvitem = new ListViewItem(STT2.ToString());
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
                DuaDuLieuVaoListViewItem(xemay, out lsvitem);
                lsvXeMay.Items.Add(lsvitem);
            }
            DocFile.Close();
            // đưa dữ liệu từ lớp vào listview
        }
        private void timkiem()
        {
            int soluong1 = dv.arrthuexedap.Count;
            int soluong2 = dv.arrthuexemay.Count;
            int check1 = 0; // kiểm tra có điền thông tin vào chưa
            int check2 = 0; // kiểm tra có 
            string str = txtTimKiem.Text;
            for (int i = 0; i < soluong1; ++i)
            {
                lsvXeDap.Items[i].ForeColor = Color.Black;
            }
            for (int i = 0; i < soluong2; ++i)
            {
                lsvXeMay.Items[i].ForeColor = Color.Black;
            }
            if (txtTimKiem.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải điền thông tin vào để tìm kiếm !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                check1 = 1;
            }
            if (check1 == 0)
            {
                for (int i = 0; i < soluong1; ++i)
                {
                    if (string.Compare(str, dv.arrthuexedap[i].HOVATEN, true) == 0 || string.Compare(str, dv.arrthuexedap[i].SOCMND, true) == 0 )
                    {
                        lsvXeDap.Items[i].ForeColor = Color.Red;
                        check2 = 1;
                    }
                }
                for (int i = 0; i < soluong2; ++i)
                {
                    if (string.Compare(str, dv.arrthuexemay[i].HOVATEN, true) == 0 || string.Compare(str, dv.arrthuexemay[i].SOCMND, true) == 0 )
                    {
                        lsvXeMay.Items[i].ForeColor = Color.Red;
                        check2 = 1;
                    }
                }
                if (check2 == 0)
                {
                    MessageBox.Show("Không tìm thấy người này trong danh sách ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }  
            }
            
        }
        private void btnTiemKiem_Click(object sender, EventArgs e)
        {
            timkiem();
        }
        bool checkxedap = false;
        bool checkxemay = false;
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            
            FormTinhTien ftinhtien = new FormTinhTien();
            if (checkxedap == true)
            {
                ftinhtien.hovaten = lsvXeDap.SelectedItems[0].SubItems[1].Text;
                ftinhtien.socmnd = lsvXeDap.SelectedItems[0].SubItems[2].Text;
                ftinhtien.masoxe = lsvXeDap.SelectedItems[0].SubItems[3].Text;
                ftinhtien.phuongthucthue = lsvXeDap.SelectedItems[0].SubItems[4].Text;
                ftinhtien.timestart = DateTime.Parse(lsvXeDap.SelectedItems[0].SubItems[5].Text + lsvXeDap.SelectedItems[0].SubItems[6].Text);
                ftinhtien.CheckXeDap = true;
            }
            if (checkxemay == true)
            {
                ftinhtien.hovaten = lsvXeMay.SelectedItems[0].SubItems[1].Text;
                ftinhtien.socmnd = lsvXeMay.SelectedItems[0].SubItems[2].Text;
                ftinhtien.masoxe = lsvXeMay.SelectedItems[0].SubItems[3].Text;
                ftinhtien.phuongthucthue = lsvXeMay.SelectedItems[0].SubItems[6].Text;
                ftinhtien.timestart = DateTime.Parse(lsvXeMay.SelectedItems[0].SubItems[7].Text + lsvXeMay.SelectedItems[0].SubItems[8].Text);
                ftinhtien.CheckXeMay = true;
               
            }
            if (checkxedap == false && checkxemay == false)
            {
                MessageBox.Show("Bạn phải chọn người để thanh toán", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Hide();
                ftinhtien.ShowDialog();
                checkxedap = false;
                checkxemay = false;
                this.Show();
            }
        }

        private void lsvXeDap_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkxedap = true;
        }

        private void lsvXeMay_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkxemay = true;
        }
    }
}
