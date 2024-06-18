namespace M_OOP_Hamburgerci_WFA
{
    partial class FormEkstra
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
            groupBox1 = new GroupBox();
            btnMalzemeEkle = new Button();
            nmrMalzemeFiyati = new NumericUpDown();
            txtMalzemeAdi = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrMalzemeFiyati).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.MistyRose;
            groupBox1.Controls.Add(btnMalzemeEkle);
            groupBox1.Controls.Add(nmrMalzemeFiyati);
            groupBox1.Controls.Add(txtMalzemeAdi);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(7, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(309, 217);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "EKSTRA MALZEME BİLGİSİ";
            // 
            // btnMalzemeEkle
            // 
            btnMalzemeEkle.BackColor = Color.LightGreen;
            btnMalzemeEkle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnMalzemeEkle.Location = new Point(77, 141);
            btnMalzemeEkle.Name = "btnMalzemeEkle";
            btnMalzemeEkle.Size = new Size(215, 59);
            btnMalzemeEkle.TabIndex = 3;
            btnMalzemeEkle.Text = "Ekstra Malzemeyi Kaydet";
            btnMalzemeEkle.UseVisualStyleBackColor = false;
            btnMalzemeEkle.Click += btnMalzemeEkle_Click;
            // 
            // nmrMalzemeFiyati
            // 
            nmrMalzemeFiyati.Location = new Point(211, 90);
            nmrMalzemeFiyati.Name = "nmrMalzemeFiyati";
            nmrMalzemeFiyati.Size = new Size(81, 29);
            nmrMalzemeFiyati.TabIndex = 2;
            // 
            // txtMalzemeAdi
            // 
            txtMalzemeAdi.Location = new Point(211, 38);
            txtMalzemeAdi.Name = "txtMalzemeAdi";
            txtMalzemeAdi.Size = new Size(81, 29);
            txtMalzemeAdi.TabIndex = 1;
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
            label1.Size = new Size(145, 19);
            label1.TabIndex = 0;
            label1.Text = "Ekstra Malzeme Adı:";
            // 
            // FormEkstra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 230);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEkstra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEkstra";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrMalzemeFiyati).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtMalzemeAdi;
        private Button btnMalzemeEkle;
        private NumericUpDown nmrMalzemeFiyati;
        private Label label2;
    }
}