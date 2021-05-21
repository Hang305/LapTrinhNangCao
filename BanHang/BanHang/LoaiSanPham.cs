using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BanHang
{
   public class LoaiSanPham
    {
        string [ ] name = { };
        object [ ] value = { };
        private static LoaiSanPham instance;
        
        public DataTable select_LoaiSanPham(string mathuonghieu)
        {
            name = new string [ 1 ];
            value = new object [ 1 ];

            name [ 0 ] = "@idthuonghieu"; value [ 0 ] = mathuonghieu;
            return connectDB.Instance.selectWhere_sql("selectLoaiSanPham", name, value, 1);
        }
        public static LoaiSanPham Instance
        {
            get { if ( instance == null ) instance = new LoaiSanPham(); return instance; }
            private set => instance = value;
        }
    }
}
