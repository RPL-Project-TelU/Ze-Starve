using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalamanUtamaDonatur
{
    public partial class HalamanUtamaDonatur : Form
    {
        public HalamanUtamaDonatur()
        {
            InitializeComponent();
        }

        private void BtnTambahAktivitas_Click(object sender, EventArgs e)
        {
            // Menuju form TambahAktivitasDonatur.
            new TambahAktivitasDonatur().Show();
            this.Hide();
        }

        private void BtnAktivitasFoodshelter_Click(object sender, EventArgs e)
        {
            // Menuju form AktivitasDonatur.
            new AktivitasDonatur().Show();
            this.Hide();
        }

        private void BtnEditAkun_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            // Menuju form LoginForm.
            new LoginForm().Show();
            this.Hide();
        }
    }
}
