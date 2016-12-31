namespace InsanKaynaklari
{
    partial class Form1
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
            this.cmbElemanTuru = new System.Windows.Forms.ComboBox();
            this.numTCKimlikNo = new System.Windows.Forms.NumericUpDown();
            this.numMaas = new System.Windows.Forms.NumericUpDown();
            this.NumSatisAdeti = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            this.lstBoxCalisanlar = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numTCKimlikNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumSatisAdeti)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbElemanTuru
            // 
            this.cmbElemanTuru.FormattingEnabled = true;
            this.cmbElemanTuru.Location = new System.Drawing.Point(9, 25);
            this.cmbElemanTuru.Name = "cmbElemanTuru";
            this.cmbElemanTuru.Size = new System.Drawing.Size(121, 21);
            this.cmbElemanTuru.TabIndex = 0;
            // 
            // numTCKimlikNo
            // 
            this.numTCKimlikNo.Location = new System.Drawing.Point(9, 68);
            this.numTCKimlikNo.Name = "numTCKimlikNo";
            this.numTCKimlikNo.Size = new System.Drawing.Size(120, 20);
            this.numTCKimlikNo.TabIndex = 1;
            // 
            // numMaas
            // 
            this.numMaas.Location = new System.Drawing.Point(9, 104);
            this.numMaas.Name = "numMaas";
            this.numMaas.Size = new System.Drawing.Size(120, 20);
            this.numMaas.TabIndex = 2;
            // 
            // NumSatisAdeti
            // 
            this.NumSatisAdeti.Location = new System.Drawing.Point(9, 143);
            this.NumSatisAdeti.Name = "NumSatisAdeti";
            this.NumSatisAdeti.Size = new System.Drawing.Size(120, 20);
            this.NumSatisAdeti.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Eleman Türü";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "T.C. Kimlik No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Maaş";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Satış Adeti";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEkle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEkle.Location = new System.Drawing.Point(9, 169);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(91, 169);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(39, 20);
            this.btnYenile.TabIndex = 9;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // lstBoxCalisanlar
            // 
            this.lstBoxCalisanlar.FormattingEnabled = true;
            this.lstBoxCalisanlar.Location = new System.Drawing.Point(136, 25);
            this.lstBoxCalisanlar.Name = "lstBoxCalisanlar";
            this.lstBoxCalisanlar.Size = new System.Drawing.Size(222, 160);
            this.lstBoxCalisanlar.TabIndex = 10;
            this.lstBoxCalisanlar.DoubleClick += new System.EventHandler(this.lstBoxCalisanlar_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 203);
            this.Controls.Add(this.lstBoxCalisanlar);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumSatisAdeti);
            this.Controls.Add(this.numMaas);
            this.Controls.Add(this.numTCKimlikNo);
            this.Controls.Add(this.cmbElemanTuru);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTCKimlikNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumSatisAdeti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbElemanTuru;
        private System.Windows.Forms.NumericUpDown numTCKimlikNo;
        private System.Windows.Forms.NumericUpDown numMaas;
        private System.Windows.Forms.NumericUpDown NumSatisAdeti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.ListBox lstBoxCalisanlar;
    }
}

