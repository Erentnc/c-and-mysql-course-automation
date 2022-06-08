
namespace ÇizmeliYazılımKursu
{
    partial class ToplamOgrListesi
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
            this.dtglist = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnara = new System.Windows.Forms.Button();
            this.txtfiltre = new System.Windows.Forms.TextBox();
            this.btnyenile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtglist)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtglist
            // 
            this.dtglist.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtglist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtglist.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dtglist.Location = new System.Drawing.Point(12, 63);
            this.dtglist.Name = "dtglist";
            this.dtglist.RowHeadersWidth = 51;
            this.dtglist.RowTemplate.Height = 24;
            this.dtglist.Size = new System.Drawing.Size(776, 383);
            this.dtglist.TabIndex = 25;
            this.dtglist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtglist_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnara);
            this.panel2.Controls.Add(this.txtfiltre);
            this.panel2.Controls.Add(this.btnyenile);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 45);
            this.panel2.TabIndex = 27;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(23, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "<<";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(119, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "Öğrenci Arama Paneli";
            // 
            // btnara
            // 
            this.btnara.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnara.Location = new System.Drawing.Point(604, 11);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(75, 26);
            this.btnara.TabIndex = 4;
            this.btnara.Text = "Ara";
            this.btnara.UseVisualStyleBackColor = false;
            this.btnara.Click += new System.EventHandler(this.btnara_Click_1);
            // 
            // txtfiltre
            // 
            this.txtfiltre.Location = new System.Drawing.Point(359, 13);
            this.txtfiltre.Name = "txtfiltre";
            this.txtfiltre.Size = new System.Drawing.Size(215, 22);
            this.txtfiltre.TabIndex = 3;
            // 
            // btnyenile
            // 
            this.btnyenile.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnyenile.Location = new System.Drawing.Point(685, 11);
            this.btnyenile.Name = "btnyenile";
            this.btnyenile.Size = new System.Drawing.Size(75, 26);
            this.btnyenile.TabIndex = 2;
            this.btnyenile.Text = "Yenile";
            this.btnyenile.UseVisualStyleBackColor = false;
            this.btnyenile.Click += new System.EventHandler(this.btnyenile_Click);
            // 
            // ToplamOgrListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dtglist);
            this.Name = "ToplamOgrListesi";
            this.Text = "ToplamOgrListesi";
            this.Load += new System.EventHandler(this.ToplamOgrListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtglist)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtglist;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnyenile;
        private System.Windows.Forms.TextBox txtfiltre;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}