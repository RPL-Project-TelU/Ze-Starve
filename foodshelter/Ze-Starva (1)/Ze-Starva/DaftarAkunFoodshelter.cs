using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Ze_Starve
{
    public partial class DaftarAkunFoodshelter : Form
    {
        // API koneksi database.
        KoneksiDatabase db = new KoneksiDatabase();

        public DaftarAkunFoodshelter()
        {
            InitializeComponent();
        }

        // Method untuk unggah foto.
        private void LinkUnggahFotoLogoFoodshelter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Membuat objek OpenFileDialog.
            OpenFileDialog opf = new OpenFileDialog();
            // Menentukan format image yang bisa digunakan.
            opf.Filter = "Choose Image(*.jpg; *.png)|*.jpg; *.png";
            // Kondisi 1 : jika image berhasil di unggah.
            if (opf.ShowDialog() == DialogResult.OK)
            {
                // Menampilkan image pada picture box.
                PictureLogoFoodshelter.Image = Image.FromFile(opf.FileName);
            }
            // Kondisi 2 : Jika image gagal di ungggah.
            else
            {
                // Teknik defensive programming error message.
                MessageBox.Show("Foto logo foodshelter gagal di unggah!");
            }
        }

        // Method untuk unggah foto.
        private void LinkUnggahFotoBukuTabungan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Membuat objek OpenFileDialog.
            OpenFileDialog opf = new OpenFileDialog();
            // Menentukan format image yang bisa digunakan.
            opf.Filter = "Choose Image(*.jpg; *.png)|*.jpg; *.png";
            // Kondisi : jika image berhasil di unggah.
            if (opf.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Foto buku tabungan berhasil di unggah!");
            }
            // Kondisi 2 : Jika image gagal di ungggah.
            else
            {
                MessageBox.Show("Foto buku tabungan gagal di unggah!");
            }
        }

        // Method untuk unggah foto.
        private void LinkUnggahFotoKtp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Membuat objek OpenFileDialog.
            OpenFileDialog opf = new OpenFileDialog();
            // Menentukan format image yang bisa digunakan.
            opf.Filter = "Choose Image(*.jpg; *.png)|*.jpg; *.png";
            // Kondisi 1 : jika image berhasil di unggah.
            if (opf.ShowDialog() == DialogResult.OK)
            {
                // Teknik automata-based error message.
                MessageBox.Show("Foto ktp berhasil di unggah!");
            }
            // Kondisi 2 : Jika image gagal di ungggah.
            else
            {
                // Teknik  automata-based programming error message.
                MessageBox.Show("Foto ktp gagal di unggah!");
            }
        }

        // Method insert().
        public void Insert()
        {
            // Mengconvert image agar bisa dimasukan ke database.
            MemoryStream ms = new MemoryStream();
            byte[] ImgLogoFoodShelter = ms.ToArray();
            byte[] ImgBukuTabungan = ms.ToArray();
            byte[] ImgKtp = ms.ToArray();

            // API menambahkan data baru ke tabel penggunafoodshelter pada database.
            MySqlCommand command = new MySqlCommand("INSERT INTO penggunafoodshelter (NamaDepan, NamaBelakang, Username, Password, NamaFS, NoTelpFS, AlamatFS, " +
                "NoRekeningFS, DeskripsiFS, FotoLogoFS, FotoBukuTabungan, FotoKtp) VALUES (NamaDepan, NamaBelakang, @Username, @Password, @NamaFS, @NoTelpFS, " +
                "@AlamatFS, @NoRekeningFS, @DeskripsiFS, @FotoLogoFS, @FotoBukuTabungan, @FotoKtp)", db.GetConnection());
            // API menentukan nama parameter dan nilainya.
            command.Parameters.Add("NamaDepan", MySqlDbType.VarChar).Value = TxtNamaDepan.Text;
            command.Parameters.Add("NamaBelakang", MySqlDbType.VarChar).Value = TxtNamaBelakang.Text;
            command.Parameters.Add("Username", MySqlDbType.VarChar).Value = TxtUsername.Text;
            command.Parameters.Add("Password", MySqlDbType.VarChar).Value = TxtPassword.Text;
            command.Parameters.Add("NamaFS", MySqlDbType.VarChar).Value = TxtNamaFoodshelter.Text;
            command.Parameters.Add("NoTelpFS", MySqlDbType.VarChar).Value = TxtNoTelpFoodshelter.Text;
            command.Parameters.Add("AlamatFS", MySqlDbType.VarChar).Value = TxtAlamatFoodshelter.Text;
            command.Parameters.Add("NoRekeningFS", MySqlDbType.VarChar).Value = TxtNoRekeningFoodshelter.Text;
            command.Parameters.Add("DeskripsiFS", MySqlDbType.VarChar).Value = TxtDeskripsiFoodshelter.Text;
            command.Parameters.Add("FotoLogoFS", MySqlDbType.VarChar).Value = ImgLogoFoodShelter;
            command.Parameters.Add("FotoBukuTabungan", MySqlDbType.VarChar).Value = ImgBukuTabungan;
            command.Parameters.Add("FotoKtp", MySqlDbType.VarChar).Value = ImgKtp;
            // API buka koneksi.
            db.OpenConnection();
            // Kondisi 1 : teknik automata-based programming untuk cek data sudah terisi dengan benar atau belum.
            if (CekNamaDepan() || CekNamaBelakang() || CekUsername() || CekPassword() || CekNamaFS() || CekNoTelpFS() || CekAlamatFS() ||
                CekNoRekFS() || CekDesFS())
            {
                // Teknik  automata-based error message.
                MessageBox.Show("Pastikan data telah diisi dengan benar!");
            }
            // Kondisi 2 : teknik automata-based programming untuk cek jika data masih ada yang kosong.
            else if (TxtNamaDepan.Text.Equals("") || TxtNamaBelakang.Text.Equals("") || TxtUsername.Text.Equals("") || TxtPassword.Text.Equals("") ||
                TxtConfirmPassword.Text.Equals("") || TxtNamaFoodshelter.Text.Equals("") || TxtNoTelpFoodshelter.Text.Equals("") || TxtAlamatFoodshelter.Text.Equals("") ||
                TxtNoRekeningFoodshelter.Text.Equals("") || TxtDeskripsiFoodshelter.Text.Equals(""))
            {
                // Teknik automata-based programming error message.
                MessageBox.Show("Data masih ada yang kosong!");
            }
            // Kondisi 3
            else
            {
                // Jika akun berhasil dibuat.
                if (command.ExecuteNonQuery() == 1)
                {
                    // Teknik  automata-based error message.
                    MessageBox.Show("Akun berhasil dibuat!");
                    // Menuju form HalamanUtamaFoodshelter().
                    new HalamanUtamaFoodshelter().Show();
                    this.Hide();

                }
                // Jika akun gagal dibuat.
                else
                {
                    // Teknik  automata-basederror message.
                    MessageBox.Show("Error, akun gagal dibuat!");
                }
            }
            // API close koneksi.
            db.CloseConnection();
        }

        // Mengatur button selesai untuk menyelesaikan daftar akun.
        private void BtnSelesaiDaftarAkun_Click(object sender, EventArgs e)
        {
            // Mengambil nilai dari method Insert().
            Insert();
        }


        private void DaftarAkunFoodshelter_Load(object sender, EventArgs e)
        {

        }
    }
}