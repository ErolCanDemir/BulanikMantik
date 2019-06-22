using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulanikMantıkOdev
{
    public class Bulanik
    {
        public double hassaslik, miktar, kirlilik;
        public double mamHassaslik, mamMiktar, mamKirlilik;
        public string uyelik;
        public List<string> Hassas = new List<string>();
        public List<string> Mik = new List<string>();
        public List<string> Kir = new List<string>();
        public double ortDonus;
        public double medyanDonus;
        public double medyanSure;
        public double medyanDeterjan;
        public List<double> yukariDonus = new List<double>();
        public double yukariDonusSonuc;

        public Bulanik(double hassaslik,double miktar, double kirlilik)
        {
            this.hassaslik = hassaslik;
            this.miktar = miktar;
            this.kirlilik = kirlilik;
        }
        public Bulanik()
        {

        }

        public void HassaslikAyari()
        {
            if (hassaslik > 0 && hassaslik < 3)
            {
                Hassas.Add("Sağlam");
            }
            else if (hassaslik >= 3 && hassaslik <= 4)
            {
                Hassas.Add("Sağlam");
                Hassas.Add("Orta");
            }
            else if (hassaslik > 4 && hassaslik < 5.5)
            {
                Hassas.Add("Orta");
            }
            else if (hassaslik >= 5.5 && hassaslik <= 7)
            {
                Hassas.Add("Orta");
                Hassas.Add("Hassas");
            }
            else
            {
                Hassas.Add("Hassas");
            }
        }

        public void MiktarAyari()
        {
            if (miktar > 0 && miktar < 3)
            {
                Mik.Add("Küçük");
            }
            else if (miktar >= 3 && miktar <= 4)
            {
                Mik.Add("Küçük");
                Mik.Add("Orta");
            }
            else if (miktar > 4 && miktar < 5.5)
            {
                Mik.Add("Orta");
            }
            else if (miktar >= 5.5 && miktar <= 7)
            {
                Mik.Add("Orta");
                Mik.Add("Büyük");
            }
            else
            {
                Mik.Add("Büyük");
            }
        }

        public void KirlilikAyari()
        {
            if (kirlilik > 0 && kirlilik < 3)
            {
                Kir.Add("Küçük");
            }
            else if (kirlilik >= 3 && kirlilik <= 4)
            {
                Kir.Add("Küçük");
                Kir.Add("Orta");
            }
            else if (kirlilik > 4 && kirlilik < 5.5)
            {
                Kir.Add("Orta");
            }
            else if (kirlilik >= 5.5 && kirlilik <= 7)
            {
                Kir.Add("Orta");
                Kir.Add("Büyük");
            }
            else
            {
                Kir.Add("Büyük");
            }
        }

        //Mamdani Hassaslık Hesabı
        public double MamdaniHassaslikHesaplama(string uyelikTipi)
        {
            if (hassaslik < 2 && uyelikTipi == "Sağlam")
            {
                mamHassaslik = 0;
            }
            if (hassaslik >= 2 && hassaslik <= 4 && uyelikTipi == "Sağlam")
            {
                mamHassaslik = (4 - hassaslik) / 2;
            }
            else if (hassaslik >= 3 && hassaslik <= 5 && uyelikTipi == "Orta")
            {
                mamHassaslik = (hassaslik - 3) / 2;
            }
            else if (hassaslik >= 5 && hassaslik <= 7 && uyelikTipi == "Orta")
            {
                mamHassaslik = (7 - hassaslik) / 2;
            }
            else if (hassaslik >= 5.5 && hassaslik <= 8 && uyelikTipi == "Hassas")
            {
                mamHassaslik = (hassaslik - 5.5) / 2.5;
            }
            else
            {
                mamHassaslik = 1;
            }
            return mamHassaslik;
        }
        //Mamdani Miktar Hesabı
        public double MamdaniMiktarHesaplama(string uyelikTipi)
        {
            if (miktar < 2 && uyelikTipi == "Küçük")
            {
                mamMiktar = 0;
            }
            else if (miktar >= 2 && miktar <= 4 && uyelikTipi == "Küçük")
            {
                mamMiktar = (4 - miktar) / 2;
            }
            else if (miktar >= 3 && miktar <= 5 && uyelikTipi == "Orta")
            {
                mamMiktar = (miktar - 3) / 2;
            }
            else if (miktar >= 5 && miktar <= 7 && uyelikTipi == "Orta")
            {
                mamMiktar = (7 - miktar) / 2;
            }
            else if (miktar >= 5.5 && miktar <= 8 && uyelikTipi == "Büyük")
            {
                mamMiktar = (miktar - 5.5) / 2.5;
            }
            else
            {
                mamMiktar = 1;
            }
            return mamMiktar;
        }

        //Mamdani Kirlilik Hesabı
        public double MamdaniKirlilikHesaplama(string uyelikTipi)
        {
            if (kirlilik < 2 && uyelikTipi == "Küçük")
            {
                mamKirlilik = 0;
            }
            else if (kirlilik >= 2 && kirlilik <= 4.5 && uyelikTipi == "Küçük")
            {
                mamKirlilik = (4.5 - kirlilik) / 2.5;
            }
            else if (kirlilik >= 3 && kirlilik <= 5 && uyelikTipi == "Orta")
            {
                mamKirlilik = (kirlilik - 3) / 2;
            }
            else if (kirlilik >= 5 && kirlilik <= 7 && uyelikTipi == "Orta")
            {
                mamKirlilik = (7 - kirlilik) / 2;
            }
            else if (kirlilik >= 5.5 && kirlilik <= 8 && uyelikTipi == "Büyük")
            {
                mamKirlilik = (kirlilik - 5.5) / 2.5;
            }
            else
            {
                mamKirlilik = 1;
            }
            return mamKirlilik;
        }

        public double Minbul(List<double> mamsonuclar)
        {
            double min = mamsonuclar.Min();
            return min;
        }

        public double Maxbul(List<double> maxlar)
        {
            double max = maxlar.Max();
            return max;
        }

        public double DonusHiziMedyan(string donusHiziTur)
        {
            if (donusHiziTur == "Hassas")
            {
                medyanDonus = -1.15;
            }
            else if (donusHiziTur == "Normal Hassas")
            {
                medyanDonus = 2.75;
            }
            else if (donusHiziTur == "Orta")
            {
                medyanDonus = 5;
            }
            else if (donusHiziTur == "Normal Güçlü")
            {
                medyanDonus = 7.25;
            }
            else
            {
                medyanDonus = 11.15;
            }
            return medyanDonus;
        }

        public double SureMedyan(string sureTur)
        {
            if (sureTur == "Kısa")
            {
                medyanSure = -1.49;
            }
            else if (sureTur == "Normal Kısa")
            {
                medyanSure = 39.9;
            }
            else if (sureTur == "Orta")
            {
                medyanSure = 57.5;
            }
            else if (sureTur == "Normal Uzun")
            {
                medyanSure = 75.1;
            }
            else
            {
                medyanSure = 102.15;
            }
            return medyanSure;
        }

        public double DeterjanMedyan(string deterjanTur)
        {
            if (deterjanTur == "Çok Az")
            {
                medyanDeterjan = 10;
            }
            else if (deterjanTur == "Normal Hassas")
            {
                medyanDeterjan = 85;
            }
            else if (deterjanTur == "Orta")
            {
                medyanDeterjan = 150;
            }
            else if (deterjanTur == "Normal Güçlü")
            {
                medyanDeterjan = 215;
            }
            else
            {
                medyanDeterjan = 290;
            }
            return medyanDeterjan;
        }

        

        public double Durulama(List<double> maxlar,List<double> medyanlar)
        {
            double donus = 0;
            for(int i = 0; i< maxlar.Count();i++)
            {
                donus += maxlar[i];
            }
            for (int i = 0; i < maxlar.Count(); i++)
            {
                yukariDonus.Add(maxlar[i] * medyanlar[i]);
            }
            yukariDonusSonuc = yukariDonus.Sum();

            ortDonus = yukariDonusSonuc / donus;

            return ortDonus;
        }
    }
}
