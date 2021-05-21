using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Data;
using System.IO;

namespace BanHang
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        NhomHang nh = new NhomHang();
        ThuongHieu th = new ThuongHieu();
        LoaiSanPham lsp = new LoaiSanPham();
        //SanPham sp = new SanPham();
        //Image hinhanh = new Image();
        //SanPham [ ] sp;
        DataTable ctsp;
  
        private void FormMain_Load(object sender, EventArgs e)
        {
            cbNhomHang.DataSource = nh.select_NhomHang();
            cbNhomHang.DisplayMember = "name";
            cbNhomHang.ValueMember = "id_nhomhang";
        }

        private void cbNhomHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbThuongHieu.DataSource = th.select_ThuongHieu(cbNhomHang.SelectedValue.ToString());
            cbThuongHieu.DisplayMember = "name";
            cbThuongHieu.ValueMember = "id_thuonghieu";
        }

        private void cbThuongHieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbLoaiSanPham.DataSource = lsp.select_LoaiSanPham(cbThuongHieu.SelectedValue.ToString());
            cbLoaiSanPham.DisplayMember = "name";
            cbLoaiSanPham.ValueMember = "id_loaisanpham";
        }

        private void cbLoaiSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewSP.DataSource = select_SanPham(cbLoaiSanPham.SelectedValue.ToString());
            dataGridViewSP.Columns [ 0 ].Visible = true;
            dataGridViewSP.AutoResizeColumns();
        }

        private void dataGridViewSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int cell_sp = e.RowIndex;
            string masp = dataGridViewSP [ 0, cell_sp ].Value.ToString();
           
            lbTenSP.Text = getName(masp);
            lbmanhinh.Text = getManHinh(masp);
            lbcpu.Text = getCPU(masp);
            lbcard.Text = getCard(masp);
            lbGia.Text = getGia(masp);

            pictureBoxSP.Image = new Bitmap(ByteToImage(getImage(masp)));
            pictureBoxSP.SizeMode = PictureBoxSizeMode.Zoom;
        }

        public static Bitmap ByteToImage(byte [ ] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte [ ] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }
       
        private byte[] getImage(string masp)
        {
            return (byte [])Image.Instance.getImage(masp);
        }
        private string getName(string mapsp)
        {
            return ( string )SanPham.Instance.getName(mapsp);
        }
        private string getManHinh(string mapsp)
        {
            return ( string )SanPham.Instance.getManhinh(mapsp);
        }
        private string getCPU(string mapsp)
        {
            return ( string )SanPham.Instance.getCPU(mapsp);
        }
        private string getCard(string mapsp)
        {
            return ( string )SanPham.Instance.getCard(mapsp);
        }
        private string getGia(string mapsp)
        {
            return ( string )SanPham.Instance.getGia(mapsp);
        }
        private DataTable select_SanPham(string mapsp)
        {
            return SanPham.Instance.select_SanPham(mapsp);
        }
       
    }
}
