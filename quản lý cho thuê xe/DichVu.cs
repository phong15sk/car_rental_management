using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quản_lý_cho_thuê_xe
{
    class DichVu
    {
       public List<ThueXeDap> arrthuexedap = new List<ThueXeDap>();
       public string[] arrrmaxedap;
       public List<ThueXeMay> arrthuexemay = new List<ThueXeMay>();
       public string[,] arrthongtinxemay;  // mảng 2 chiều
       public double giathuexedap;
       public double giathuexemay;
       public double Giamgiaxedap;
       public double Giamgiaxemay;
      // public string[] arrmaoto;
    }
}
