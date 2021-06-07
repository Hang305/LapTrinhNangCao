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
        public DataTable selectFull_SanPham(string idsp)
        {
            name = new string [ 1 ];
            value = new object [ 1 ];

            name [ 0 ] = "@idloaisanpham"; value [ 0 ] = idsp;
            return connectDB.Instance.selectWhere_sql("selectFullSanPham", name, value, 1);
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

        //insert sản phẩm
        public bool InsertSP(string id, string loaisp, string nameSP, string manhinh, string cpu, string card, float giatien)
        {
            name = new string [ 7 ];
            value = new object [ 7 ];

            name [ 0 ] = "@idSP"; value [ 0 ] = id;
            name [ 1 ] = "@id_loaisanpham"; value [ 1 ] = loaisp;
            name [ 2 ] = "@name"; value [ 2 ] = nameSP;
            name [ 3 ] = "@manhinh"; value [ 3 ] = manhinh;
            name [ 4 ] = "@cpu"; value [ 4 ] = cpu;
            name [ 5 ] = "@card"; value [ 5 ] = card;
            name [ 6 ] = "@gia"; value [ 6 ] = giatien;

            int count = connectDB.Instance.ThucHien_sql("insertSanPham", name, value, 7);
            return count > 0;
        }
        //update sản phẩm
        public bool UpdateSP(string id, string loaisp, string nameSP, string manhinh, string cpu, string card, float giatien)
        {
            name = new string [ 7 ];
            value = new object [ 7 ];

            name [ 0 ] = "@idSP"; value [ 0 ] = id;
            name [ 1 ] = "@id_loaisanpham"; value [ 1 ] = loaisp;
            name [ 2 ] = "@name"; value [ 2 ] = nameSP;
            name [ 3 ] = "@manhinh"; value [ 3 ] = manhinh;
            name [ 4 ] = "@cpu"; value [ 4 ] = cpu;
            name [ 5 ] = "@card"; value [ 5 ] = card;
            name [ 6 ] = "@gia"; value [ 6 ] = giatien;

            int count = connectDB.Instance.ThucHien_sql("UpdateSanPham", name, value, 7);
            return count > 0;
        }
        //delete sản phẩm
        public bool deleteSP(string id)
        {
            name = new string [ 1 ];
            value = new object [ 1 ];

            name [ 0 ] = "@idSP"; value [ 0 ] = id;

            int count = connectDB.Instance.ThucHien_sql("deleteSanPham", name, value, 1);
            return count > 0;
        }
        //Mã lớn nhất
        private string selectMaMax(string Bang, string Ma)
        {
            name = new string [ 2 ];
            value = new object [ 2 ];

            name [ 0 ] = "@Bang"; value [ 0 ] = Bang;
            name [ 1 ] = "@Ma"; value [ 1 ] = Ma;
            return connectDB.Instance.selectMaMax_sql("LayMaLonNhat", name, value, 2);
        }
        public string Actomatic_Ma(string Bang, string Ma)
        {
            string MaCu, MaMoi;
            MaCu = selectMaMax(Bang, Ma);
            string TienTo;
            int HauTo;
            TienTo = MaCu.Substring(0, 2);
            HauTo = int.Parse(MaCu.Substring(2).ToString());
            HauTo++;
            if ( HauTo < 10 )
            {
                MaMoi = string.Concat(TienTo, "00", HauTo.ToString());
            }
            else
            {
                if ( HauTo < 100 )
                {
                    MaMoi = string.Concat(TienTo, "0", HauTo.ToString());

                }
                else
                {
                    MaMoi = string.Concat(TienTo, HauTo.ToString());
                }
            }
            return MaMoi;
        }
        public static SanPham Instance
        {
            get { if ( instance == null ) instance = new SanPham(); return instance; }
            private set => instance = value;
        }


    }

}
