using System.Data.SqlClient;

namespace LibraryManagement
{
    public partial class FormSign : Form
    {
        FormBooks formBooks;
        public FormSign()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=LibraryManagement;Integrated Security=True");

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            string sifre = "";
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT Sifre FROM Users WHERE KullaniciAdi=@p1", connection);
                cmd.Parameters.AddWithValue("@p1", textBoxKullaniciAdi.Text);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    sifre = reader[0].ToString();
                }
                if (sifre == textBoxSifre.Text)
                {
                    formBooks = new FormBooks();
                    this.Hide();
                    formBooks.Show();
                }
                else
                {
                    MessageBox.Show("Kullanýcý Adý veya Þifre Hatalý!");
                    textBoxKullaniciAdi.Text = " ";
                    textBoxSifre.Text = " ";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Baðlantý Hatasý!" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
