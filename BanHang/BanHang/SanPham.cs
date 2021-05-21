using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BanHang
{
    public class SanPham
    {

        string [ ] name = { };
        object [ ] value = { };
        private static SanPham instance;
       
        public DataTable select_SanPham(string idsp)
        {
            name = new string [ 1 ];
            value = new object [ 1 ];

            name [ 0 ] = "@idloaisanpham"; value [ 0 ] = idsp;
            return connectDB.Instance.selectWhere_sql("selectSanPham", name, value, 1);
        }
        public string getName(string idsp)
        {
            name = new string [ 1 ];
            value = new object [ 1 ];

            name [ 0 ] = "@idsp"; value [ 0 ] = idsp;
            DataRow dataRow = connectDB.Instance.selectWhere_sql("getName", name, value, 1).Rows [ 0 ];
            return dataRow [ "Tên sản phẩm" ].ToString();
        }
        public string getManhinh(string idsp)
        {
            name = new string [ 1 ];
            value = new object [ 1 ];

            name [ 0 ] = "@idsp"; value [ 0 ] = idsp;
            DataRow dataRow = connectDB.Instance.selectWhere_sql("getManhinh", name, value, 1).Rows [ 0 ];
            return dataRow [ "manhinh" ].ToString();
        }
        public string getCPU(string idsp)
        {
            name = new string [ 1 ];
            value = new object [ 1 ];

            name [ 0 ] = "@idsp"; value [ 0 ] = idsp;
            DataRow dataRow = connectDB.Instance.selectWhere_sql("getcpu", name, value, 1).Rows [ 0 ];
            return dataRow [ "cpu" ].ToString();
        }
        public string getCard(string idsp)
        {
            name = new string [ 1 ];
            value = new object [ 1 ];

            name [ 0 ] = "@idsp"; value [ 0 ] = idsp;
            DataRow dataRow = connectDB.Instance.selectWhere_sql("getcard", name, value, 1).Rows [ 0 ];
            return dataRow [ "carddohoa" ].ToString();
        }
        public string getGia(string idsp)
        {
            name = new string [ 1 ];
            value = new object [ 1 ];

            name [ 0 ] = "@idsp"; value [ 0 ] = idsp;
            DataRow dataRow = connectDB.Instance.selectWhere_sql("getGia", name, value, 1).Rows [ 0 ];
            return dataRow [ "giatien" ].ToString();
        }

        public static SanPham Instance
        {
            get { if ( instance == null ) instance = new SanPham(); return instance; }
            private set => instance = value;
        }


    }

}
