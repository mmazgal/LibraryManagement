using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class FormBooks : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=LibraryManagement;Integrated Security=True");


        public FormBooks()
        {
            InitializeComponent();
        }

        private void verileriGoster()
        {
            try
            {
                string query = "SELECT * FROM BOOKS";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridViewKitaplar.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormBooks_Load(object sender, EventArgs e)
        {
            verileriGoster();
        }

        private void buttonKitapEkle_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO BOOKS (KitapAdi,YazarAdi,YazarSoyadi,ISBN,Durum,KitapTurKodu) VALUES (@P1,@P2,@P3,@P4,@P5,@P6)", connection);
                cmd.Parameters.AddWithValue("@P1", textBoxKitapAdi.Text);
                cmd.Parameters.AddWithValue("@P2", textBoxYazarAdi.Text);
                cmd.Parameters.AddWithValue("@P3", textBoxYazarSoyad.Text);
                cmd.Parameters.AddWithValue("@P4", textBoxISBN.Text);
                cmd.Parameters.AddWithValue("@P5", "True");
                cmd.Parameters.AddWithValue("@P6", textBoxKitapTurKodu.Text);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitap Eklenirken hata oluştu !", ex.Message);
            }
            finally
            {
                connection.Close();
            }
            verileriGoster();
        }

        private void dataGridViewKitaplar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            labelGecikmeBedeli.Text = "0";
            int secilenSatir = dataGridViewKitaplar.SelectedCells[0].RowIndex;
            labelID.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[0].Value.ToString();
            textBoxKitapAdi.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[1].Value.ToString();
            textBoxYazarAdi.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[2].Value.ToString();
            textBoxYazarSoyad.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[3].Value.ToString();
            textBoxISBN.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[4].Value.ToString();
            textBoxOduncAlan.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[6].Value.ToString();
            if (dataGridViewKitaplar.Rows[secilenSatir].Cells[7].Value != DBNull.Value)
                dateTimePickerOduncAlmaTarihi.Value = (DateTime)dataGridViewKitaplar.Rows[secilenSatir].Cells[7].Value;
            textBoxKitapTurKodu.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[8].Value.ToString();
        }

        private void buttonKitapBilgiGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Books SET KitapAdi=@P1, YazarAdi=@P2, YazarSoyadi=@P3, ISBN=@P4, KitapTurKodu=@P5 WHERE ID=@P6", connection);
                cmd.Parameters.AddWithValue("@P1", textBoxKitapAdi.Text);
                cmd.Parameters.AddWithValue("@P2", textBoxYazarAdi.Text);
                cmd.Parameters.AddWithValue("@P3", textBoxYazarSoyad.Text);
                cmd.Parameters.AddWithValue("@P4", textBoxISBN.Text);
                cmd.Parameters.AddWithValue("@P5", textBoxKitapTurKodu.Text);
                cmd.Parameters.AddWithValue("@P6", labelID.Text);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitap güncellenirken hata oluştu !", ex.Message);
            }
            finally
            {
                connection.Close();
            }
            verileriGoster();
        }

        private void buttonKitapOduncVer_Click(object sender, EventArgs e)
        {
            if (labelID.Text != "-")
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Books SET OduncAlan=@P1, OduncAlmaTarihi=@P2, Durum=@P3 WHERE ID=@P4", connection);
                    cmd.Parameters.AddWithValue("@P1", textBoxOduncAlan.Text);
                    cmd.Parameters.Add("@P2", SqlDbType.Date).Value = dateTimePickerOduncAlmaTarihi.Value.Date;
                    cmd.Parameters.AddWithValue("@P3", "False");
                    cmd.Parameters.AddWithValue("@P4", labelID.Text);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kitap ödünç verilirken hata oluştu !", ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                verileriGoster();
            }
            else
            {
                MessageBox.Show("Lütfen listeden bir kitap seçiniz!");
            }
        }

        private void buttonGecikmeBedeliHesapla_Click(object sender, EventArgs e)
        {
            if (labelID.Text != "-")
            {
                DateTime bgTarihi = DateTime.Now;
                int gunFarki = (int)(bgTarihi - dateTimePickerOduncAlmaTarihi.Value.Date).TotalDays;
                if (gunFarki > 10)
                {
                    int gecikmeBedeli = (gunFarki - 10) * 1;
                    labelGecikmeBedeli.Text = gecikmeBedeli.ToString();
                }
            }
        }

        private void buttonKitabiIadeEt_Click(object sender, EventArgs e)
        {
            if (labelID.Text != "-")
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Books SET OduncAlan=@P1, OduncAlmaTarihi=@P2, Durum=@P3 WHERE ID=@P4", connection);
                    cmd.Parameters.AddWithValue("@P1", " ");
                    cmd.Parameters.Add("@P2", SqlDbType.Date).Value = DBNull.Value;
                    cmd.Parameters.AddWithValue("@P3", "False");
                    cmd.Parameters.AddWithValue("@P4", labelID.Text);

                    cmd.ExecuteNonQuery();
                    textBoxOduncAlan.Text = " ";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kitap iade verilirken hata oluştu !", ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                verileriGoster();
            }
        }

        private void metinKutulariniTemizle()
        {
            labelID.Text = "-";
            textBoxKitapAdi.Text = " ";
            textBoxYazarAdi.Text = " ";
            textBoxYazarSoyad.Text = " ";
            textBoxISBN.Text = " ";
            textBoxKitapTurKodu.Text = " ";
            textBoxOduncAlan.Text = " ";
        }


        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            metinKutulariniTemizle();
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            aramaSonuclariniGoster();
        }

        private void aramaSonuclariniGoster()
        {
            try
            {
                string query = "SELECT * FROM BOOKS WHERE KitapAdi LIKE '" + textBoxKitapAdi.Text
                                                                           + " AND YazarAdi LIKE '" + textBoxYazarAdi.Text + "%' "
                                                                           + " AND YazarSoyad LIKE '" + textBoxYazarSoyad.Text + "%' "
                                                                           + " AND ISBN LIKE '" + textBoxISBN.Text + "%' "
                                                                           + " AND KitapTurKodu LIKE '" + textBoxKitapTurKodu.Text + "%' "
                                                                           + " AND OduncAlan LIKE '" + textBoxOduncAlan.Text + "' ";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridViewKitaplar.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verileriGoster();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (labelID.Text == "-" || labelID.Text == " ")
            {
                MessageBox.Show("Lütfen listeden silinecek kitabı seçiniz !");
            }
            else
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Books WHERE ID=@P1", connection);
                    cmd.Parameters.AddWithValue("@P1", labelID.Text);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kitap silinirken hata oluştu !", ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                verileriGoster();
                metinKutulariniTemizle();
            }
        }

        private void FormBooks_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
