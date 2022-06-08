
namespace ÇizmeliYazılımKursu
{
    partial class kursyenikurskaydı
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
            System.Windows.Forms.GroupBox yenikayıt;
            this.btnekle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtaciklama = new System.Windows.Forms.TextBox();
            this.txtkursadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsaat = new System.Windows.Forms.TextBox();
            this.dtgyenikurs = new System.Windows.Forms.DataGridView();
            this.btnsil = new System.Windows.Forms.Button();
            yenikayıt = new System.Windows.Forms.GroupBox();
            yenikayıt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgyenikurs)).BeginInit();
            this.SuspendLayout();
            // 
            // yenikayıt
            // 
            yenikayıt.BackColor = System.Drawing.SystemColors.Info;
            yenikayıt.Controls.Add(this.btnekle);
            yenikayıt.Controls.Add(this.label2);
            yenikayıt.Controls.Add(this.label3);
            yenikayıt.Controls.Add(this.txtaciklama);
            yenikayıt.Controls.Add(this.txtkursadi);
            yenikayıt.Controls.Add(this.label1);
            yenikayıt.Controls.Add(this.txtsaat);
            yenikayıt.Location = new System.Drawing.Point(23, 202);
            yenikayıt.Name = "yenikayıt";
            yenikayıt.Size = new System.Drawing.Size(343, 182);
            yenikayıt.TabIndex = 25;
            yenikayıt.TabStop = false;
            yenikayıt.Text = "Ders Ekleme Ekranı";
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.Bisque;
            this.btnekle.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.Location = new System.Drawing.Point(217, 100);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(95, 49);
            this.btnekle.TabIndex = 22;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Açıklama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Saat";
            // 
            // txtaciklama
            // 
            this.txtaciklama.Location = new System.Drawing.Point(90, 127);
            this.txtaciklama.Name = "txtaciklama";
            this.txtaciklama.Size = new System.Drawing.Size(100, 22);
            this.txtaciklama.TabIndex = 17;
            // 
            // txtkursadi
            // 
            this.txtkursadi.Location = new System.Drawing.Point(90, 32);
            this.txtkursadi.Name = "txtkursadi";
            this.txtkursadi.Size = new System.Drawing.Size(100, 22);
            this.txtkursadi.TabIndex = 15;
            this.txtkursadi.TextChanged += new System.EventHandler(this.txtkursadi_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Kurs Adı";
            // 
            // txtsaat
            // 
            this.txtsaat.Location = new System.Drawing.Point(90, 83);
            this.txtsaat.Name = "txtsaat";
            this.txtsaat.Size = new System.Drawing.Size(100, 22);
            this.txtsaat.TabIndex = 16;
            // 
            // dtgyenikurs
            // 
            this.dtgyenikurs.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgyenikurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgyenikurs.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgyenikurs.Location = new System.Drawing.Point(23, 46);
            this.dtgyenikurs.Name = "dtgyenikurs";
            this.dtgyenikurs.RowHeadersWidth = 51;
            this.dtgyenikurs.RowTemplate.Height = 24;
            this.dtgyenikurs.Size = new System.Drawing.Size(589, 150);
            this.dtgyenikurs.TabIndex = 0;
            this.dtgyenikurs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgyenikurs_CellClick);
            this.dtgyenikurs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgyenikurs_CellContentClick);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsil.Location = new System.Drawing.Point(23, 17);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(42, 23);
            this.btnsil.TabIndex = 26;
            this.btnsil.Text = "<";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // kursyenikurskaydı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(624, 386);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(yenikayıt);
            this.Controls.Add(this.dtgyenikurs);
            this.Name = "kursyenikurskaydı";
            this.Text = "yenikurskaydı";
            this.Load += new System.EventHandler(this.yenikurskaydı_Load);
            yenikayıt.ResumeLayout(false);
            yenikayıt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgyenikurs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgyenikurs;
        private System.Windows.Forms.TextBox txtkursadi;
        private System.Windows.Forms.TextBox txtsaat;
        private System.Windows.Forms.TextBox txtaciklama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnsil;
    }
}