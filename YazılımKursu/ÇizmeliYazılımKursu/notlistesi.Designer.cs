
namespace ÇizmeliYazılımKursu
{
    partial class notlistesi
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtaciklama = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dtgogr = new System.Windows.Forms.DataGridView();
            this.cmbkurs = new System.Windows.Forms.ComboBox();
            this.txtpuan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgpuan = new System.Windows.Forms.DataGridView();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btngeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgogr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgpuan)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(206, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Kurs Seç";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(466, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Açıklama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(185, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Öğrenci No";
            // 
            // txtaciklama
            // 
            this.txtaciklama.Location = new System.Drawing.Point(560, 272);
            this.txtaciklama.Multiline = true;
            this.txtaciklama.Name = "txtaciklama";
            this.txtaciklama.Size = new System.Drawing.Size(305, 106);
            this.txtaciklama.TabIndex = 27;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(293, 269);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(131, 22);
            this.txtId.TabIndex = 25;
            // 
            // dtgogr
            // 
            this.dtgogr.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgogr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgogr.Location = new System.Drawing.Point(636, 32);
            this.dtgogr.Name = "dtgogr";
            this.dtgogr.RowHeadersWidth = 51;
            this.dtgogr.RowTemplate.Height = 24;
            this.dtgogr.Size = new System.Drawing.Size(642, 211);
            this.dtgogr.TabIndex = 24;
            // 
            // cmbkurs
            // 
            this.cmbkurs.FormattingEnabled = true;
            this.cmbkurs.Items.AddRange(new object[] {
            "c# ",
            "MsSql",
            "Java"});
            this.cmbkurs.Location = new System.Drawing.Point(293, 311);
            this.cmbkurs.Name = "cmbkurs";
            this.cmbkurs.Size = new System.Drawing.Size(131, 24);
            this.cmbkurs.TabIndex = 33;
            // 
            // txtpuan
            // 
            this.txtpuan.Location = new System.Drawing.Point(293, 358);
            this.txtpuan.Name = "txtpuan";
            this.txtpuan.Size = new System.Drawing.Size(52, 22);
            this.txtpuan.TabIndex = 34;
            this.txtpuan.TextChanged += new System.EventHandler(this.txtpuan_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(239, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Puan";
            // 
            // dtgpuan
            // 
            this.dtgpuan.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgpuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgpuan.Location = new System.Drawing.Point(2, 32);
            this.dtgpuan.Name = "dtgpuan";
            this.dtgpuan.RowHeadersWidth = 51;
            this.dtgpuan.RowTemplate.Height = 24;
            this.dtgpuan.Size = new System.Drawing.Size(628, 211);
            this.dtgpuan.TabIndex = 37;
            this.dtgpuan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgpuan_CellClick);
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.Bisque;
            this.btnreset.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.Color.Black;
            this.btnreset.Location = new System.Drawing.Point(902, 361);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(106, 32);
            this.btnreset.TabIndex = 38;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = false;
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.Bisque;
            this.btnekle.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnekle.ForeColor = System.Drawing.Color.Black;
            this.btnekle.Location = new System.Drawing.Point(902, 272);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(106, 32);
            this.btnekle.TabIndex = 39;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.Bisque;
            this.btnsil.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsil.ForeColor = System.Drawing.Color.Black;
            this.btnsil.Location = new System.Drawing.Point(902, 318);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(106, 32);
            this.btnsil.TabIndex = 40;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btngeri
            // 
            this.btngeri.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btngeri.Location = new System.Drawing.Point(15, 3);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(48, 23);
            this.btngeri.TabIndex = 41;
            this.btngeri.Text = "<<";
            this.btngeri.UseVisualStyleBackColor = false;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // notlistesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1283, 419);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.dtgpuan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpuan);
            this.Controls.Add(this.cmbkurs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtaciklama);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dtgogr);
            this.Name = "notlistesi";
            this.Text = "notlistesi";
            this.Load += new System.EventHandler(this.notlistesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgogr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgpuan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtaciklama;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridView dtgogr;
        private System.Windows.Forms.ComboBox cmbkurs;
        private System.Windows.Forms.TextBox txtpuan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgpuan;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btngeri;
    }
}