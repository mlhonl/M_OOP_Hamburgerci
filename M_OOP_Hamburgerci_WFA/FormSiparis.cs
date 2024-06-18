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
    public partial class FormSiparis : Form
    {
        public FormSiparis()
        {
            InitializeComponent();
        }
        public static List<Menu> menuler = new List<Menu>()
        {
            new Menu(){Ad="Big King", Fiyati = 150.00M},
            new Menu(){Ad="Double King Chicken", Fiyati = 135.50M},
            new Menu(){Ad="Steakhouse", Fiyati = 195.00M},
            new Menu(){Ad="Whooper", Fiyati = 165.00M},
            new Menu(){Ad="Chicken Royal", Fiyati = 145.37M},
        };
        public static List<EkstraMalzeme> ekstralar = new List<EkstraMalzeme>()
        {
            new EkstraMalzeme(){Ad="Ketçap",Fiyati=2.50M},
            new EkstraMalzeme(){Ad="Mayonez",Fiyati=2.50M},
            new EkstraMalzeme(){Ad="Hardal",Fiyati=3.75M},
            new EkstraMalzeme(){Ad="BBQ",Fiyati=4.00M},
        };
        public static List<Siparis> mevcutSiparisler = new List<Siparis>();
        public static List<Siparis> tumSiparisler = new List<Siparis>();

        private void FormSiparis_Load(object sender, EventArgs e)
        {
            foreach (Menu menu in menuler)
            {
                cmbMenuler.Items.Add(menu);
            }
            cmbMenuler.SelectedIndex = 0;
            rdbKucuk.Checked = true;
            foreach (EkstraMalzeme ekstra in ekstralar)
            {
                flpEkstraMalzemeler.Controls.Add(new CheckBox() { Text = ekstra.Ad, Tag = ekstra });
            }
            foreach (Siparis item in mevcutSiparisler)
            {
                lstSiparisler.Items.Add(item);
            }
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            Siparis yeniSiparis = new Siparis();
            yeniSiparis.SeciliMenu = (Menu)cmbMenuler.SelectedItem;
            yeniSiparis.Boyut = rdbKucuk.Checked ? Boyut.Küçük : rdbOrta.Checked ? Boyut.Orta : Boyut.Büyük;
            foreach (CheckBox item in flpEkstraMalzemeler.Controls)
            {
                if (item.Checked)
                {
                    yeniSiparis.EkstraMalzemeler.Add((EkstraMalzeme)item.Tag);
                }
            }
            yeniSiparis.Adet = Convert.ToInt16(nmrAdet.Value);
            yeniSiparis.Hesapla();
            mevcutSiparisler.Add(yeniSiparis);
            tumSiparisler.Add(yeniSiparis);
            lstSiparisler.Items.Add(yeniSiparis);
            TutarHesapla();
            Fonksiyonlar.Temizle(this.Controls);
        }

        private decimal TutarHesapla()
        {
            decimal tutar = 0;
            foreach (Siparis item in lstSiparisler.Items)
            {
                tutar += item.ToplamTutar;
            }
            lblToplamTutar.Text = tutar.ToString("C2");
            return tutar;
        }

        private void btnSiparisTamamla_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Toplam Sipariş Tutarı {TutarHesapla().ToString("C2")}\n Siparişi tamamlamak ister misiniz ?","Sipariş Bilgisi",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                lstSiparisler.Items.Clear();
                mevcutSiparisler.Clear();
                TutarHesapla();
                MessageBox.Show("Siparişiniz tamamlandı");
            }
            else
            {
                MessageBox.Show("İptal Edildi");
            }
        }
    }
}