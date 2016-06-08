using System;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace CryptoBlax2
{

    public partial class Principal : Form
    {

        Funciones fn = new Funciones();
        static bool autodestroy = false;
        static bool iterar = false;
        static bool passOk = false;
        static bool ipPublicOk = false;
        static string NombreArchivo;
        static string rutafull;
        static string rutaFullCrypt;
        static string IpPublica;
        static bool EncryptOK = false;
        static bool isGettingIP = false;
        static bool uniqueInfo = false;

        static ToolTip tl = new ToolTip();
        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tl.IsBalloon = true;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ArchivoNuevo(openFileDialog1.FileName);
            }
        }
        private void ArchivoNuevo(string ruta)
        {
            lblfilesize.Text = fn.getFileSize(openFileDialog1.FileName);
            panelOpciones.Visible = true;
            NombreArchivo = openFileDialog1.SafeFileName;
            panelPass.Visible = true;
            txtruta.Text = openFileDialog1.FileName;
            rutafull = txtruta.Text;
        }
        private void checkPass(string pass1, string pass2)
        {
            if (fn.isPassValid(pass1, pass2))
            {
                pictureBox6.Visible = false;
                int mm = fn.passSecurity(pass1);
                if (mm > 30)
                {
                    mm = 30;
                }
                progressBar1.Value = mm;
                passOk = true;
            }
            else
            {
                pictureBox6.Visible = true;
                pictureBox6.Image = Properties.Resources.wrong;
                progressBar1.Value = 0;
                passOk = false;

            }
        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (!iterar)
            {
                iterar = true;
                pictureBox3.Image = Properties.Resources.circle_green;
                numericitera.Visible = true;
            }
            else
            {
                iterar = false;
                pictureBox3.Image = Properties.Resources.circle_red;
                numericitera.Visible = false;
            }
        }



        private void txtpass1_TextChanged(object sender, EventArgs e)
        {
            checkPass(txtpass1.Text, txtpass2.Text);
        }

        private void txtpass2_TextChanged(object sender, EventArgs e)
        {
            checkPass(txtpass1.Text, txtpass2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (passOk)
            {
                pictureBox1.Visible = true;
                txtpass1.ReadOnly = true;
                txtpass2.ReadOnly = true;
            }
            else
            {
                //Contraseña no válida
                MessageBox.Show("Verifique que las claves sean correctas en ambos casos.", "Claves inválidas");
            }
        }
        private void Encriptar()
        {

            bwCrypto.RunWorkerAsync();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!EncryptOK)
            {
                loading1.Visible = true;
                //Encriptar Pass

                Encriptar();
            }

        }

        private void bwCrypto_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            string pass = txtpass1.Text;
            int itera = 1;
            if (iterar)
            {
                Convert.ToInt32(numericitera.Value);
            }
            string hash = fn.CryptoCreateHash(pass, itera);
            Cryptology.Salt = hash;
            //Cifrar Archivo
            int ls = txtruta.Text.LastIndexOf('.');
            string archivoSalida = txtruta.Text.Remove(ls, txtruta.Text.Length - ls);
            archivoSalida += ".blx";
            rutaFullCrypt = archivoSalida;
            backPercentCheck.RunWorkerAsync();
            Cryptology.EncryptFile(txtruta.Text, archivoSalida, hash);
            bwCrypto.ReportProgress(100);


        }

        private void bwCrypto_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage == 100)
            {

                loading1.Visible = false;
                pictureBox1.Image = Properties.Resources.locked;
                EncryptOK = true;
                MessageBox.Show("Se completó la encriptación correctamente!.", "Correcto");

                ReiniciarGUI();

            }
        }


        private void backGetIP_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage == 1)
            {
                pictureBox7.Visible = true;
            }
            else if (e.ProgressPercentage == 10)
            {

                lblIpPublica.Visible = false;
                pictureBox7.Visible = false;
            }
            else if (e.ProgressPercentage == 100)
            {
                lblIpPublica.Text = IpPublica;
                lblIpPublica.Visible = true;
                pictureBox7.Visible = false;
            }
        }
        static int ppr = 0;
        private void backPercentCheck_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (backPercentCheck.CancellationPending)
            {
                e.Cancel = true;
                return;
            }
            while (true)
            {
                try
                {
                    //Obtener Tamaño del archivo encriptado y comprobar con el original


                    double sizeCryp = Convert.ToDouble(fn.getBytes(rutaFullCrypt));
                    double sizeOriginal = Convert.ToDouble(fn.getBytes(rutafull));
                    int percent = Convert.ToInt32(Math.Round((sizeCryp * 100) / sizeOriginal, 0));
                    ppr = percent;
                    if (sizeCryp > sizeOriginal)
                    {
                        backPercentCheck.CancelAsync();
                        return;
                    }
                    progressCrypt.Invoke(new MethodInvoker(UpdateGUI));


                }
                catch (Exception ex)
                {

                }
            }
        }
        private void UpdateGUI()
        {
            progressCrypt.Value = ppr;
            label10.Text = ppr + " %";
        }

        private void Form1_DragEnter_1(object sender, DragEventArgs e)
        {
            try
            {
                Array data = e.Data.GetData("FileName") as Array;
                if (data.GetValue(0).ToString().Length > 0)
                {
                    lblfilesize.Text = data.GetValue(0).ToString();
                    panelOpciones.Visible = true;
                    var nombreArch = data.GetValue(0).ToString().Split('\\');
                    NombreArchivo = nombreArch[nombreArch.Length - 1];
                    panelPass.Visible = true;
                    txtruta.Text = data.GetValue(0).ToString();
                    rutafull = txtruta.Text;
                }
            }
            catch (Exception ex) { }

        }

        private void tmrGetIP_Tick(object sender, EventArgs e)
        {

            if (!isGettingIP)
            {


                Console.WriteLine("GET IP");
                isGettingIP = true;
                new Thread(() =>
                {

                    Thread.CurrentThread.IsBackground = true;

                    if (ipPublicOk)
                    {
                        tmrGetIP.Enabled = false;
                    }

                    try
                    {
                        IpPublica = fn.getPublicIP();

                        Invoke(new Action<string>(ChangeIP), new object[] { IpPublica });
                        if (IpPublica.Length > 2)
                        {
                            ipPublicOk = true;
                            tmrGetIP.Enabled = false;
                            isGettingIP = false;
                        }


                    }
                    catch (Exception ex)
                    {
                        isGettingIP = false;
                        tmrGetIP.Enabled = true;
                    }

                }).Start();

            }

        }
        private void ChangeIP(string txt)
        {
            lblIpPublica.Text = txt;
            lblIpPublica.Visible = true;
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            tl.SetToolTip(label3, "A mayor iteraciones la encriptación será más segura." + Environment.NewLine + "Pero el proceso tomará más tiempo.");

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (!iterar)
            {
                uniqueInfo = true;
                pictureBox2.Image = Properties.Resources.circle_green;

            }
            else
            {
                uniqueInfo = false;
                pictureBox2.Image = Properties.Resources.circle_red;

            }
        }

        private void label11_MouseHover(object sender, EventArgs e)
        {
            tl.SetToolTip(label11, "Se incluirá dentro de la encriptación su IP pública, Nombre del equipo, fecha y hora," + Environment.NewLine + "Sistema operativo, además de datos únicos de su equipo." + Environment.NewLine + "Esto incrementará considerablemente la encriptación," + Environment.NewLine + "Pero también dificultará la desencriptación.");
        }
        private void ReiniciarGUI()
        {
            //  autodestroy = false;
            //  passOk = false;
            //  ipPublicOk = false;
            //  NombreArchivo = "";
            //  rutafull ="";
            //EncryptOK = false;
            //isGettingIP = false;
            //   uniqueInfo = false;


        }


    }
}
