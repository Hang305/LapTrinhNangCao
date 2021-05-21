using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace BanHang
{
  public  class Image
    {
        string [ ] name = { };
        object [ ] value = { };

        private static Image instance;

        public static Image Instance
        {
            get { if ( instance == null ) instance = new Image(); return instance; }
            private set => instance = value;
        }
        public byte [] getImage(string idsp)
        {
            name = new string [ 1 ];
            value = new object [ 1 ];

            name [ 0 ] = "@idsp"; value [ 0 ] = idsp;
            DataRow dataRow = connectDB.Instance.selectWhere_sql("selectWhereImage", name, value, 1).Rows [ 0 ];
            return (byte []) dataRow [ "data" ];
        }
        public DataTable selectwhereImage(string masp)
        {
            name = new string [ 1 ];
            value = new object [ 1 ];

            name [ 0 ] = "@idsp"; value [ 0 ] = masp;
            return connectDB.Instance.selectWhere_sql("selectImage", name, value, 1);
        }
        public DataTable selectImage()
        {
            return connectDB.Instance.select_sql("selectWhereImage");
        }

        internal static System.Drawing.Image FromStream(MemoryStream stream)
        {
            throw new NotImplementedException();
        }
    }
}
