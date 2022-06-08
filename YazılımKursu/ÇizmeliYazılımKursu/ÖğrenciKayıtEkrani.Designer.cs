
namespace ÇizmeliYazılımKursu
{
    partial class ÖğrenciKayıtEkrani
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
            this.kayitdtg = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtadsoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txttelefon = new System.Windows.Forms.TextBox();
            this.dttrh = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbcinsiyet = new System.Windows.Forms.ComboBox();
            this.txtadres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnyukle = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.Kayit = new System.Windows.Forms.GroupBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btngeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kayitdtg)).BeginInit();
            this.Kayit.SuspendLayout();
            this.SuspendLayout();
            // 
            // kayitdtg
            // 
            this.kayitdtg.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.kayitdtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kayitdtg.Location = new System.Drawing.Point(79, 12);
            this.kayitdtg.Name = "kayitdtg";
            this.kayitdtg.RowHeadersWidth = 51;
            this.kayitdtg.RowTemplate.Height = 24;
            this.kayitdtg.Size = new System.Drawing.Size(754, 179);
            this.kayitdtg.TabIndex = 0;
            this.kayitdtg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kayitdtg_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad Soyad";
            // 
            // txtadsoyad
            // 
            this.txtadsoyad.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtadsoyad.Location = new System.Drawing.Point(157, 21);
            this.txtadsoyad.Name = "txtadsoyad";
            this.txtadsoyad.Size = new System.Drawing.Size(100, 22);
            this.txtadsoyad.TabIndex = 2;
            this.txtadsoyad.TextChanged += new System.EventHandler(this.txtadsoyad_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(300, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Doğum Tarihi";
            // 
            // txttelefon
            // 
            this.txttelefon.Location = new System.Drawing.Point(382, 24);
            this.txttelefon.Name = "txttelefon";
            this.txttelefon.Size = new System.Drawing.Size(165, 22);
            this.txttelefon.TabIndex = 5;
            // 
            // dttrh
            // 
            this.dttrh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttrh.Location = new System.Drawing.Point(157, 62);
            this.dttrh.Name = "dttrh";
            this.dttrh.Size = new System.Drawing.Size(97, 22);
            this.dttrh.TabIndex = 6;
            this.dttrh.ValueChanged += new System.EventHandler(this.dttrh_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(299, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cinsiyet";
            // 
            // cmbcinsiyet
            // 
            this.cmbcinsiyet.FormattingEnabled = true;
            this.cmbcinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbcinsiyet.Location = new System.Drawing.Point(382, 66);
            this.cmbcinsiyet.Name = "cmbcinsiyet";
            this.cmbcinsiyet.Size = new System.Drawing.Size(165, 24);
            this.cmbcinsiyet.Sorted = true;
            this.cmbcinsiyet.TabIndex = 8;
            // 
            // txtadres
            // 
            this.txtadres.Location = new System.Drawing.Point(80, 105);
            this.txtadres.Multiline = true;
            this.txtadres.Name = "txtadres";
            this.txtadres.Size = new System.Drawing.Size(193, 120);
            this.txtadres.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Adres";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnyukle
            // 
            this.btnyukle.BackColor = System.Drawing.Color.Bisque;
            this.btnyukle.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnyukle.Location = new System.Drawing.Point(438, 142);
            this.btnyukle.Name = "btnyukle";
            this.btnyukle.Size = new System.Drawing.Size(109, 58);
            this.btnyukle.TabIndex = 11;
            this.btnyukle.Text = "Sütunları Temizle";
            this.btnyukle.UseVisualStyleBackColor = false;
            this.btnyukle.Click += new System.EventHandler(this.btnyukle_Click);
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.Bisque;
            this.btnekle.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnekle.Location = new System.Drawing.Point(302, 142);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(112, 58);
            this.btnekle.TabIndex = 12;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.button2_Click);
            // 
            // Kayit
            // 
            this.Kayit.BackColor = System.Drawing.SystemColors.Info;
            this.Kayit.Controls.Add(this.btnsil);
            this.Kayit.Controls.Add(this.txtadsoyad);
            this.Kayit.Controls.Add(this.label1);
            this.Kayit.Controls.Add(this.btnekle);
            this.Kayit.Controls.Add(this.dttrh);
            this.Kayit.Controls.Add(this.btnyukle);
            this.Kayit.Controls.Add(this.label3);
            this.Kayit.Controls.Add(this.cmbcinsiyet);
            this.Kayit.Controls.Add(this.label5);
            this.Kayit.Controls.Add(this.label4);
            this.Kayit.Controls.Add(this.txtadres);
            this.Kayit.Controls.Add(this.label2);
            this.Kayit.Controls.Add(this.txttelefon);
            this.Kayit.Location = new System.Drawing.Point(116, 197);
            this.Kayit.Name = "Kayit";
            this.Kayit.Size = new System.Drawing.Size(682, 241);
            this.Kayit.TabIndex = 14;
            this.Kayit.TabStop = false;
            this.Kayit.Text = "Öğrecnci Kayıt Ekranı";
            this.Kayit.Enter += new System.EventHandler(this.Kayit_Enter);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.Bisque;
            this.btnsil.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsil.Location = new System.Drawing.Point(567, 142);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(109, 58);
            this.btnsil.TabIndex = 13;
            this.btnsil.Text = "Kayıt Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Unispace", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(291, 442);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(372, 34);
            this.label6.TabIndex = 26;
            this.label6.Text = "Çizmeli Yazılım Kursu";
            // 
            // btngeri
            // 
            this.btngeri.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btngeri.Location = new System.Drawing.Point(27, 12);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(35, 35);
            this.btngeri.TabIndex = 27;
            this.btngeri.Text = "<<";
            this.btngeri.UseVisualStyleBackColor = false;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // ÖğrenciKayıtEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(911, 485);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Kayit);
            this.Controls.Add(this.kayitdtg);
            this.Name = "ÖğrenciKayıtEkrani";
            this.Text = "KayıtEkrani";
            this.Load += new System.EventHandler(this.KayıtEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kayitdtg)).EndInit();
            this.Kayit.ResumeLayout(false);
            this.Kayit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView kayitdtg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtadsoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttelefon;
        private System.Windows.Forms.DateTimePicker dttrh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbcinsiyet;
        private System.Windows.Forms.TextBox txtadres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnyukle;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.GroupBox Kayit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btngeri;
    }
}