
namespace SolutionSepet.UI
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxKargoUcreti = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxGemiAd = new System.Windows.Forms.TextBox();
            this.textBoxAdres = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxsehir = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxurunAd = new System.Windows.Forms.ComboBox();
            this.comboBoxkargoAd = new System.Windows.Forms.ComboBox();
            this.btnSiparisVer = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblurunId = new System.Windows.Forms.Label();
            this.dateTimePickersiparis = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickeristenen = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerkargo = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxIndırım = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDownAdet = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxSatisFiyat = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Siparis Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 238);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "İstenen Tarih:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 298);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "KargoTarih:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 364);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kargo Adı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 421);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Kargo Ücreti:";
            // 
            // textBoxKargoUcreti
            // 
            this.textBoxKargoUcreti.Location = new System.Drawing.Point(239, 421);
            this.textBoxKargoUcreti.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxKargoUcreti.Name = "textBoxKargoUcreti";
            this.textBoxKargoUcreti.Size = new System.Drawing.Size(132, 22);
            this.textBoxKargoUcreti.TabIndex = 11;
            this.textBoxKargoUcreti.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKargoUcreti_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(468, 49);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Gemi Adı: ";
            // 
            // textBoxGemiAd
            // 
            this.textBoxGemiAd.Location = new System.Drawing.Point(549, 46);
            this.textBoxGemiAd.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGemiAd.Name = "textBoxGemiAd";
            this.textBoxGemiAd.Size = new System.Drawing.Size(132, 22);
            this.textBoxGemiAd.TabIndex = 13;
            // 
            // textBoxAdres
            // 
            this.textBoxAdres.Location = new System.Drawing.Point(549, 108);
            this.textBoxAdres.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAdres.Name = "textBoxAdres";
            this.textBoxAdres.Size = new System.Drawing.Size(132, 22);
            this.textBoxAdres.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(468, 112);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Adresi";
            // 
            // textBoxsehir
            // 
            this.textBoxsehir.Location = new System.Drawing.Point(549, 171);
            this.textBoxsehir.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxsehir.Name = "textBoxsehir";
            this.textBoxsehir.Size = new System.Drawing.Size(132, 22);
            this.textBoxsehir.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(468, 175);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Şehir:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(95, 76);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Ürün Adı:";
            // 
            // comboBoxurunAd
            // 
            this.comboBoxurunAd.FormattingEnabled = true;
            this.comboBoxurunAd.Location = new System.Drawing.Point(211, 66);
            this.comboBoxurunAd.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxurunAd.Name = "comboBoxurunAd";
            this.comboBoxurunAd.Size = new System.Drawing.Size(160, 24);
            this.comboBoxurunAd.TabIndex = 19;
            // 
            // comboBoxkargoAd
            // 
            this.comboBoxkargoAd.FormattingEnabled = true;
            this.comboBoxkargoAd.Location = new System.Drawing.Point(225, 354);
            this.comboBoxkargoAd.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxkargoAd.Name = "comboBoxkargoAd";
            this.comboBoxkargoAd.Size = new System.Drawing.Size(160, 24);
            this.comboBoxkargoAd.TabIndex = 20;
            // 
            // btnSiparisVer
            // 
            this.btnSiparisVer.Location = new System.Drawing.Point(717, 76);
            this.btnSiparisVer.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiparisVer.Name = "btnSiparisVer";
            this.btnSiparisVer.Size = new System.Drawing.Size(135, 43);
            this.btnSiparisVer.TabIndex = 21;
            this.btnSiparisVer.Text = "Siparis Ver ";
            this.btnSiparisVer.UseVisualStyleBackColor = true;
            this.btnSiparisVer.Click += new System.EventHandler(this.btnSiparisVer_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(239, 116);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(28, 16);
            this.lblId.TabIndex = 22;
            this.lblId.Text = "___";
            // 
            // lblurunId
            // 
            this.lblurunId.AutoSize = true;
            this.lblurunId.Location = new System.Drawing.Point(92, 34);
            this.lblurunId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblurunId.Name = "lblurunId";
            this.lblurunId.Size = new System.Drawing.Size(52, 16);
            this.lblurunId.TabIndex = 23;
            this.lblurunId.Text = "Ürün Id:";
            // 
            // dateTimePickersiparis
            // 
            this.dateTimePickersiparis.Location = new System.Drawing.Point(211, 171);
            this.dateTimePickersiparis.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickersiparis.Name = "dateTimePickersiparis";
            this.dateTimePickersiparis.Size = new System.Drawing.Size(191, 22);
            this.dateTimePickersiparis.TabIndex = 30;
            // 
            // dateTimePickeristenen
            // 
            this.dateTimePickeristenen.Location = new System.Drawing.Point(211, 234);
            this.dateTimePickeristenen.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickeristenen.Name = "dateTimePickeristenen";
            this.dateTimePickeristenen.Size = new System.Drawing.Size(191, 22);
            this.dateTimePickeristenen.TabIndex = 31;
            // 
            // dateTimePickerkargo
            // 
            this.dateTimePickerkargo.Location = new System.Drawing.Point(211, 295);
            this.dateTimePickerkargo.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerkargo.Name = "dateTimePickerkargo";
            this.dateTimePickerkargo.Size = new System.Drawing.Size(191, 22);
            this.dateTimePickerkargo.TabIndex = 32;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.textBoxIndırım);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.numericUpDownAdet);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBoxSatisFiyat);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(530, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 231);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Detay";
            this.groupBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 55);
            this.button1.TabIndex = 41;
            this.button1.Text = "Ürün Detayını Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 177);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 16);
            this.label14.TabIndex = 40;
            this.label14.Text = "label14";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // textBoxIndırım
            // 
            this.textBoxIndırım.Location = new System.Drawing.Point(94, 128);
            this.textBoxIndırım.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIndırım.Name = "textBoxIndırım";
            this.textBoxIndırım.Size = new System.Drawing.Size(132, 22);
            this.textBoxIndırım.TabIndex = 39;
            this.textBoxIndırım.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIndırım_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 136);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 16);
            this.label13.TabIndex = 38;
            this.label13.Text = "İndirim:";
            // 
            // numericUpDownAdet
            // 
            this.numericUpDownAdet.Location = new System.Drawing.Point(94, 77);
            this.numericUpDownAdet.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownAdet.Name = "numericUpDownAdet";
            this.numericUpDownAdet.Size = new System.Drawing.Size(160, 22);
            this.numericUpDownAdet.TabIndex = 37;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 80);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 16);
            this.label12.TabIndex = 36;
            this.label12.Text = "Adet:";
            // 
            // textBoxSatisFiyat
            // 
            this.textBoxSatisFiyat.Location = new System.Drawing.Point(94, 16);
            this.textBoxSatisFiyat.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSatisFiyat.Name = "textBoxSatisFiyat";
            this.textBoxSatisFiyat.Size = new System.Drawing.Size(132, 22);
            this.textBoxSatisFiyat.TabIndex = 35;
            this.textBoxSatisFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSatisFiyat_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 20);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 16);
            this.label11.TabIndex = 34;
            this.label11.Text = "Satış Fiyatı:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 522);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePickerkargo);
            this.Controls.Add(this.dateTimePickeristenen);
            this.Controls.Add(this.dateTimePickersiparis);
            this.Controls.Add(this.lblurunId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnSiparisVer);
            this.Controls.Add(this.comboBoxkargoAd);
            this.Controls.Add(this.comboBoxurunAd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxsehir);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxAdres);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxGemiAd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxKargoUcreti);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sipariş Detay";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxKargoUcreti;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxGemiAd;
        private System.Windows.Forms.TextBox textBoxAdres;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxsehir;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxurunAd;
        private System.Windows.Forms.ComboBox comboBoxkargoAd;
        private System.Windows.Forms.Button btnSiparisVer;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblurunId;
        private System.Windows.Forms.DateTimePicker dateTimePickersiparis;
        private System.Windows.Forms.DateTimePicker dateTimePickeristenen;
        private System.Windows.Forms.DateTimePicker dateTimePickerkargo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxIndırım;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericUpDownAdet;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxSatisFiyat;
        private System.Windows.Forms.Label label11;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}