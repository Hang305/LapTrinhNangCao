using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace BanHang
{
   public class ThuongHieu
    {
        string [ ] name = { };
        object [ ] value = { };
 
        public DataTable select_ThuongHieu(string manhomhang)
        {
            name = new string [ 1 ];
            value = new object [ 1 ];

            name [ 0 ] = "@idnhomhang"; value [ 0 ] = manhomhang;
            return connectDB.Instance.selectWhere_sql("selectThuongHieu", name, value, 1);
        }
        
    }
}
