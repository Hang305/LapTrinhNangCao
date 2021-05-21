using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;



namespace BanHang
{
   public class NhomHang
    {
        string [ ] name = { };
        object [ ] value = { };

     
        public string TenNhomHang{ get; set; }
        public  ThuongHieu thuonghieu { get; set; }

        public DataTable select_NhomHang()
        {
            return connectDB.Instance.select_sql("selectNhomHang");
        }

       

    }
}
