namespace M_OOP_Hamburgerci_WFA
{
    partial class FormMenu
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
            btnMenuEkle = new Button();
            groupBox1 = new GroupBox();
            nmrMenuFiyati = new NumericUpDown();
            txtMenuAdi = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrMenuFiyati).BeginInit();
            SuspendLayout();
            // 
            // btnMenuEkle
            // 
            btnMenuEkle.BackColor = Color.LightGreen;
            btnMenuEkle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnMenuEkle.Location = new Point(35, 144);
            btnMenuEkle.Name = "btnMenuEkle";
            btnMenuEkle.Size = new Size(215, 59);
            btnMenuEkle.TabIndex = 3;
            btnMenuEkle.Text = "MENÜ EKLE";
            btnMenuEkle.UseVisualStyleBackColor = false;
            btnMenuEkle.Click += btnMenuEkle_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.MistyRose;
            groupBox1.Controls.Add(btnMenuEkle);
            groupBox1.Controls.Add(nmrMenuFiyati);
            groupBox1.Controls.Add(txtMenuAdi);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(6, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(287, 240);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "MENÜ BİLGİLERİ";
            // 
            // nmrMenuFiyati
            // 
            nmrMenuFiyati.Location = new Point(143, 90);
            nmrMenuFiyati.Name = "nmrMenuFiyati";
            nmrMenuFiyati.Size = new Size(107, 29);
            nmrMenuFiyati.TabIndex = 2;
            // 
            // txtMenuAdi
            // 
            txtMenuAdi.Location = new Point(143, 38);
            txtMenuAdi.Name = "txtMenuAdi";
            txtMenuAdi.Size = new Size(107, 29);
            txtMenuAdi.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(18, 95);
            label2.Name = "label2";
            label2.Size = new Size(45, 19);
            label2.TabIndex = 0;
            label2.Text = "Fiyat:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(18, 44);
            label1.Name = "label1";
            label1.Size = new Size(77, 19);
            label1.TabIndex = 0;
            label1.Text = "Menu Adı:";
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 252);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMenu";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrMenuFiyati).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnMenuEkle;
        private GroupBox groupBox1;
        private NumericUpDown nmrMenuFiyati;
        private TextBox txtMenuAdi;
        private Label label2;
        private Label label1;
    }
}