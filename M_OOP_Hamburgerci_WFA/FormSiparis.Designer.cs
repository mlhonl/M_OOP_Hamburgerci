namespace M_OOP_Hamburgerci_WFA
{
    partial class FormSiparis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSiparis));
            pbLogo = new PictureBox();
            label1 = new Label();
            cmbMenuler = new ComboBox();
            grpBoyut = new GroupBox();
            rdbBuyuk = new RadioButton();
            rdbOrta = new RadioButton();
            rdbKucuk = new RadioButton();
            label2 = new Label();
            flpEkstraMalzemeler = new FlowLayoutPanel();
            label3 = new Label();
            nmrAdet = new NumericUpDown();
            btnSiparisEkle = new Button();
            lstSiparisler = new ListBox();
            lblToplamTutar = new Label();
            label5 = new Label();
            btnSiparisTamamla = new Button();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            grpBoyut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrAdet).BeginInit();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(13, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(233, 156);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(65, 171);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 1;
            label1.Text = "MENÜ SEÇİNİZ";
            // 
            // cmbMenuler
            // 
            cmbMenuler.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMenuler.FormattingEnabled = true;
            cmbMenuler.Location = new Point(13, 205);
            cmbMenuler.Name = "cmbMenuler";
            cmbMenuler.Size = new Size(233, 23);
            cmbMenuler.TabIndex = 2;
            // 
            // grpBoyut
            // 
            grpBoyut.Controls.Add(rdbBuyuk);
            grpBoyut.Controls.Add(rdbOrta);
            grpBoyut.Controls.Add(rdbKucuk);
            grpBoyut.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            grpBoyut.ForeColor = Color.Green;
            grpBoyut.Location = new Point(13, 252);
            grpBoyut.Name = "grpBoyut";
            grpBoyut.Size = new Size(233, 92);
            grpBoyut.TabIndex = 3;
            grpBoyut.TabStop = false;
            grpBoyut.Text = "BOYUT SEÇİNİZ";
            // 
            // rdbBuyuk
            // 
            rdbBuyuk.AutoSize = true;
            rdbBuyuk.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rdbBuyuk.Location = new Point(148, 41);
            rdbBuyuk.Name = "rdbBuyuk";
            rdbBuyuk.Size = new Size(65, 23);
            rdbBuyuk.TabIndex = 0;
            rdbBuyuk.TabStop = true;
            rdbBuyuk.Text = "Büyük";
            rdbBuyuk.UseVisualStyleBackColor = true;
            // 
            // rdbOrta
            // 
            rdbOrta.AutoSize = true;
            rdbOrta.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rdbOrta.Location = new Point(87, 41);
            rdbOrta.Name = "rdbOrta";
            rdbOrta.Size = new Size(55, 23);
            rdbOrta.TabIndex = 0;
            rdbOrta.TabStop = true;
            rdbOrta.Text = "Orta";
            rdbOrta.UseVisualStyleBackColor = true;
            // 
            // rdbKucuk
            // 
            rdbKucuk.AutoSize = true;
            rdbKucuk.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rdbKucuk.Location = new Point(17, 41);
            rdbKucuk.Name = "rdbKucuk";
            rdbKucuk.Size = new Size(64, 23);
            rdbKucuk.TabIndex = 0;
            rdbKucuk.TabStop = true;
            rdbKucuk.Text = "Küçük";
            rdbKucuk.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(12, 363);
            label2.Name = "label2";
            label2.Size = new Size(201, 20);
            label2.TabIndex = 1;
            label2.Text = "EKSTRA MALZEME SEÇİNİZ";
            // 
            // flpEkstraMalzemeler
            // 
            flpEkstraMalzemeler.Location = new Point(13, 398);
            flpEkstraMalzemeler.Name = "flpEkstraMalzemeler";
            flpEkstraMalzemeler.Size = new Size(233, 98);
            flpEkstraMalzemeler.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(13, 512);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 5;
            label3.Text = "ADET";
            // 
            // nmrAdet
            // 
            nmrAdet.Location = new Point(81, 512);
            nmrAdet.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmrAdet.Name = "nmrAdet";
            nmrAdet.Size = new Size(165, 23);
            nmrAdet.TabIndex = 6;
            nmrAdet.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnSiparisEkle
            // 
            btnSiparisEkle.BackColor = Color.Green;
            btnSiparisEkle.ForeColor = Color.Transparent;
            btnSiparisEkle.Location = new Point(81, 552);
            btnSiparisEkle.Name = "btnSiparisEkle";
            btnSiparisEkle.Size = new Size(165, 67);
            btnSiparisEkle.TabIndex = 7;
            btnSiparisEkle.Text = "SİPARİŞ EKLE";
            btnSiparisEkle.UseVisualStyleBackColor = false;
            btnSiparisEkle.Click += btnSiparisEkle_Click;
            // 
            // lstSiparisler
            // 
            lstSiparisler.FormattingEnabled = true;
            lstSiparisler.ItemHeight = 15;
            lstSiparisler.Location = new Point(267, 12);
            lstSiparisler.Name = "lstSiparisler";
            lstSiparisler.Size = new Size(641, 439);
            lstSiparisler.TabIndex = 8;
            // 
            // lblToplamTutar
            // 
            lblToplamTutar.AutoSize = true;
            lblToplamTutar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblToplamTutar.ForeColor = Color.Red;
            lblToplamTutar.Location = new Point(548, 512);
            lblToplamTutar.Name = "lblToplamTutar";
            lblToplamTutar.Size = new Size(17, 19);
            lblToplamTutar.TabIndex = 5;
            lblToplamTutar.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(495, 476);
            label5.Name = "label5";
            label5.Size = new Size(123, 20);
            label5.TabIndex = 5;
            label5.Text = "TOPLAM TUTAR";
            // 
            // btnSiparisTamamla
            // 
            btnSiparisTamamla.BackColor = Color.RoyalBlue;
            btnSiparisTamamla.ForeColor = Color.Transparent;
            btnSiparisTamamla.Location = new Point(743, 468);
            btnSiparisTamamla.Name = "btnSiparisTamamla";
            btnSiparisTamamla.Size = new Size(165, 67);
            btnSiparisTamamla.TabIndex = 7;
            btnSiparisTamamla.Text = "SİPARİŞİ TAMAMLA";
            btnSiparisTamamla.UseVisualStyleBackColor = false;
            btnSiparisTamamla.Click += btnSiparisTamamla_Click;
            // 
            // FormSiparis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 661);
            Controls.Add(lstSiparisler);
            Controls.Add(btnSiparisTamamla);
            Controls.Add(btnSiparisEkle);
            Controls.Add(lblToplamTutar);
            Controls.Add(nmrAdet);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(flpEkstraMalzemeler);
            Controls.Add(grpBoyut);
            Controls.Add(cmbMenuler);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbLogo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSiparis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormSiparis";
            Load += FormSiparis_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            grpBoyut.ResumeLayout(false);
            grpBoyut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrAdet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogo;
        private Label label1;
        private ComboBox cmbMenuler;
        private GroupBox grpBoyut;
        private RadioButton rdbBuyuk;
        private RadioButton rdbOrta;
        private RadioButton rdbKucuk;
        private Label label2;
        private FlowLayoutPanel flpEkstraMalzemeler;
        private Label label3;
        private NumericUpDown nmrAdet;
        private Button btnSiparisEkle;
        private ListBox lstSiparisler;
        private Label lblToplamTutar;
        private Label label5;
        private Button btnSiparisTamamla;
    }
}