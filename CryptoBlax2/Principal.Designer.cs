namespace CryptoBlax2
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.txtruta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelArchivo = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lblIpPublica = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblfilesize = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericitera = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.loading1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.txtpass1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelPass = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.txtpass2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bwCrypto = new System.ComponentModel.BackgroundWorker();
            this.progressCrypt = new System.Windows.Forms.ProgressBar();
            this.backPercentCheck = new System.ComponentModel.BackgroundWorker();
            this.label10 = new System.Windows.Forms.Label();
            this.tmrGetIP = new System.Windows.Forms.Timer(this.components);
            this.panelArchivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericitera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loading1)).BeginInit();
            this.panelPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // txtruta
            // 
            this.txtruta.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtruta.Location = new System.Drawing.Point(59, 15);
            this.txtruta.Name = "txtruta";
            this.txtruta.ReadOnly = true;
            this.txtruta.Size = new System.Drawing.Size(697, 20);
            this.txtruta.TabIndex = 0;
            this.txtruta.Text = "H:\\Dropbox\\Proyectos Formales\\Propios\\Cuentas\\Cuentas\\bin\\Debug\\Recursos\\test.sql" +
    "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ruta:";
            // 
            // panelArchivo
            // 
            this.panelArchivo.Controls.Add(this.pictureBox7);
            this.panelArchivo.Controls.Add(this.lblIpPublica);
            this.panelArchivo.Controls.Add(this.label9);
            this.panelArchivo.Controls.Add(this.button1);
            this.panelArchivo.Controls.Add(this.lblfilesize);
            this.panelArchivo.Controls.Add(this.label2);
            this.panelArchivo.Controls.Add(this.txtruta);
            this.panelArchivo.Controls.Add(this.label1);
            this.panelArchivo.Location = new System.Drawing.Point(12, 12);
            this.panelArchivo.Name = "panelArchivo";
            this.panelArchivo.Size = new System.Drawing.Size(852, 90);
            this.panelArchivo.TabIndex = 2;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(651, 52);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(40, 35);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 12;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Visible = false;
            // 
            // lblIpPublica
            // 
            this.lblIpPublica.AutoSize = true;
            this.lblIpPublica.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIpPublica.Location = new System.Drawing.Point(648, 61);
            this.lblIpPublica.Name = "lblIpPublica";
            this.lblIpPublica.Size = new System.Drawing.Size(103, 13);
            this.lblIpPublica.TabIndex = 17;
            this.lblIpPublica.Text = "14.12.14.1.1";
            this.lblIpPublica.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(537, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "IP Pública";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(765, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Examinar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblfilesize
            // 
            this.lblfilesize.AutoSize = true;
            this.lblfilesize.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfilesize.Location = new System.Drawing.Point(139, 61);
            this.lblfilesize.Name = "lblfilesize";
            this.lblfilesize.Size = new System.Drawing.Size(0, 13);
            this.lblfilesize.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tamaño Archivo:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(600, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelOpciones
            // 
            this.panelOpciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOpciones.Controls.Add(this.label11);
            this.panelOpciones.Controls.Add(this.label5);
            this.panelOpciones.Controls.Add(this.pictureBox2);
            this.panelOpciones.Controls.Add(this.label3);
            this.panelOpciones.Controls.Add(this.numericitera);
            this.panelOpciones.Controls.Add(this.label4);
            this.panelOpciones.Controls.Add(this.pictureBox3);
            this.panelOpciones.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelOpciones.Location = new System.Drawing.Point(12, 124);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(570, 122);
            this.panelOpciones.TabIndex = 3;
            this.panelOpciones.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(249, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "?";
            this.label11.MouseHover += new System.EventHandler(this.label11_MouseHover);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Incluir información única";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-1, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(156, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "?";
            this.label3.MouseHover += new System.EventHandler(this.label3_MouseHover);
            // 
            // numericitera
            // 
            this.numericitera.Location = new System.Drawing.Point(212, 12);
            this.numericitera.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericitera.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericitera.Name = "numericitera";
            this.numericitera.Size = new System.Drawing.Size(50, 20);
            this.numericitera.TabIndex = 10;
            this.numericitera.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericitera.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Iteraciones";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-1, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // loading1
            // 
            this.loading1.Image = ((System.Drawing.Image)(resources.GetObject("loading1.Image")));
            this.loading1.Location = new System.Drawing.Point(720, 163);
            this.loading1.Name = "loading1";
            this.loading1.Size = new System.Drawing.Size(64, 55);
            this.loading1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loading1.TabIndex = 5;
            this.loading1.TabStop = false;
            this.loading1.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(462, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 39);
            this.button2.TabIndex = 5;
            this.button2.Text = "Listo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtpass1
            // 
            this.txtpass1.Location = new System.Drawing.Point(159, 14);
            this.txtpass1.Name = "txtpass1";
            this.txtpass1.Size = new System.Drawing.Size(233, 20);
            this.txtpass1.TabIndex = 11;
            this.txtpass1.UseSystemPasswordChar = true;
            this.txtpass1.TextChanged += new System.EventHandler(this.txtpass1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Contraseña";
            // 
            // panelPass
            // 
            this.panelPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPass.Controls.Add(this.pictureBox6);
            this.panelPass.Controls.Add(this.progressBar1);
            this.panelPass.Controls.Add(this.label8);
            this.panelPass.Controls.Add(this.txtpass2);
            this.panelPass.Controls.Add(this.label7);
            this.panelPass.Controls.Add(this.txtpass1);
            this.panelPass.Controls.Add(this.label6);
            this.panelPass.Controls.Add(this.button2);
            this.panelPass.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelPass.Location = new System.Drawing.Point(12, 263);
            this.panelPass.Name = "panelPass";
            this.panelPass.Size = new System.Drawing.Size(570, 122);
            this.panelPass.TabIndex = 11;
            this.panelPass.Visible = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(398, 20);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(45, 41);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(159, 86);
            this.progressBar1.MarqueeAnimationSpeed = 50;
            this.progressBar1.Maximum = 30;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(233, 23);
            this.progressBar1.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Seguridad";
            // 
            // txtpass2
            // 
            this.txtpass2.Location = new System.Drawing.Point(159, 49);
            this.txtpass2.Name = "txtpass2";
            this.txtpass2.Size = new System.Drawing.Size(233, 20);
            this.txtpass2.TabIndex = 13;
            this.txtpass2.UseSystemPasswordChar = true;
            this.txtpass2.TextChanged += new System.EventHandler(this.txtpass2_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 26);
            this.label7.TabIndex = 14;
            this.label7.Text = "Verificar\r\nContraseña\r\n";
            // 
            // bwCrypto
            // 
            this.bwCrypto.WorkerReportsProgress = true;
            this.bwCrypto.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwCrypto_DoWork);
            this.bwCrypto.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwCrypto_ProgressChanged);
            // 
            // progressCrypt
            // 
            this.progressCrypt.Location = new System.Drawing.Point(600, 289);
            this.progressCrypt.MarqueeAnimationSpeed = 50;
            this.progressCrypt.Name = "progressCrypt";
            this.progressCrypt.Size = new System.Drawing.Size(114, 23);
            this.progressCrypt.TabIndex = 16;
            // 
            // backPercentCheck
            // 
            this.backPercentCheck.WorkerReportsProgress = true;
            this.backPercentCheck.WorkerSupportsCancellation = true;
            this.backPercentCheck.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backPercentCheck_DoWork);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label10.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(647, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "0";
            // 
            // tmrGetIP
            // 
            this.tmrGetIP.Enabled = true;
            this.tmrGetIP.Interval = 1000;
            this.tmrGetIP.Tick += new System.EventHandler(this.tmrGetIP_Tick);
            // 
            // Principal
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(891, 404);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.progressCrypt);
            this.Controls.Add(this.panelPass);
            this.Controls.Add(this.loading1);
            this.Controls.Add(this.panelOpciones);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelArchivo);
            this.Name = "Principal";
            this.Text = "Crypto Blax";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter_1);
            this.panelArchivo.ResumeLayout(false);
            this.panelArchivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelOpciones.ResumeLayout(false);
            this.panelOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericitera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loading1)).EndInit();
            this.panelPass.ResumeLayout(false);
            this.panelPass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtruta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelArchivo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelOpciones;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblfilesize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericitera;
        private System.Windows.Forms.PictureBox loading1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtpass1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelPass;
        private System.Windows.Forms.TextBox txtpass2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.ComponentModel.BackgroundWorker bwCrypto;
        private System.Windows.Forms.Label lblIpPublica;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.ProgressBar progressCrypt;
        private System.ComponentModel.BackgroundWorker backPercentCheck;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer tmrGetIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

