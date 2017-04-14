using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LatihanEF.Controller;
using LatihanEF.Models;

namespace LatihanEF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNim_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MahasiswaController mhsController = new MahasiswaController();
            dgv.DataSource = mhsController.RetreieveALL();
            //dgv.Columns[0].Visible = false;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            MahasiswaController mhsController = new MahasiswaController();
            MahasiswaModel model = new MahasiswaModel();
            model.Jurusan = txtJurusan.Text;
            model.Nama = txtNama.Text;
            model.NIM = txtNim.Text;
            mhsController.Save(model);

            MessageBox.Show("Sukses");
            this.txtNim.Clear();
            this.txtNama.Clear();
            this.txtJurusan.Clear();

            dgv.DataSource = mhsController.RetreieveALL();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //dgv.
            int i = dgv.CurrentRow.Index;
            string NIM = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            string Nama = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            string Jurusan = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            //MessageBox.Show(a);
            txtNim.Text = NIM;
            txtNama.Text = Nama;
            txtJurusan.Text = Jurusan;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MahasiswaController mhsController = new MahasiswaController();
            MahasiswaModel model = new MahasiswaModel();
            model.Jurusan = txtJurusan.Text;
            model.Nama = txtNama.Text;
            model.NIM = txtNim.Text;
            mhsController.Update(model);

            MessageBox.Show("Sukses Update");
            this.txtNim.Clear();
            this.txtNama.Clear();
            this.txtJurusan.Clear();

            dgv.DataSource = mhsController.RetreieveALL();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            MahasiswaController mhsController = new MahasiswaController();
            MahasiswaModel model = new MahasiswaModel();
            model.Jurusan = txtJurusan.Text;
            model.Nama = txtNama.Text;
            model.NIM = txtNim.Text;
            mhsController.Delete(model);

            MessageBox.Show("Sukses Delete");
            this.txtNim.Clear();
            this.txtNama.Clear();
            this.txtJurusan.Clear();

            dgv.DataSource = mhsController.RetreieveALL();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {

        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            MahasiswaController mhsController = new MahasiswaController();
            dgv.DataSource = mhsController.RetreieveByNim(txtCari.Text);
            //dgv.Columns[0].Visible = false;
        }
    }
}
