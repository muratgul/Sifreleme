namespace Sifreleme
{
    partial class frmAna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAna));
            this.button1 = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDurumTekDosya = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSC = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lbligd = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button6 = new System.Windows.Forms.Button();
            this.chkAltKlasor = new System.Windows.Forms.CheckBox();
            this.lblDurum = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.txtDosyaYolu = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.rdDosyaCoz = new System.Windows.Forms.RadioButton();
            this.rdDosyaSifrele = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.btnKopyalaSifresiz = new System.Windows.Forms.Button();
            this.btnKopyalaSifreli = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdMetinCoz = new System.Windows.Forms.RadioButton();
            this.rdMetinSifrele = new System.Windows.Forms.RadioButton();
            this.rctSifreli = new System.Windows.Forms.RichTextBox();
            this.rctSifresiz = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKey2 = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(22, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Bir Dosyayı Seç ve Uygula";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(121, 15);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(278, 20);
            this.txtKey.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Anahtar Kelime";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 466);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.lblSC);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.txtDosyaYolu);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.rdDosyaCoz);
            this.tabPage1.Controls.Add(this.rdDosyaSifrele);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtKey);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 440);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dosya Şifreleme - Çözme";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.lblDurumTekDosya);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(34, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(700, 84);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tek Dosya Uygulama";
            // 
            // lblDurumTekDosya
            // 
            this.lblDurumTekDosya.AutoSize = true;
            this.lblDurumTekDosya.Location = new System.Drawing.Point(200, 34);
            this.lblDurumTekDosya.Name = "lblDurumTekDosya";
            this.lblDurumTekDosya.Size = new System.Drawing.Size(0, 13);
            this.lblDurumTekDosya.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(293, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Dosyayı seçtikten sonra işlem tamamlanana kadar bekleyiniz.";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Location = new System.Drawing.Point(564, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(32, 31);
            this.panel2.TabIndex = 15;
            this.panel2.Visible = false;
            // 
            // lblSC
            // 
            this.lblSC.AutoSize = true;
            this.lblSC.Location = new System.Drawing.Point(602, 77);
            this.lblSC.Name = "lblSC";
            this.lblSC.Size = new System.Drawing.Size(126, 13);
            this.lblSC.TabIndex = 15;
            this.lblSC.Text = "Şifreleme işlemi yapılacak";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(564, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(32, 31);
            this.panel1.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBaslat);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lbligd);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.chkAltKlasor);
            this.groupBox1.Controls.Add(this.lblDurum);
            this.groupBox1.Location = new System.Drawing.Point(34, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 195);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Çoklu Dosya Uygulama";
            // 
            // btnBaslat
            // 
            this.btnBaslat.Enabled = false;
            this.btnBaslat.Location = new System.Drawing.Point(238, 71);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(75, 23);
            this.btnBaslat.TabIndex = 14;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(542, 71);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 13;
            this.button7.Text = "İptal";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(505, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Alt Klasörleri Dahil Et seçildiğinde seçili klasörün altındaki tüm alt klasörlerd" +
    "eki dosyalar da işlemden geçirilir";
            // 
            // lbligd
            // 
            this.lbligd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbligd.ForeColor = System.Drawing.Color.Purple;
            this.lbligd.Location = new System.Drawing.Point(172, 174);
            this.lbligd.Name = "lbligd";
            this.lbligd.Size = new System.Drawing.Size(528, 18);
            this.lbligd.TabIndex = 10;
            this.lbligd.Text = "İşlem gören dosya: ";
            this.lbligd.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.Teal;
            this.label13.Location = new System.Drawing.Point(57, 174);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "İşlem gören dosya: ";
            this.label13.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(345, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Bu durum dosyaların miktarına ve büyüklüğüne göre uzun zaman alabilir.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(355, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Klasördeki tüm dosyaları bir kerede yapmak için aşağıdaki butonu kullanın.";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(60, 100);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(557, 23);
            this.progressBar1.TabIndex = 12;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(60, 71);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(172, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "Çoklu Dosya Seç";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // chkAltKlasor
            // 
            this.chkAltKlasor.AutoSize = true;
            this.chkAltKlasor.Location = new System.Drawing.Point(60, 48);
            this.chkAltKlasor.Name = "chkAltKlasor";
            this.chkAltKlasor.Size = new System.Drawing.Size(123, 17);
            this.chkAltKlasor.TabIndex = 11;
            this.chkAltKlasor.Text = "Alt Klasörleri Dahil Et";
            this.chkAltKlasor.UseVisualStyleBackColor = true;
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(57, 83);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(0, 13);
            this.lblDurum.TabIndex = 10;
            this.lblDurum.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(118, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(320, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Şifrelenecek/Çözülecek dosyanın nereye kaydedileceğini belirtiniz.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(118, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(230, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Kaybederseniz şifreli dosyayı asla çözemezsiniz.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(118, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(299, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Dikkat!: Anahtar kelimeye dosyayı çözerken ihtiyacınız olacak.";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(405, 13);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "Key";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtDosyaYolu
            // 
            this.txtDosyaYolu.Location = new System.Drawing.Point(121, 77);
            this.txtDosyaYolu.Name = "txtDosyaYolu";
            this.txtDosyaYolu.Size = new System.Drawing.Size(172, 20);
            this.txtDosyaYolu.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(308, 74);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Gözat";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // rdDosyaCoz
            // 
            this.rdDosyaCoz.AutoSize = true;
            this.rdDosyaCoz.ForeColor = System.Drawing.Color.Green;
            this.rdDosyaCoz.Location = new System.Drawing.Point(542, 16);
            this.rdDosyaCoz.Name = "rdDosyaCoz";
            this.rdDosyaCoz.Size = new System.Drawing.Size(57, 17);
            this.rdDosyaCoz.TabIndex = 5;
            this.rdDosyaCoz.Text = "Çözme";
            this.rdDosyaCoz.UseVisualStyleBackColor = true;
            this.rdDosyaCoz.CheckedChanged += new System.EventHandler(this.rdDosyaCoz_CheckedChanged);
            // 
            // rdDosyaSifrele
            // 
            this.rdDosyaSifrele.AutoSize = true;
            this.rdDosyaSifrele.Checked = true;
            this.rdDosyaSifrele.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdDosyaSifrele.Location = new System.Drawing.Point(468, 16);
            this.rdDosyaSifrele.Name = "rdDosyaSifrele";
            this.rdDosyaSifrele.Size = new System.Drawing.Size(68, 17);
            this.rdDosyaSifrele.TabIndex = 5;
            this.rdDosyaSifrele.TabStop = true;
            this.rdDosyaSifrele.Text = "Şifreleme";
            this.rdDosyaSifrele.UseVisualStyleBackColor = true;
            this.rdDosyaSifrele.CheckedChanged += new System.EventHandler(this.rdDosyaSifrele_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kaydedilecek Yol";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.btnKopyalaSifresiz);
            this.tabPage2.Controls.Add(this.btnKopyalaSifreli);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.rdMetinCoz);
            this.tabPage2.Controls.Add(this.rdMetinSifrele);
            this.tabPage2.Controls.Add(this.rctSifreli);
            this.tabPage2.Controls.Add(this.rctSifresiz);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtKey2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 440);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Metin Şifreleme - Çözme";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(474, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Key";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnKopyalaSifresiz
            // 
            this.btnKopyalaSifresiz.Location = new System.Drawing.Point(305, 48);
            this.btnKopyalaSifresiz.Name = "btnKopyalaSifresiz";
            this.btnKopyalaSifresiz.Size = new System.Drawing.Size(75, 23);
            this.btnKopyalaSifresiz.TabIndex = 14;
            this.btnKopyalaSifresiz.Text = "Kopyala";
            this.btnKopyalaSifresiz.UseVisualStyleBackColor = true;
            this.btnKopyalaSifresiz.Click += new System.EventHandler(this.btnKopyalaSifresiz_Click);
            // 
            // btnKopyalaSifreli
            // 
            this.btnKopyalaSifreli.Location = new System.Drawing.Point(670, 48);
            this.btnKopyalaSifreli.Name = "btnKopyalaSifreli";
            this.btnKopyalaSifreli.Size = new System.Drawing.Size(75, 23);
            this.btnKopyalaSifreli.TabIndex = 14;
            this.btnKopyalaSifreli.Text = "Kopyala";
            this.btnKopyalaSifreli.UseVisualStyleBackColor = true;
            this.btnKopyalaSifreli.Click += new System.EventHandler(this.btnKopyalaSifreli_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(670, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Uygula";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Şifreli Metin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Şifresiz Metin";
            // 
            // rdMetinCoz
            // 
            this.rdMetinCoz.AutoSize = true;
            this.rdMetinCoz.Location = new System.Drawing.Point(621, 16);
            this.rdMetinCoz.Name = "rdMetinCoz";
            this.rdMetinCoz.Size = new System.Drawing.Size(43, 17);
            this.rdMetinCoz.TabIndex = 11;
            this.rdMetinCoz.Text = "Çöz";
            this.rdMetinCoz.UseVisualStyleBackColor = true;
            this.rdMetinCoz.CheckedChanged += new System.EventHandler(this.rdMetinCoz_CheckedChanged);
            // 
            // rdMetinSifrele
            // 
            this.rdMetinSifrele.AutoSize = true;
            this.rdMetinSifrele.Checked = true;
            this.rdMetinSifrele.Location = new System.Drawing.Point(561, 16);
            this.rdMetinSifrele.Name = "rdMetinSifrele";
            this.rdMetinSifrele.Size = new System.Drawing.Size(54, 17);
            this.rdMetinSifrele.TabIndex = 10;
            this.rdMetinSifrele.TabStop = true;
            this.rdMetinSifrele.Text = "Şifrele";
            this.rdMetinSifrele.UseVisualStyleBackColor = true;
            this.rdMetinSifrele.CheckedChanged += new System.EventHandler(this.rdMetinSifrele_CheckedChanged);
            // 
            // rctSifreli
            // 
            this.rctSifreli.BackColor = System.Drawing.Color.SeaShell;
            this.rctSifreli.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rctSifreli.Enabled = false;
            this.rctSifreli.Location = new System.Drawing.Point(386, 72);
            this.rctSifreli.Name = "rctSifreli";
            this.rctSifreli.Size = new System.Drawing.Size(359, 360);
            this.rctSifreli.TabIndex = 9;
            this.rctSifreli.Text = "";
            // 
            // rctSifresiz
            // 
            this.rctSifresiz.BackColor = System.Drawing.Color.SeaShell;
            this.rctSifresiz.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rctSifresiz.Location = new System.Drawing.Point(21, 72);
            this.rctSifresiz.Name = "rctSifresiz";
            this.rctSifresiz.Size = new System.Drawing.Size(359, 360);
            this.rctSifresiz.TabIndex = 9;
            this.rctSifresiz.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Anahtar Kelime";
            // 
            // txtKey2
            // 
            this.txtKey2.Location = new System.Drawing.Point(102, 15);
            this.txtKey2.Name = "txtKey2";
            this.txtKey2.Size = new System.Drawing.Size(366, 20);
            this.txtKey2.TabIndex = 5;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerSupportsCancellation = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // backgroundWorker3
            // 
            this.backgroundWorker3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker3_DoWork);
            this.backgroundWorker3.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker3_RunWorkerCompleted);
            // 
            // frmAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 466);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enc-Dec 1.3";
            this.Load += new System.EventHandler(this.frmAna_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKey2;
        private System.Windows.Forms.RichTextBox rctSifreli;
        private System.Windows.Forms.RichTextBox rctSifresiz;
        private System.Windows.Forms.RadioButton rdMetinCoz;
        private System.Windows.Forms.RadioButton rdMetinSifrele;
        private System.Windows.Forms.RadioButton rdDosyaCoz;
        private System.Windows.Forms.RadioButton rdDosyaSifrele;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnKopyalaSifresiz;
        private System.Windows.Forms.Button btnKopyalaSifreli;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtDosyaYolu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkAltKlasor;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDurum;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSC;
        private System.Windows.Forms.Panel panel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDurumTekDosya;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbligd;
        private System.Windows.Forms.Label label13;
    }
}

