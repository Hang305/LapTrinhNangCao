using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace BanHang
{
   public class connectDB
    {
        SqlConnection getConnect;
        DataTable dt;
        SqlDataAdapter data;
        SqlCommand cmd;
        private static connectDB instance;
        //getConnect SQL
        private void getConnectData()
        {
            getConnect = new SqlConnection(@"Data Source=SUNSHINE\SUN;Initial Catalog=BanHang;Integrated Security=True");
            getConnect.Open();

        }
        //closeConnect SQL
        private void closeConnectData()
        {
            getConnect.Close();
            getConnect.Dispose();
        }
        public DataTable select_sql(string sql)
        {
            getConnectData();
            //thực thi lấy dữ liệu từ CSDL
            cmd = new SqlCommand(sql, getConnect);
            cmd.CommandType = CommandType.StoredProcedure;
            data = new SqlDataAdapter(cmd);
            dt = new DataTable();
            data.Fill(dt);

            closeConnectData();
            return dt;
        }
        //selectWhere
        public DataTable selectWhere_sql(string sql, string [ ] name, object [ ] value, int Npara)
        {
            getConnectData();
            //thực thi lấy dữ liệu từ CSDL
            cmd = new SqlCommand(sql, getConnect);
            cmd.CommandType = CommandType.StoredProcedure;
            for ( int i = 0 ; i < Npara ; i++ )
            {
                cmd.Parameters.AddWithValue(name [ i ], value [ i ]);
            }
            data = new SqlDataAdapter(cmd);
            dt = new DataTable();
            data.Fill(dt);

            closeConnectData();
            return dt;
        }
        
        //Insert, Update, Delete
        public int ThucHien_sql(string sql, string [ ] name, object [ ] value, int Npara)
        {
            getConnectData();
            //thực thi lấy dữ liệu từ CSDL
            cmd = new SqlCommand(sql, getConnect);
            cmd.CommandType = CommandType.StoredProcedure;
            for ( int i = 0 ; i < Npara ; i++ )
            {
                cmd.Parameters.AddWithValue(name [ i ], value [ i ]);
            }
            return cmd.ExecuteNonQuery();
        }
     
        public string selectMaMax_sql(string sql, string [ ] name, object [ ] value, int Npara)
        {
            getConnectData();
            //thực thi lấy dữ liệu từ CSDL
            cmd = new SqlCommand(sql, getConnect);
            cmd.CommandType = CommandType.StoredProcedure;
            for ( int i = 0 ; i < Npara ; i++ )
            {
                cmd.Parameters.AddWithValue(name [ i ], value [ i ]);
            }
            data = new SqlDataAdapter(cmd);
            dt = new DataTable();
            data.Fill(dt);
            string maMax = dt.Rows [ 0 ] [ 0 ].ToString();
            closeConnectData();
            return maMax;
        }
        //selectSQL

        public object ExecuteScalar(string sql)
        {
            object data = new object();
            getConnectData();
            cmd = new SqlCommand(sql, getConnect);
           
            data = cmd.ExecuteScalar();
            closeConnectData();

            return data;
        }

        public byte[] ExecuteScalar_Image(string sql)
        {
          
            getConnectData();
            cmd = new SqlCommand(sql, getConnect);
          
            byte [ ] image = ( byte [ ] )cmd.ExecuteScalar();
            closeConnectData();

            return image;
        }



        public static connectDB Instance
        {
            get { if ( instance == null ) instance = new connectDB(); return instance; }
            private set => instance = value;
        }
        private connectDB() { }
    }
   

}
