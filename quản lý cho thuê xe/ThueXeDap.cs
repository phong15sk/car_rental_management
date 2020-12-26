using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quản_lý_cho_thuê_xe
{
    public class ThueXeDap : ThongTin
    {
        //Hàm khởi tạo mặc định
        public ThueXeDap()
        {
            base.HoVaTen = "0";
            base.SoCMND = "0";
            base.PhuongThucThue = "0";
            base.MaSoXe = "0";
            base.timestart = DateTime.Now;
        }
        //Hàm Khởi tạo có tham số truyền vào
        public ThueXeDap(string hovaten, string socmnd, string phuongthucthue, string masoxe, DateTime timestart)
        {
            base.HoVaTen = hovaten;
            base.SoCMND = socmnd;
            base.PhuongThucThue = phuongthucthue;
            base.MaSoXe = masoxe;
            base.timestart = timestart;
        }
    }   
}
