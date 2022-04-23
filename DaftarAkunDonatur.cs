using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Ze_Starve
{
    public partial class DaftarAkunDonatur : Form
    {
        public DaftarAkunDonatur()
        {
            InitializeComponent();
        }
        public class errorMessage
        {
            public string fieldKosong { get; set; }
            public string errConfirmPass { get; set; }
        }
        KoneksiDatabase db = new KoneksiDatabase();

        private void TxtNamaDepan_TextChanged(object sender, System.EventArgs e)
        {
            
        }

        private void TxtNamaBelakang_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void TxtUsername_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void TxtPassword_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void TxtConfirmPassword_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void TxtNoTelp_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void TxtAlamat_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void BtnSelesaiDaftarAkun_Click(object sender, System.EventArgs e)
        {
            using (StreamReader r = new StreamReader("message.json"))
            {
                string json = r.ReadToEnd();
                errorMessage msg = JsonConvert.DeserializeObject<errorMessage>(json);

                string namaDepan = TxtNamaDepan.Text;
                string namaBelakang = TxtNamaBelakang.Text;
                string username = TxtUsername.Text;
                string password = TxtPassword.Text;
                string confirmPass = TxtConfirmPassword.Text;
                string noTelp = TxtNoTelp.Text;
                string alamat = TxtAlamat.Text;

                try
                {
                    // Menambahkan data baru ke tabel penggunafoodshelter pada database.
                    MySqlCommand command = new MySqlCommand("INSERT INTO akunDonatur (NamaDepan, NamaBelakang, Username, Password, NoTelp, Alamat " +
                        "VALUES (NamaDepan, NamaBelakang, @Username, @Password, @NoTelp, " +
                        "@Alamat)", db.GetConnection());
                    // Menentukan nama parameter dan nilainya.
                    command.Parameters.Add("NamaDepan", MySqlDbType.VarChar).Value = namaDepan;
                    command.Parameters.Add("NamaBelakang", MySqlDbType.VarChar).Value = namaBelakang;
                    command.Parameters.Add("Username", MySqlDbType.VarChar).Value = username;
                    command.Parameters.Add("Password", MySqlDbType.VarChar).Value = confirmPass;
                    command.Parameters.Add("NoTelp", MySqlDbType.VarChar).Value = noTelp;
                    command.Parameters.Add("Alamat", MySqlDbType.VarChar).Value = alamat;
                    // Buka koneksi.
                    db.OpenConnection();
                } catch (MySqlException)
                {
                    MessageBox.Show("Error koneksi ke Database");
                }

                if (namaDepan == "")
                {
                    label1.Text = msg.fieldKosong; //Parsing JSON oleh Muhammad Fauzi Dwikurnia
                }
                if (namaBelakang == "")
                {
                    label2.Text = msg.fieldKosong; //Parsing JSON oleh Muhammad Fauzi Dwikurnia
                }
                if (username == "")
                {
                    label3.Text = msg.fieldKosong; //Parsing JSON oleh Muhammad Fauzi Dwikurnia
                }
                if (password == "")
                {
                    label4.Text = msg.fieldKosong; //Parsing JSON oleh Muhammad Fauzi Dwikurnia
                }
                if (confirmPass == "")
                {
                    label5.Text = msg.fieldKosong; //Parsing JSON oleh Muhammad Fauzi Dwikurnia
                }
                if (noTelp == "")
                {
                    label6.Text = msg.fieldKosong; //Parsing JSON oleh Muhammad Fauzi Dwikurnia
                }
                if (alamat == "")
                {
                    label7.Text = msg.fieldKosong; //Parsing JSON oleh Muhammad Fauzi Dwikurnia
                }

                if (password != confirmPass)
                {
                    label5.Text = msg.errConfirmPass; //Parsing JSON oleh Muhammad Fauzi Dwikurnia
                }
            }
        }

        private void BtnKembali_Click(object sender, System.EventArgs e)
        {
            
        }

        private void LblNoTelpFoodshelter_Click(object sender, System.EventArgs e)
        {

        }

    }
}
