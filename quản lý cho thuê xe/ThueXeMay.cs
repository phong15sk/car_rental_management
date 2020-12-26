using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quản_lý_cho_thuê_xe
{
    // thuê xe máy là con của lớp cha là thông tin
    class ThueXeMay : ThongTin
    {
        private string Loaixe;
        private string BienSoXe;
        public string LOAIXE
        {
            get { return Loaixe;}
            set { Loaixe = value;}
        }
        public string BIENSOXE
        {
            get { return BienSoXe; }
            set { BienSoXe = value; }
        }
        // hàm khởi tạo mặt định
        public ThueXeMay()
        {
            base.HoVaTen = "0";
            base.MaSoXe = "0";
            base.PhuongThucThue = "0";
            base.SoCMND = "0";
            base.timestart = DateTime.Now;
            Loaixe = "0";
            BienSoXe = "0";
        }  
        // Hàm khởi tạo có tham số truyền vào
        public ThueXeMay(string Ten, string socmnd, string maso, string loaixe, string bienso, string phuongthuc, DateTime time)
        {
            base.HoVaTen = Ten;
            base.MaSoXe = maso;
            base.PhuongThucThue = phuongthuc;
            base.SoCMND = socmnd;
            base.timestart = time;
            Loaixe = loaixe;
            BienSoXe = bienso;
        }
    }
}
