using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quản_lý_cho_thuê_xe
{
    public abstract class ThongTin // để biết đây là lớp cha ta dùng public abstract
    {
        protected string HoVaTen;
        protected string SoCMND;
        protected string PhuongThucThue;
        protected string MaSoXe;
        protected DateTime timestart;
        // cơ chế get, set trong c#
        public string HOVATEN
        {
            get { return HoVaTen; }
            set { HoVaTen = value; }
        }
        public string SOCMND
        {
            get { return SoCMND; }
            set { SoCMND = value; }
        }
        public string PHUONGTHUCTHUE
        {
            get { return PhuongThucThue; }
            set { PhuongThucThue = value; }
        }
        public string MASOXE
        {
            get { return MaSoXe; }
            set { MaSoXe = value; }
        }
        public DateTime TIMESTART
        {
            get { return timestart; }
            set { timestart = value; }
        }
        // lấy ra khoảng thời gian cho thuê xe
        //public TimeSpan SoGioThue()
        //{
        //    TimeSpan interval = DateTime.Now.Subtract(timestart);
        //    return interval;
        //}
    }
}
