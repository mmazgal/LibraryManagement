namespace LibraryManagement
{
    partial class FormBooks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            buttonSil = new Button();
            buttonTumKitaplariGoster = new Button();
            buttonAra = new Button();
            buttonTemizle = new Button();
            buttonKitapBilgiGuncelle = new Button();
            buttonKitapEkle = new Button();
            textBoxKitapTurKodu = new TextBox();
            textBoxISBN = new TextBox();
            textBoxYazarSoyad = new TextBox();
            textBoxYazarAdi = new TextBox();
            textBoxKitapAdi = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            labelID = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            buttonKitapOduncVer = new Button();
            dateTimePickerOduncAlmaTarihi = new DateTimePicker();
            textBoxOduncAlan = new TextBox();
            label9 = new Label();
            label8 = new Label();
            groupBox3 = new GroupBox();
            buttonKitabiIadeEt = new Button();
            label11 = new Label();
            labelGecikmeBedeli = new Label();
            buttonGecikmeBedeliHesapla = new Button();
            label10 = new Label();
            groupBox4 = new GroupBox();
            dataGridViewKitaplar = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKitaplar).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonSil);
            groupBox1.Controls.Add(buttonTumKitaplariGoster);
            groupBox1.Controls.Add(buttonAra);
            groupBox1.Controls.Add(buttonTemizle);
            groupBox1.Controls.Add(buttonKitapBilgiGuncelle);
            groupBox1.Controls.Add(buttonKitapEkle);
            groupBox1.Controls.Add(textBoxKitapTurKodu);
            groupBox1.Controls.Add(textBoxISBN);
            groupBox1.Controls.Add(textBoxYazarSoyad);
            groupBox1.Controls.Add(textBoxYazarAdi);
            groupBox1.Controls.Add(textBoxKitapAdi);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(labelID);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(514, 452);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kitap Kayıt ve Güncelleme";
            // 
            // buttonSil
            // 
            buttonSil.Location = new Point(390, 312);
            buttonSil.Name = "buttonSil";
            buttonSil.Size = new Size(90, 50);
            buttonSil.TabIndex = 16;
            buttonSil.Text = "Kitap Sil";
            buttonSil.UseVisualStyleBackColor = true;
            buttonSil.Click += buttonSil_Click;
            // 
            // buttonTumKitaplariGoster
            // 
            buttonTumKitaplariGoster.Location = new Point(210, 312);
            buttonTumKitaplariGoster.Name = "buttonTumKitaplariGoster";
            buttonTumKitaplariGoster.Size = new Size(90, 50);
            buttonTumKitaplariGoster.TabIndex = 15;
            buttonTumKitaplariGoster.Text = "Tümünü Göster";
            buttonTumKitaplariGoster.UseVisualStyleBackColor = true;
            buttonTumKitaplariGoster.Click += button1_Click;
            // 
            // buttonAra
            // 
            buttonAra.Location = new Point(390, 381);
            buttonAra.Name = "buttonAra";
            buttonAra.Size = new Size(90, 50);
            buttonAra.TabIndex = 14;
            buttonAra.Text = "Ara";
            buttonAra.UseVisualStyleBackColor = true;
            buttonAra.Click += buttonAra_Click;
            // 
            // buttonTemizle
            // 
            buttonTemizle.Location = new Point(210, 381);
            buttonTemizle.Name = "buttonTemizle";
            buttonTemizle.Size = new Size(90, 50);
            buttonTemizle.TabIndex = 13;
            buttonTemizle.Text = "Temizle";
            buttonTemizle.UseVisualStyleBackColor = true;
            buttonTemizle.Click += buttonTemizle_Click;
            // 
            // buttonKitapBilgiGuncelle
            // 
            buttonKitapBilgiGuncelle.Location = new Point(30, 312);
            buttonKitapBilgiGuncelle.Name = "buttonKitapBilgiGuncelle";
            buttonKitapBilgiGuncelle.Size = new Size(90, 50);
            buttonKitapBilgiGuncelle.TabIndex = 12;
            buttonKitapBilgiGuncelle.Text = "Kitap Güncelle";
            buttonKitapBilgiGuncelle.UseVisualStyleBackColor = true;
            buttonKitapBilgiGuncelle.Click += buttonKitapBilgiGuncelle_Click;
            // 
            // buttonKitapEkle
            // 
            buttonKitapEkle.Location = new Point(30, 381);
            buttonKitapEkle.Name = "buttonKitapEkle";
            buttonKitapEkle.Size = new Size(90, 50);
            buttonKitapEkle.TabIndex = 11;
            buttonKitapEkle.Text = "Kitap Ekle";
            buttonKitapEkle.UseVisualStyleBackColor = true;
            buttonKitapEkle.Click += buttonKitapEkle_Click;
            // 
            // textBoxKitapTurKodu
            // 
            textBoxKitapTurKodu.Location = new Point(188, 266);
            textBoxKitapTurKodu.Name = "textBoxKitapTurKodu";
            textBoxKitapTurKodu.Size = new Size(240, 27);
            textBoxKitapTurKodu.TabIndex = 10;
            // 
            // textBoxISBN
            // 
            textBoxISBN.Location = new Point(188, 223);
            textBoxISBN.Name = "textBoxISBN";
            textBoxISBN.Size = new Size(240, 27);
            textBoxISBN.TabIndex = 9;
            // 
            // textBoxYazarSoyad
            // 
            textBoxYazarSoyad.Location = new Point(188, 178);
            textBoxYazarSoyad.Name = "textBoxYazarSoyad";
            textBoxYazarSoyad.Size = new Size(240, 27);
            textBoxYazarSoyad.TabIndex = 8;
            // 
            // textBoxYazarAdi
            // 
            textBoxYazarAdi.Location = new Point(188, 133);
            textBoxYazarAdi.Name = "textBoxYazarAdi";
            textBoxYazarAdi.Size = new Size(240, 27);
            textBoxYazarAdi.TabIndex = 7;
            // 
            // textBoxKitapAdi
            // 
            textBoxKitapAdi.Location = new Point(188, 92);
            textBoxKitapAdi.Name = "textBoxKitapAdi";
            textBoxKitapAdi.Size = new Size(240, 27);
            textBoxKitapAdi.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(30, 262);
            label7.Name = "label7";
            label7.Size = new Size(152, 28);
            label7.TabIndex = 6;
            label7.Text = "Kitap Tür Kodu :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(30, 219);
            label6.Name = "label6";
            label6.Size = new Size(63, 28);
            label6.TabIndex = 5;
            label6.Text = "ISBN :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(30, 174);
            label5.Name = "label5";
            label5.Size = new Size(126, 28);
            label5.TabIndex = 4;
            label5.Text = "Yazar Soyad :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(30, 129);
            label4.Name = "label4";
            label4.Size = new Size(101, 28);
            label4.TabIndex = 3;
            label4.Text = "Yazar Adı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(30, 88);
            label3.Name = "label3";
            label3.Size = new Size(102, 28);
            label3.TabIndex = 2;
            label3.Text = "Kitap Adı :";
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Segoe UI", 12F);
            labelID.Location = new Point(188, 40);
            labelID.Name = "labelID";
            labelID.Size = new Size(20, 28);
            labelID.TabIndex = 1;
            labelID.Text = "-";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(30, 40);
            label1.Name = "label1";
            label1.Size = new Size(91, 28);
            label1.TabIndex = 0;
            label1.Text = "Kitap ID :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonKitapOduncVer);
            groupBox2.Controls.Add(dateTimePickerOduncAlmaTarihi);
            groupBox2.Controls.Add(textBoxOduncAlan);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(532, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(386, 452);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kitap Ödünç Alma";
            // 
            // buttonKitapOduncVer
            // 
            buttonKitapOduncVer.Location = new Point(111, 166);
            buttonKitapOduncVer.Name = "buttonKitapOduncVer";
            buttonKitapOduncVer.Size = new Size(162, 50);
            buttonKitapOduncVer.TabIndex = 16;
            buttonKitapOduncVer.Text = "Kitabı Ödünç Ver";
            buttonKitapOduncVer.UseVisualStyleBackColor = true;
            buttonKitapOduncVer.Click += buttonKitapOduncVer_Click;
            // 
            // dateTimePickerOduncAlmaTarihi
            // 
            dateTimePickerOduncAlmaTarihi.Location = new Point(160, 90);
            dateTimePickerOduncAlmaTarihi.Name = "dateTimePickerOduncAlmaTarihi";
            dateTimePickerOduncAlmaTarihi.Size = new Size(153, 27);
            dateTimePickerOduncAlmaTarihi.TabIndex = 6;
            // 
            // textBoxOduncAlan
            // 
            textBoxOduncAlan.Location = new Point(160, 40);
            textBoxOduncAlan.Name = "textBoxOduncAlan";
            textBoxOduncAlan.Size = new Size(153, 27);
            textBoxOduncAlan.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(31, 40);
            label9.Name = "label9";
            label9.Size = new Size(123, 28);
            label9.TabIndex = 4;
            label9.Text = "Ödünç Alan :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(31, 88);
            label8.Name = "label8";
            label8.Size = new Size(62, 28);
            label8.TabIndex = 3;
            label8.Text = "Tarih :";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonKitabiIadeEt);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(labelGecikmeBedeli);
            groupBox3.Controls.Add(buttonGecikmeBedeliHesapla);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(924, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(319, 452);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kitap İade";
            // 
            // buttonKitabiIadeEt
            // 
            buttonKitabiIadeEt.Location = new Point(64, 197);
            buttonKitabiIadeEt.Name = "buttonKitabiIadeEt";
            buttonKitabiIadeEt.Size = new Size(162, 50);
            buttonKitabiIadeEt.TabIndex = 15;
            buttonKitabiIadeEt.Text = "Kitabı İade Et";
            buttonKitabiIadeEt.UseVisualStyleBackColor = true;
            buttonKitabiIadeEt.Click += buttonKitabiIadeEt_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(247, 40);
            label11.Name = "label11";
            label11.Size = new Size(31, 28);
            label11.TabIndex = 14;
            label11.Text = "TL";
            // 
            // labelGecikmeBedeli
            // 
            labelGecikmeBedeli.AutoSize = true;
            labelGecikmeBedeli.Font = new Font("Segoe UI", 12F);
            labelGecikmeBedeli.Location = new Point(178, 40);
            labelGecikmeBedeli.Name = "labelGecikmeBedeli";
            labelGecikmeBedeli.Size = new Size(23, 28);
            labelGecikmeBedeli.TabIndex = 13;
            labelGecikmeBedeli.Text = "0";
            // 
            // buttonGecikmeBedeliHesapla
            // 
            buttonGecikmeBedeliHesapla.Location = new Point(64, 110);
            buttonGecikmeBedeliHesapla.Name = "buttonGecikmeBedeliHesapla";
            buttonGecikmeBedeliHesapla.Size = new Size(162, 50);
            buttonGecikmeBedeliHesapla.TabIndex = 12;
            buttonGecikmeBedeliHesapla.Text = "Gecikme Bedeli Hesapla";
            buttonGecikmeBedeliHesapla.UseVisualStyleBackColor = true;
            buttonGecikmeBedeliHesapla.Click += buttonGecikmeBedeliHesapla_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(18, 40);
            label10.Name = "label10";
            label10.Size = new Size(154, 28);
            label10.TabIndex = 5;
            label10.Text = "Gecikme Bedeli :";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridViewKitaplar);
            groupBox4.Location = new Point(12, 470);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1167, 229);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Kitap Listesi";
            // 
            // dataGridViewKitaplar
            // 
            dataGridViewKitaplar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewKitaplar.Dock = DockStyle.Fill;
            dataGridViewKitaplar.Location = new Point(3, 23);
            dataGridViewKitaplar.Name = "dataGridViewKitaplar";
            dataGridViewKitaplar.RowHeadersWidth = 51;
            dataGridViewKitaplar.Size = new Size(1161, 203);
            dataGridViewKitaplar.TabIndex = 0;
            dataGridViewKitaplar.CellMouseClick += dataGridViewKitaplar_CellMouseClick;
            // 
            // FormBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1255, 711);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormBooks";
            Text = "Kitap Yönetim Sistemi";
            FormClosed += FormBooks_FormClosed;
            Load += FormBooks_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewKitaplar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label labelID;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBoxKitapTurKodu;
        private TextBox textBoxISBN;
        private TextBox textBoxYazarSoyad;
        private TextBox textBoxYazarAdi;
        private TextBox textBoxKitapAdi;
        private GroupBox groupBox4;
        private DataGridView dataGridViewKitaplar;
        private Button buttonKitapBilgiGuncelle;
        private Button buttonKitapEkle;
        private Label label9;
        private Label label8;
        private TextBox textBoxOduncAlan;
        private DateTimePicker dateTimePickerOduncAlmaTarihi;
        private Button buttonGecikmeBedeliHesapla;
        private Label label10;
        private Label labelGecikmeBedeli;
        private Label label11;
        private Button buttonKitabiIadeEt;
        private Button buttonKitapOduncVer;
        private Button buttonTemizle;
        private Button buttonAra;
        private Button buttonTumKitaplariGoster;
        private Button buttonSil;
    }
}