using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulanikMantıkOdev
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.DeepOrange400, MaterialSkin.Primary.DeepOrange400,MaterialSkin.Primary.DeepOrange400, MaterialSkin.Accent.DeepOrange400, MaterialSkin.TextShade.BLACK);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListViewItem kural1 = listView1.Items.Add("Kural1");
            kural1.SubItems.Add("Hassas");
            kural1.SubItems.Add("Küçük");
            kural1.SubItems.Add("Küçük");
            kural1.SubItems.Add("Hassas");
            kural1.SubItems.Add("Kısa");
            kural1.SubItems.Add("Çok Az");

            ListViewItem kural2 = listView1.Items.Add("Kural2");
            kural2.SubItems.Add("Hassas");
            kural2.SubItems.Add("Küçük");
            kural2.SubItems.Add("Orta");
            kural2.SubItems.Add("Normal Hassas");
            kural2.SubItems.Add("Kısa");
            kural2.SubItems.Add("Az");

            ListViewItem kural3 = listView1.Items.Add("Kural3");
            kural3.SubItems.Add("Hassas");
            kural3.SubItems.Add("Küçük");
            kural3.SubItems.Add("Büyük");
            kural3.SubItems.Add("Orta");
            kural3.SubItems.Add("Normal Kısa");
            kural3.SubItems.Add("Orta");

            ListViewItem kural4 = listView1.Items.Add("Kural4");
            kural4.SubItems.Add("Hassas");
            kural4.SubItems.Add("Orta");
            kural4.SubItems.Add("Küçük");
            kural4.SubItems.Add("Hassas");
            kural4.SubItems.Add("Kısa");
            kural4.SubItems.Add("Orta");

            ListViewItem kural5 = listView1.Items.Add("Kural5");
            kural5.SubItems.Add("Hassas");
            kural5.SubItems.Add("Orta");
            kural5.SubItems.Add("Orta");
            kural5.SubItems.Add("Normal Hassas");
            kural5.SubItems.Add("Normal Kısa");
            kural5.SubItems.Add("Orta");

            ListViewItem kural6 = listView1.Items.Add("Kural6");
            kural6.SubItems.Add("Hassas");
            kural6.SubItems.Add("Orta");
            kural6.SubItems.Add("Büyük");
            kural6.SubItems.Add("Orta");
            kural6.SubItems.Add("Orta");
            kural6.SubItems.Add("Fazla");

            ListViewItem kural7 = listView1.Items.Add("Kural7");
            kural7.SubItems.Add("Hassas");
            kural7.SubItems.Add("Büyük");
            kural7.SubItems.Add("Küçük");
            kural7.SubItems.Add("Normal Hassas");
            kural7.SubItems.Add("Normal Kısa");
            kural7.SubItems.Add("Orta");

            ListViewItem kural8 = listView1.Items.Add("Kural8");
            kural8.SubItems.Add("Hassas");
            kural8.SubItems.Add("Büyük");
            kural8.SubItems.Add("Orta");
            kural8.SubItems.Add("Normal Hassas");
            kural8.SubItems.Add("Orta");
            kural8.SubItems.Add("Fazla");

            ListViewItem kural9 = listView1.Items.Add("Kural9");
            kural9.SubItems.Add("Hassas");
            kural9.SubItems.Add("Büyük");
            kural9.SubItems.Add("Büyük");
            kural9.SubItems.Add("Orta");
            kural9.SubItems.Add("Normal Uzun");
            kural9.SubItems.Add("Fazla");

            ListViewItem kural10 = listView1.Items.Add("Kural10");
            kural10.SubItems.Add("Orta");
            kural10.SubItems.Add("Küçük");
            kural10.SubItems.Add("Küçük");
            kural10.SubItems.Add("Normal Hassas");
            kural10.SubItems.Add("Normal Kısa");
            kural10.SubItems.Add("Az");

            ListViewItem kural11 = listView1.Items.Add("Kural11");
            kural11.SubItems.Add("Orta");
            kural11.SubItems.Add("Küçük");
            kural11.SubItems.Add("Orta");
            kural11.SubItems.Add("Orta");
            kural11.SubItems.Add("Kısa");
            kural11.SubItems.Add("Orta");

            ListViewItem kural12 = listView1.Items.Add("Kural12");
            kural12.SubItems.Add("Orta");
            kural12.SubItems.Add("Küçük");
            kural12.SubItems.Add("Büyük");
            kural12.SubItems.Add("Normal Güçlü");
            kural12.SubItems.Add("Orta");
            kural12.SubItems.Add("Fazla");

            ListViewItem kural13 = listView1.Items.Add("Kural13");
            kural13.SubItems.Add("Orta");
            kural13.SubItems.Add("Orta");
            kural13.SubItems.Add("Küçük");
            kural13.SubItems.Add("Normal Hassas");
            kural13.SubItems.Add("Normal Kısa");
            kural13.SubItems.Add("Orta");

            ListViewItem kural14 = listView1.Items.Add("Kural14");
            kural14.SubItems.Add("Orta");
            kural14.SubItems.Add("Orta");
            kural14.SubItems.Add("Orta");
            kural14.SubItems.Add("Orta");
            kural14.SubItems.Add("Orta");
            kural14.SubItems.Add("Orta");

            ListViewItem kural15 = listView1.Items.Add("Kural15");
            kural15.SubItems.Add("Orta");
            kural15.SubItems.Add("Orta");
            kural15.SubItems.Add("Büyük");
            kural15.SubItems.Add("Hassas");
            kural15.SubItems.Add("Uzun");
            kural15.SubItems.Add("Fazla");

            ListViewItem kural16 = listView1.Items.Add("Kural16");
            kural16.SubItems.Add("Orta");
            kural16.SubItems.Add("Büyük");
            kural16.SubItems.Add("Küçük");
            kural16.SubItems.Add("Hassas");
            kural16.SubItems.Add("Orta");
            kural16.SubItems.Add("Orta");

            ListViewItem kural17 = listView1.Items.Add("Kural17");
            kural17.SubItems.Add("Orta");
            kural17.SubItems.Add("Büyük");
            kural17.SubItems.Add("Orta");
            kural17.SubItems.Add("Hassas");
            kural17.SubItems.Add("Normal Uzun");
            kural17.SubItems.Add("Fazla");

            ListViewItem kural18 = listView1.Items.Add("Kural18");
            kural18.SubItems.Add("Orta");
            kural18.SubItems.Add("Büyük");
            kural18.SubItems.Add("Büyük");
            kural18.SubItems.Add("Hassas");
            kural18.SubItems.Add("Uzun");
            kural18.SubItems.Add("Çok Fazla");

            ListViewItem kural19 = listView1.Items.Add("Kural19");
            kural19.SubItems.Add("Sağlam");
            kural19.SubItems.Add("Küçük");
            kural19.SubItems.Add("Küçük");
            kural19.SubItems.Add("Orta");
            kural19.SubItems.Add("Orta");
            kural19.SubItems.Add("Az");

            ListViewItem kural20 = listView1.Items.Add("Kural20");
            kural20.SubItems.Add("Sağlam");
            kural20.SubItems.Add("Küçük");
            kural20.SubItems.Add("Orta");
            kural20.SubItems.Add("Normal Güçlü");
            kural20.SubItems.Add("Orta");
            kural20.SubItems.Add("Orta");

            ListViewItem kural21 = listView1.Items.Add("Kural21");
            kural21.SubItems.Add("Sağlam");
            kural21.SubItems.Add("Küçük");
            kural21.SubItems.Add("Büyük");
            kural21.SubItems.Add("Güçlü");
            kural21.SubItems.Add("Normal Uzun");
            kural21.SubItems.Add("Fazla");

            ListViewItem kural22 = listView1.Items.Add("Kural22");
            kural22.SubItems.Add("Sağlam");
            kural22.SubItems.Add("Orta");
            kural22.SubItems.Add("Küçük");
            kural22.SubItems.Add("Orta");
            kural22.SubItems.Add("Orta");
            kural22.SubItems.Add("Orta");

            ListViewItem kural23 = listView1.Items.Add("Kural23");
            kural23.SubItems.Add("Sağlam");
            kural23.SubItems.Add("Orta");
            kural23.SubItems.Add("Orta");
            kural23.SubItems.Add("Normal Güçlü");
            kural23.SubItems.Add("Normal Uzun");
            kural23.SubItems.Add("Orta");

            ListViewItem kural24 = listView1.Items.Add("Kural24");
            kural24.SubItems.Add("Sağlam");
            kural24.SubItems.Add("Orta");
            kural24.SubItems.Add("Büyük");
            kural24.SubItems.Add("Güçlü");
            kural24.SubItems.Add("Orta");
            kural24.SubItems.Add("Çok Fazla");

            ListViewItem kural25 = listView1.Items.Add("Kural25");
            kural25.SubItems.Add("Sağlam");
            kural25.SubItems.Add("Büyük");
            kural25.SubItems.Add("Küçük");
            kural25.SubItems.Add("Normal Güçlü");
            kural25.SubItems.Add("Normal Uzun");
            kural25.SubItems.Add("Fazla");

            ListViewItem kural26 = listView1.Items.Add("Kural26");
            kural26.SubItems.Add("Sağlam");
            kural26.SubItems.Add("Büyük");
            kural26.SubItems.Add("Orta");
            kural26.SubItems.Add("Normal Güçlü");
            kural26.SubItems.Add("Uzun");
            kural26.SubItems.Add("Fazla");

            ListViewItem kural27 = listView1.Items.Add("Kural27");
            kural27.SubItems.Add("Sağlam");
            kural27.SubItems.Add("Büyük");
            kural27.SubItems.Add("Büyük");
            kural27.SubItems.Add("Güçlü");
            kural27.SubItems.Add("Uzun");
            kural27.SubItems.Add("Çok Fazla");

        }

        public double hassaslik,miktar,kirlilik;
        public List<string> DonusHiziUyelik = new List<string>();
        public List<string> SureUyelik = new List<string>();
        public List<string> DeterjanUyelik = new List<string>();
        public List<double> min = new List<double>();
        public List<double> mamdaniSonuclar = new List<double>();
        public List<double> max = new List<double>();
        public List<double> maxlarDonus = new List<double>();
        public List<double> medyanlarDonus = new List<double>();
        public List<double> maxlarSure = new List<double>();
        public List<double> medyanlarSure = new List<double>();
        public List<double> maxlarDeterjan = new List<double>();
        public List<double> medyanlarDeterjan = new List<double>();
        List<string> donusHiziTur = new List<string>();
        List<string> SureTur = new List<string>();
        List<string> DeterjanTur = new List<string>();
        Bulanik bulanik;

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            hassaslik = Convert.ToDouble(numericUpDown1.Value);
            miktar = Convert.ToDouble(numericUpDown2.Value);
            kirlilik = Convert.ToDouble(numericUpDown3.Value);
            bulanik = new Bulanik(hassaslik, miktar, kirlilik);
            bulanik.HassaslikAyari();
            bulanik.MiktarAyari();
            bulanik.KirlilikAyari();
            KuralBulma();
            listBox1.Items.Clear();
            for (int i = 0; i < min.Count(); i++)
            {
                listBox1.Items.Add(min[i].ToString());
            }
            if (maxlarDonus != null)
            {
                DonusHiziDegerlendir();
            }
            if (maxlarSure != null)
            {
                SureDegerlendir();
            }
            if (maxlarDeterjan != null)
            {
                DeterjanDegerlendir();
            }


            materialSingleLineTextField1.Text = bulanik.Durulama(maxlarDonus, medyanlarDonus).ToString();
            materialSingleLineTextField2.Text = bulanik.Durulama(maxlarSure, medyanlarSure).ToString();
            materialSingleLineTextField3.Text = bulanik.Durulama(maxlarDeterjan, medyanlarDeterjan).ToString();
        }
        public void KuralBulma()
        {
            
            for (int i = 0; i < bulanik.Hassas.Count(); i++)
            {
                for (int j = 0; j < bulanik.Mik.Count(); j++)
                {
                    for (int k = 0; k < bulanik.Kir.Count(); k++)
                    {
                        for (int l = 0; l < 27; l++)
                        {
                            if(bulanik.Hassas[i]==listView1.Items[l].SubItems[1].Text && bulanik.Mik[j] == listView1.Items[l].SubItems[2].Text && bulanik.Kir[k] == listView1.Items[l].SubItems[3].Text)
                            {
                                mamdaniSonuclar.Add(bulanik.MamdaniHassaslikHesaplama(bulanik.Hassas[i]));
                                mamdaniSonuclar.Add(bulanik.MamdaniMiktarHesaplama(bulanik.Mik[j]));
                                mamdaniSonuclar.Add(bulanik.MamdaniKirlilikHesaplama(bulanik.Kir[k]));
                                min.Add(bulanik.Minbul(mamdaniSonuclar));
                                mamdaniSonuclar.Clear();
                                listView1.Items[l].Selected = true;
                                listView1.Items[l].ForeColor = Color.White;
                                listView1.Items[l].BackColor = Color.DarkBlue;
                                DonusHiziUyelik.Add(listView1.Items[l].SubItems[4].Text);
                                SureUyelik.Add(listView1.Items[l].SubItems[5].Text);
                                DeterjanUyelik.Add(listView1.Items[l].SubItems[6].Text);
                            }
                        }
                    }
                }
            }
        }

        public void DonusHiziDegerlendir()
        {
            for (int i = 0; i < min.Count() / 2; i++)
            {
                for (int j = min.Count() / 2; j < min.Count(); j++)
                {
                    if (DonusHiziUyelik[i] == DonusHiziUyelik[j])
                    {
                        max.Add(min[i]);
                        max.Add(min[j]);
                        maxlarDonus.Add(bulanik.Maxbul(max));
                        donusHiziTur.Add(DonusHiziUyelik[i]);
                        max.Clear();
                    }
                }
            }

            for (int i = 0; i < donusHiziTur.Count(); i++)
            {
                medyanlarDonus.Add(bulanik.DonusHiziMedyan(donusHiziTur[i]));
            }
        }

        public void SureDegerlendir()
        {
            for (int i = 0; i < min.Count() / 2; i++)
            {
                for (int j = min.Count() / 2; j < min.Count(); j++)
                {
                    if (SureUyelik[i] == SureUyelik[j])
                    {
                        max.Add(min[i]);
                        max.Add(min[j]);
                        maxlarSure.Add(bulanik.Maxbul(max));
                        SureTur.Add(SureUyelik[i]);
                        max.Clear();
                    }
                }
            }

            for (int i = 0; i < SureTur.Count(); i++)
            {
                medyanlarSure.Add(bulanik.SureMedyan(SureTur[i]));
            }
        }

        public void DeterjanDegerlendir()
        {
            for (int i = 0; i < min.Count() / 2; i++)
            {
                for (int j = min.Count() / 2; j < min.Count(); j++)
                {
                    if (DeterjanUyelik[i] == DeterjanUyelik[j])
                    {
                        max.Add(min[i]);
                        max.Add(min[j]);
                        maxlarDeterjan.Add(bulanik.Maxbul(max));
                        DeterjanTur.Add(DeterjanUyelik[i]);
                        max.Clear();
                    }
                }
            }

            for (int i = 0; i < DeterjanTur.Count(); i++)
            {
                medyanlarDeterjan.Add(bulanik.DeterjanMedyan(DeterjanTur[i]));
            }
        }
    }
}
