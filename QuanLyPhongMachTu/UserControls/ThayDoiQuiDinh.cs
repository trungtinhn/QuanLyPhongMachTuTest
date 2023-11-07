using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace QuanLyPhongMachTu.UserControls
{

    
    public partial class ThayDoiQuiDinh : UserControl
    {
        QLPMTEntities db;
        BLL_THAMSO dThamSoBLL;

        
        public ThayDoiQuiDinh()
        {
            InitializeComponent();
            db = new QLPMTEntities();
            dThamSoBLL = new BLL_THAMSO();
        }

        private void btn_Dongy_Click(object sender, EventArgs e)
        {
            
            dThamSoBLL.ThayDoiQuyDinh(Int32.Parse(txt_Tienkham.Text),Int32.Parse(txt_Sobenhnhantoida.Text), Int32.Parse(txtSoLuongThuocSapHet.Text));

            MessageBox.Show("Đã thay đổi quy định thành công!");
            THAMSO thamSo = dThamSoBLL.LayThamSo(1);
            txt_Tienkham.Text = thamSo.TienKham.ToString();
            txt_Sobenhnhantoida.Text = thamSo.SoBenhNhanToiDa.ToString();

            txtSoLuongThuocSapHet.Text = thamSo.SoLuongSapHet.ToString();
        }

        private void ThayDoiQuiDinh_Load(object sender, EventArgs e)
        {
            THAMSO thamSo = dThamSoBLL.LayThamSo(1);
            txt_Tienkham.Text = thamSo.TienKham.ToString();
            txt_Sobenhnhantoida.Text = thamSo.SoBenhNhanToiDa.ToString();
            txtSoLuongThuocSapHet.Text = thamSo.SoLuongSapHet.ToString();
        }

        
    }
}
