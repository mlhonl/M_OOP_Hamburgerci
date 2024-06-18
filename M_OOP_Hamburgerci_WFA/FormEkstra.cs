﻿using M_OOP_Hamburgerci;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M_OOP_Hamburgerci_WFA
{
    public partial class FormEkstra : Form
    {
        public FormEkstra()
        {
            InitializeComponent();
        }

        private void btnMalzemeEkle_Click(object sender, EventArgs e)
        {
            FormSiparis.ekstralar.Add(new EkstraMalzeme()
            {
                Ad = txtMalzemeAdi.Text,
                Fiyati = nmrMalzemeFiyati.Value

            });
            Fonksiyonlar.Temizle(this.Controls);
            MessageBox.Show("Ekstra Eklendi");

        }
    }
}
