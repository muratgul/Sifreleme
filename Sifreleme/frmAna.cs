using NETCore.Encrypt;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Sifreleme
{
    public partial class frmAna : Form
    {

        private string sifreliMetin { get; set; }
        private string sifresizMetin { get; set; }
        private string folder { get; set; }
        private string method { get; set; }
        private int dosyaSayisi { get; set; }
        private string dosyaAdi { get; set; }
        private string tip { get; set; }
        private string dosyaYolu { get; set; }
        public frmAna()
        {

            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        [DllImport("KERNEL32.DLL", EntryPoint = "RtlZeroMemory")]
        public static extern bool ZeroMemory(IntPtr Destination, int Length);

        public static byte[] GenerateRandomSalt()
        {
            byte[] data = new byte[32];

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                for (int i = 0; i < 10; i++)
                {
                    // Fille the buffer with the generated data
                    rng.GetBytes(data);
                }
            }

            return data;
        }

        private void FileEncrypt(string inputFile, string dosya, string password)
        {
            var dt = DateTime.Now;
            

            //generate random salt
            byte[] salt = GenerateRandomSalt();

                //create output file name
                FileStream fsCrypt = new FileStream(txtDosyaYolu.Text +"\\"+ dt.ToString("HHmmssfffffff") +"_"+ dosya + ".aes", FileMode.Create);

                //convert password string to byte arrray
                byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);

                //Set Rijndael symmetric encryption algorithm
                RijndaelManaged AES = new RijndaelManaged();
                AES.KeySize = 256;
                AES.BlockSize = 128;
                AES.Padding = PaddingMode.PKCS7;

                var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);
                AES.Key = key.GetBytes(AES.KeySize / 8);
                AES.IV = key.GetBytes(AES.BlockSize / 8);

                AES.Mode = CipherMode.CFB;

                // write salt to the begining of the output file, so in this case can be random every time
                fsCrypt.Write(salt, 0, salt.Length);

                CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateEncryptor(), CryptoStreamMode.Write);

                FileStream fsIn = new FileStream(inputFile, FileMode.Open);

                //create a buffer (1mb) so only this amount will allocate in the memory and not the whole file
                byte[] buffer = new byte[1048576];
                int read;

                try
                {
                    while ((read = fsIn.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        Application.DoEvents(); // -> for responsive GUI, using Task will be better!
                        cs.Write(buffer, 0, read);
                    }

                    // Close up
                    fsIn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cs.Close();
                    fsCrypt.Close();
                }
            
        }

        private void FileDecrypt(string inputFile, string dosya, string password)
        {
            var dt = DateTime.Now;
            string file = dosya.Remove(dosya.Length - 4);

            byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);
            byte[] salt = new byte[32];

            FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);
            fsCrypt.Read(salt, 0, salt.Length);

            RijndaelManaged AES = new RijndaelManaged();
            AES.KeySize = 256;
            AES.BlockSize = 128;
            var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);
            AES.Padding = PaddingMode.PKCS7;
            AES.Mode = CipherMode.CFB;

            CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateDecryptor(), CryptoStreamMode.Read);

            FileStream fsOut = new FileStream(txtDosyaYolu.Text + "\\" + dt.ToString("HHmmssfffffff") + "_" + file, FileMode.Create);

            int read;
            byte[] buffer = new byte[1048576];

            try
            {
                while ((read = cs.Read(buffer, 0, buffer.Length)) > 0)
                {
                    Application.DoEvents();
                    fsOut.Write(buffer, 0, read);
                }
            }
            catch (CryptographicException ex_CryptographicException)
            {
                Console.WriteLine("CryptographicException error: " + ex_CryptographicException.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            try
            {
                cs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error by closing CryptoStream: " + ex.Message);
            }
            finally
            {
                fsOut.Close();
                fsCrypt.Close();
            }
        }
  
        private void button1_Click(object sender, EventArgs e)
        {
            
                if (txtDosyaYolu.Text != "" && txtDosyaYolu.Text.Length > 2) 
                {
                    if (txtKey.Text != "" && txtKey.Text.Length > 6)
                    {
                        if (rdDosyaSifrele.Checked == true) 
                        {
                            OpenFileDialog file = new OpenFileDialog();
                            file.Filter = "Tüm Dosyalar | *.*";
                            file.FilterIndex = 2;
                            file.RestoreDirectory = true;
                            file.CheckFileExists = false;
                            file.Title = "Bir Dosyası Seçiniz..";

                            if (file.ShowDialog() == DialogResult.OK)
                            {
                            button1.Enabled = false;
                            button4.Enabled = false;
                            button6.Enabled = false;
                            button5.Enabled = false;
                                lblDurumTekDosya.Text = "Lütfen işlem tamamlanana kadar bekleyiniz";
                                button1.Enabled = false;
                                method = "enc";
                                dosyaYolu = file.FileName;
                                dosyaAdi = file.SafeFileName;
                                backgroundWorker3.RunWorkerAsync();
                            
                               
                            }
                        }
                        else if (rdDosyaCoz.Checked == true)
                        {

                            OpenFileDialog file = new OpenFileDialog();
                            file.Filter = "AES |*.aes";
                            file.FilterIndex = 2;
                            file.RestoreDirectory = true;
                            file.CheckFileExists = false;
                            file.Title = "AES Dosyası Seçiniz..";

                            if (file.ShowDialog() == DialogResult.OK)
                            {
                            button1.Enabled = false;
                            button4.Enabled = false;
                            button6.Enabled = false;
                            button5.Enabled = false;
                            lblDurumTekDosya.Text = "Lütfen işlem tamamlanana kadar bekleyiniz";
                                method = "dec";
                                dosyaYolu = file.FileName;
                                dosyaAdi = file.SafeFileName;
                                backgroundWorker3.RunWorkerAsync();
                                
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Anahtar Kelime 6 Haneden Uzun Olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Dosya Yolu Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            
        }

        private void oneFileEncDec()
        {
            if(method == "enc")
            {
                FileEncrypt(dosyaYolu, dosyaAdi, txtKey.Text);
            }
            else if(method == "dec")
            {
                FileDecrypt(dosyaYolu, dosyaAdi, txtKey.Text);
            }

        }

        private void rdMetinSifrele_CheckedChanged(object sender, EventArgs e)
        {
            rctSifresiz.Enabled = true;
            rctSifreli.Enabled = false;
        }

        private void rdMetinCoz_CheckedChanged(object sender, EventArgs e)
        {
            rctSifresiz.Enabled = false;
            rctSifreli.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
   
            try
            {
                if (rdMetinSifrele.Checked == true)
                {
                    rctSifreli.Text = "";

                    sifreliMetin = EncryptProvider.AESEncrypt(rctSifresiz.Text, txtKey2.Text);
                    sifresizMetin = rctSifresiz.Text;

                    rctSifreli.Text = sifreliMetin;
                }
                else if (rdMetinCoz.Checked == true)
                {
                    rctSifresiz.Text = "";
                    sifresizMetin = EncryptProvider.AESDecrypt(rctSifreli.Text, txtKey2.Text);
                    sifreliMetin = rctSifreli.Text;

                    rctSifresiz.Text = sifresizMetin;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Geçersiz Anahtar","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);                
            }
   
        }

        private void btnKopyalaSifresiz_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(sifresizMetin);
        }

        private void btnKopyalaSifreli_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(sifreliMetin);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KeyGenerator();
        }

        private void KeyGenerator()
        {
            var aesKey = EncryptProvider.CreateAesKey();
            txtKey2.Text = aesKey.Key;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            DialogResult result = folderBrowserDialog1.ShowDialog();
            
            if (result == DialogResult.OK)
            {
                string folderName = folderBrowserDialog1.SelectedPath;

                txtDosyaYolu.Text = folderName;

                button1.Enabled = true;
            }
            
        }

        private void frmAna_Load(object sender, EventArgs e)
        {
            KeyGenerator();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var aesKey = EncryptProvider.CreateAesKey();
            txtKey.Text = aesKey.Key;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtDosyaYolu.Text != "" && txtDosyaYolu.Text.Length > 2)
            {
                if (txtKey.Text != "" && txtKey.Text.Length > 6)
                {

                    if (chkAltKlasor.Checked == false)
                    {
                        if (rdDosyaSifrele.Checked == true)
                        {


                            DialogResult result = folderBrowserDialog1.ShowDialog();
                            if (result == DialogResult.OK)
                            {

                                method = "enc";
                                tip = "run2";
                                string folderName = folderBrowserDialog1.SelectedPath;
                                folder = folderName;
                                string[] files = Directory.GetFiles(folder, "*.*");
                                dosyaSayisi = files.Length;
                                btnBaslat.Enabled = true;


                            }
                            else
                            {
                                tip = "";
                                btnBaslat.Enabled = false;
                            }



                        }
                        else if (rdDosyaCoz.Checked == true)
                        {
                            DialogResult result = folderBrowserDialog1.ShowDialog();
                            if (result == DialogResult.OK)
                            {
                                method = "dec";
                                tip = "run2";
                                string folderName = folderBrowserDialog1.SelectedPath;
                                folder = folderName;
                                string[] files = Directory.GetFiles(folder, "*.aes");
                                dosyaSayisi = files.Length;
                                btnBaslat.Enabled = true;
                            }
                            else
                            {
                                tip = "";
                                btnBaslat.Enabled = false;
                            }
                        }
                    }
                    else // Alt klasörler dahilse
                    {
                        DialogResult result = folderBrowserDialog1.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            string folderName = folderBrowserDialog1.SelectedPath;
                            folder = folderName;
                            if (rdDosyaSifrele.Checked == true)
                            {

                                method = "enc";
                                tip = "run1";
                                btnBaslat.Enabled = true;
                            }
                            else
                            {
                                method = "dec";
                                tip = "run1";
                                btnBaslat.Enabled = true;
                            }
                        }
                        else
                        {
                            tip = "";
                            btnBaslat.Enabled = false;
                        }
                    }





                }
                else
                {
                    MessageBox.Show("Anahtar Kelime 6 Haneden Uzun Olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Dosya Yolu Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
            

            
        private void EncDecOneFolder()
            {
            label13.Visible = true;
            lbligd.Visible = true;
            if (method == "enc")
            {
                int r = 1;
                DirectoryInfo d = new DirectoryInfo(folder);

                foreach (var file in d.GetFiles("*.*"))
                {
                    lbligd.Text = file.Name;
                    FileEncrypt(file.FullName, file.Name, txtKey.Text);
                    decimal islem = (Convert.ToDecimal(r) / (dosyaSayisi)) * 100;
                    r++;
                    progressBar1.Value = Convert.ToInt32(Math.Ceiling(islem));
                }

                

            }
            else
            {
                int r = 1;
                DirectoryInfo d = new DirectoryInfo(folder);

                foreach (var file in d.GetFiles("*.aes"))
                {
                    lbligd.Text = file.Name;
                    FileDecrypt(file.FullName, file.Name, txtKey.Text);
                    decimal islem = (Convert.ToDecimal(r) / (dosyaSayisi)) * 100;
                    r++;
                    progressBar1.Value = Convert.ToInt32(Math.Ceiling(islem));
                }

                
            }

                
        }
       

        private void DirSearchEncDec(string sDir, string metod)
        {
            label13.Visible = true;
            lbligd.Visible = true;
            string fileName = null;
            string fileFull = null;
            string[] files = Directory.GetFiles(sDir, "*.*", SearchOption.AllDirectories);
            dosyaSayisi = files.Length;

            try
            {
                if(metod == "enc")
                {
                    int r = 1;
                    foreach (string file in files)
                    {
                        fileName = Path.GetFileName(file);
                        fileFull = Path.GetFullPath(file);
                        lbligd.Text = fileName;
                        FileEncrypt(fileFull, fileName, txtKey.Text);
                        decimal islem = (Convert.ToDecimal(r) / (dosyaSayisi)) * 100;
                        r++;
                        progressBar1.Value = Convert.ToInt32(Math.Ceiling(islem));
                    }
                }
                else
                {
                    int r = 1;
                    foreach (string file in files)
                    {

                        fileName = Path.GetFileName(file);
                        fileFull = Path.GetFullPath(file);
                        lbligd.Text = fileName;
                        FileDecrypt(fileFull, fileName, txtKey.Text);
                        decimal islem = (Convert.ToDecimal(r) / (dosyaSayisi)) * 100;
                        r++;
                        progressBar1.Value = Convert.ToInt32(Math.Ceiling(islem));
                    }
                }
                
            }
            catch (Exception excpt)
            {
                MessageBox.Show(excpt.Message);
            }
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            DirSearchEncDec(folder, method);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            button1.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            label13.Visible = false;
            lbligd.Visible = false;
            MessageBox.Show("İşlem tamamlandı", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void backgroundWorker2_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            EncDecOneFolder();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //backgroundWorker2.Dispose();
            //backgroundWorker1.Dispose();
            //backgroundWorker1.CancelAsync();
            //backgroundWorker2.CancelAsync();
        }

        private void rdDosyaSifrele_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            lblSC.Text = "Şifreleme işlemi yapılacak";
        }

        private void rdDosyaCoz_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            lblSC.Text = "Çözme işlemi yapılacak";
        }

        private void backgroundWorker3_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

            oneFileEncDec();
        }

        private void backgroundWorker3_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            lblDurumTekDosya.Text = "";
            button1.Enabled = true;
            button6.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            MessageBox.Show("İşlem tamamlandı", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            btnBaslat.Enabled = false;
            button6.Enabled = false;
            button1.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            if(tip == "run1")
            {
                backgroundWorker1.RunWorkerAsync();
            }

            if (tip == "run2")
            {
                backgroundWorker2.RunWorkerAsync();
            }
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            lblDurumTekDosya.Text = "";
            button1.Enabled = true;
            button6.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            lbligd.Visible = false;
            label13.Visible = false;
            MessageBox.Show("İşlem tamamlandı", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
