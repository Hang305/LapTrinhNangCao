using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cal
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        bool isTypingNumber = false;
        bool isCalculated = true;
        bool isFloatingPoint = false;
        string lbResult;
        double ketqua = 0.0;
        enum PhepToan
        {
            None, Cong, Tru, Nhan, Chia, PhanTram,
            Can, DoiDau, LuyThua, ChiaChoMot
        };
        PhepToan pheptoan = PhepToan.None;
        double nho = 0.0;

        private void NhapSo(object sender, EventArgs e)
        {
            Button btn = ( Button )sender;
            NhapSo(btn.Text);
            //txtNumber.Text = btn.Text + " ";
        }

        private void NhapSo(string so)
        {
            if ( isTypingNumber )
            {
                string text = txtBox.Text;
                txtNumber.Text += so;
                if ( !isFloatingPoint )
                    text = LaySoTuDisplayText();
                txtBox.Text = text + so;
            }
            else
            {
                txtBox.Text = so;
                txtNumber.Text += so ;
                if ( so != "0" )
                    isTypingNumber = true;
            }
            lbResult = txtNumber.Text;

            //ThemDauCham();
        }

        private void NhapPhepToan(object sender, EventArgs e)
        {
            Button btn = ( Button )sender;
            NhapPhepToan(btn.Text);
        }

        private void NhapPhepToan(string pt)
        {
            if ( !isCalculated )
            {
                TinhKetQua();
                txtNumber.Text = lbResult;
            }

            pheptoan = XacDinhPhepToan(pt);

            nho = double.Parse(txtBox.Text);

            isTypingNumber = false;
            isCalculated = false;
            isFloatingPoint = false;
        }

        private void NhapPhepToanMotNgoi(object sender, EventArgs e)
        {
            Button btn = ( Button )sender;
            NhapPhepToanMotNgoi(btn.Text);
        }

        private void NhapPhepToanMotNgoi(string pt)
        {
            pheptoan = XacDinhPhepToan(pt);

            TinhKetQua();
            txtNumber.Text = lbResult;

            isTypingNumber = false;
            isFloatingPoint = false;
        }

        private PhepToan XacDinhPhepToan(string pt)
        {
            switch ( pt )
            {
                case "+": return PhepToan.Cong;
                case "-": return PhepToan.Tru;
                case "*": return PhepToan.Nhan;
                case "/": return PhepToan.Chia;
                case "%": return PhepToan.PhanTram;
                case "√": return PhepToan.Can;
                case "-/+": return PhepToan.DoiDau;
                case "^": return PhepToan.LuyThua;
                case "1/x": return PhepToan.ChiaChoMot;

                default: return PhepToan.None;
            }
        }

        private void TinhKetQua()
        {
            // tinh toan dua tren: nho, pheptoan, txtBox.Text
            double tam = double.Parse(LaySoTuDisplayText());
             ketqua = 0.0;
            switch ( pheptoan )
            {
                case PhepToan.Cong: ketqua = nho + tam; break;
                case PhepToan.Tru: ketqua = nho - tam; break;
                case PhepToan.Nhan: ketqua = nho * tam; break;
                case PhepToan.Chia: ketqua = nho / tam; break;
                case PhepToan.PhanTram: ketqua = tam / 100; break;
                case PhepToan.Can: ketqua = Math.Sqrt(tam); break;
                case PhepToan.DoiDau: ketqua = -1 * tam; break;
                case PhepToan.LuyThua: ketqua = Math.Pow(tam,2); break;
                case PhepToan.ChiaChoMot: ketqua = 1/ tam; break;

            }

            // gan ket qua tinh duoc len txtBox
            txtBox.Text = ketqua.ToString();
            lbResult = ketqua.ToString();

           
            //ThemDauCham();
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            if ( !isCalculated )
            {
                TinhKetQua();
                txtNumber.Text = ketqua.ToString() ;
                lbResult = txtNumber.Text;
                txtNumber.Text = "";
            }
            Clear();

            //txtNumber.Text = "";
        }

        private void Clear()
        {
            isTypingNumber = false;
            nho = 0;
            pheptoan = PhepToan.None;
            isCalculated = true;
            isFloatingPoint = false;
        }

        private void frmMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch ( e.KeyChar )
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    NhapSo("" + e.KeyChar);

                    break;
                case '+':
                case '-':
                case '*':
                case '/':
                    NhapPhepToan("" + e.KeyChar);
                    break;
                case '%':
                    NhapPhepToanMotNgoi("" + e.KeyChar);
                    break;
                case '=':
                    btnBang.PerformClick();
                    break;
                default:
                    break;
            }
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            btnBang.Focus();
            frmMain_KeyDown1(sender, e);

             if ( e.KeyData == Keys.Enter )
            {
                btnBang.PerformClick();

                //lbResult = txtNumber.Text;
                txtNumber.Text = lbResult;


            }

        }

        private void frmMain_KeyDown1(object sender, KeyEventArgs e) {
            if ( e.KeyData == Keys.Add )
            {
                pheptoan = XacDinhPhepToan("+");
                btnBang_Click(sender, e);
                txtNumber.Text =  lbResult + " + ";
               

            }
            else if ( e.KeyData == Keys.Multiply )
            {
                pheptoan = XacDinhPhepToan("*");
                btnBang_Click(sender, e);
                txtNumber.Text = lbResult + " * ";
            }
            else if ( e.KeyData == Keys.Divide )
            {
                pheptoan = XacDinhPhepToan("/");
                btnBang_Click(sender, e);
                txtNumber.Text = lbResult + " / ";
            }
            else if ( e.KeyData == Keys.Subtract )
            {
                pheptoan = XacDinhPhepToan("-");
                btnBang_Click(sender, e);
                txtNumber.Text = lbResult + " - ";
            }
            //lbResult += txtNumber.Text;
        }
        //Nhấn C
        private void btnNho_Click(object sender, EventArgs e)
        {
            string text = txtBox.Text;

            if ( text.Length == 1 )
                txtBox.Text = "0";
            else
                txtBox.Text = text.Remove(text.Length - 1);
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtBox.Text = "0";
            Clear();
        }

        private void btnThapPhan_Click(object sender, EventArgs e)
        {
            isFloatingPoint = true;
        }

        private void ThemDauCham()
        {
            if ( !isFloatingPoint || !txtBox.Text.Contains(".") )
                txtBox.Text = txtBox.Text + ".";
        }

        private string LaySoTuDisplayText()
        {
            string text = txtBox.Text;
            int lastIndex = text.Length - 1;

            if ( text [ lastIndex ] == '.' )
                text = text.Remove(lastIndex);

            return text;
        }

       
    }
}
