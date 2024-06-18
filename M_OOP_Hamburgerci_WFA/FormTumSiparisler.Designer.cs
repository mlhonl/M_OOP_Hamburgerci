namespace M_OOP_Hamburgerci_WFA
{
    partial class FormTumSiparisler
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
            lstTumSiparisler = new ListBox();
            label1 = new Label();
            grpCiro = new GroupBox();
            lblCiro = new Label();
            grpToplamSiparisGeliri = new GroupBox();
            lblToplamSiparisSayisi = new Label();
            grpSatilanUrunAdeti = new GroupBox();
            lblSatilanUrunAdeti = new Label();
            groupBox1 = new GroupBox();
            lblEkstraMalzemeGeliri = new Label();
            grpCiro.SuspendLayout();
            grpToplamSiparisGeliri.SuspendLayout();
            grpSatilanUrunAdeti.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lstTumSiparisler
            // 
            lstTumSiparisler.FormattingEnabled = true;
            lstTumSiparisler.ItemHeight = 15;
            lstTumSiparisler.Location = new Point(32, 50);
            lstTumSiparisler.Name = "lstTumSiparisler";
            lstTumSiparisler.Size = new Size(228, 394);
            lstTumSiparisler.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(32, 18);
            label1.Name = "label1";
            label1.Size = new Size(118, 19);
            label1.TabIndex = 1;
            label1.Text = "TÜM SİPARİŞLER";
            // 
            // grpCiro
            // 
            grpCiro.Controls.Add(lblCiro);
            grpCiro.Location = new Point(316, 50);
            grpCiro.Name = "grpCiro";
            grpCiro.Size = new Size(222, 76);
            grpCiro.TabIndex = 2;
            grpCiro.TabStop = false;
            grpCiro.Text = "CİRO";
            // 
            // lblCiro
            // 
            lblCiro.AutoSize = true;
            lblCiro.ForeColor = Color.Red;
            lblCiro.Location = new Point(15, 37);
            lblCiro.Name = "lblCiro";
            lblCiro.Size = new Size(13, 15);
            lblCiro.TabIndex = 0;
            lblCiro.Text = "0";
            // 
            // grpToplamSiparisGeliri
            // 
            grpToplamSiparisGeliri.Controls.Add(lblToplamSiparisSayisi);
            grpToplamSiparisGeliri.Location = new Point(316, 147);
            grpToplamSiparisGeliri.Name = "grpToplamSiparisGeliri";
            grpToplamSiparisGeliri.Size = new Size(222, 78);
            grpToplamSiparisGeliri.TabIndex = 2;
            grpToplamSiparisGeliri.TabStop = false;
            grpToplamSiparisGeliri.Text = "TOPLAM SİPARİŞ SAYISI";
            // 
            // lblToplamSiparisSayisi
            // 
            lblToplamSiparisSayisi.AutoSize = true;
            lblToplamSiparisSayisi.ForeColor = Color.Red;
            lblToplamSiparisSayisi.Location = new Point(15, 37);
            lblToplamSiparisSayisi.Name = "lblToplamSiparisSayisi";
            lblToplamSiparisSayisi.Size = new Size(13, 15);
            lblToplamSiparisSayisi.TabIndex = 0;
            lblToplamSiparisSayisi.Text = "0";
            // 
            // grpSatilanUrunAdeti
            // 
            grpSatilanUrunAdeti.Controls.Add(lblSatilanUrunAdeti);
            grpSatilanUrunAdeti.Location = new Point(316, 362);
            grpSatilanUrunAdeti.Name = "grpSatilanUrunAdeti";
            grpSatilanUrunAdeti.Size = new Size(222, 82);
            grpSatilanUrunAdeti.TabIndex = 2;
            grpSatilanUrunAdeti.TabStop = false;
            grpSatilanUrunAdeti.Text = "SATILAN ÜRÜN ADETİ";
            // 
            // lblSatilanUrunAdeti
            // 
            lblSatilanUrunAdeti.AutoSize = true;
            lblSatilanUrunAdeti.ForeColor = Color.Red;
            lblSatilanUrunAdeti.Location = new Point(15, 37);
            lblSatilanUrunAdeti.Name = "lblSatilanUrunAdeti";
            lblSatilanUrunAdeti.Size = new Size(13, 15);
            lblSatilanUrunAdeti.TabIndex = 0;
            lblSatilanUrunAdeti.Text = "0";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblEkstraMalzemeGeliri);
            groupBox1.Location = new Point(316, 252);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(222, 80);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "EKSTRA MALZEME GELİRİ";
            // 
            // lblEkstraMalzemeGeliri
            // 
            lblEkstraMalzemeGeliri.AutoSize = true;
            lblEkstraMalzemeGeliri.ForeColor = Color.Red;
            lblEkstraMalzemeGeliri.Location = new Point(15, 37);
            lblEkstraMalzemeGeliri.Name = "lblEkstraMalzemeGeliri";
            lblEkstraMalzemeGeliri.Size = new Size(13, 15);
            lblEkstraMalzemeGeliri.TabIndex = 0;
            lblEkstraMalzemeGeliri.Text = "0";
            // 
            // FormTumSiparisler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(556, 470);
            Controls.Add(groupBox1);
            Controls.Add(grpSatilanUrunAdeti);
            Controls.Add(grpToplamSiparisGeliri);
            Controls.Add(grpCiro);
            Controls.Add(label1);
            Controls.Add(lstTumSiparisler);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormTumSiparisler";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTumSiparisler";
            Load += FormTumSiparisler_Load;
            grpCiro.ResumeLayout(false);
            grpCiro.PerformLayout();
            grpToplamSiparisGeliri.ResumeLayout(false);
            grpToplamSiparisGeliri.PerformLayout();
            grpSatilanUrunAdeti.ResumeLayout(false);
            grpSatilanUrunAdeti.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstTumSiparisler;
        private Label label1;
        private GroupBox grpCiro;
        private Label lblCiro;
        private GroupBox grpToplamSiparisGeliri;
        private Label lblToplamSiparisSayisi;
        private GroupBox grpSatilanUrunAdeti;
        private Label lblSatilanUrunAdeti;
        private GroupBox groupBox1;
        private Label lblEkstraMalzemeGeliri;
    }
}