using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QuanLy;
using BUS_QuanLy;

namespace ThucHanh_NLayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BUS_SinhVien busSV = new BUS_SinhVien();

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "" && txtHoVaTen.Text != "" && txtSdt.Text != "")
            {
          
                DTO_SinhVien tv = new DTO_SinhVien(0, txtHoVaTen.Text, txtSdt.Text,
               txtEmail.Text); 
                if (busSV.themSinhVien(tv))
                {
                    MessageBox.Show("Thêm thành công");
                    dgvTV.DataSource = busSV.getSinhVien(); // refresh datagridview
                }
                else
                {
                    MessageBox.Show("Thêm ko thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvTV.DataSource = busSV.getSinhVien();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvTV.SelectedRows.Count > 0)
            {
                if (txtEmail.Text != "" && txtHoVaTen.Text != "" && txtSdt.Text != "")
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dgvTV.CurrentRow;
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());
                    // Tạo DTo
                    DTO_SinhVien tv = new DTO_SinhVien(ID, txtHoVaTen.Text, txtSdt.Text,
                   txtEmail.Text);
                    // Sửa
                    if (busSV.suaSinhVien(tv))
                    {
                        MessageBox.Show("Sửa thành công");
                        dgvTV.DataSource = busSV.getSinhVien(); // refresh datagridview
                    }
                    else
                    {
                        MessageBox.Show("Sửa ko thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn sửa");
            }


        }

        private void dgvTV_Click(object sender, EventArgs e)
        {
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có chọn table rồi
            if (dgvTV.CurrentRow !=  null)
            {
                // Lấy row hiện tại
                DataGridViewRow row = dgvTV.CurrentRow;
                int ID = Convert.ToInt16(row.Cells[0].Value.ToString());
                // Xóa
                
                if (busSV.xoaSinhVien(ID))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvTV.DataSource = busSV.getSinhVien(); // refresh datagridview
                }
                else
                {
                    MessageBox.Show("Xóa ko thành công");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn xóa");
            }

        }

        private void dgvTV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dtgv = (DataGridView)sender;
            txtHoVaTen.Text = dtgv.CurrentRow.Cells[1].Value.ToString();
            txtSdt.Text = dtgv.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = dtgv.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
