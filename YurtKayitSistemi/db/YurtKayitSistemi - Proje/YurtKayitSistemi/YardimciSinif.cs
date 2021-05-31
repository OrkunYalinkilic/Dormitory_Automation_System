using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YurtKayitSistemi
{
    public static class YardimciSinif
    {
        public static bool stringKontrol(params string[] strings)
        {
            bool sonuc = true;

            for (int i = 0; i < strings.Length; i++)
            {
                foreach (char item in strings[i])
                {
                    if (Char.IsNumber(item)==true)
                    {
                        sonuc = false;
                        break;
                    }
                }
            }

            return sonuc;
        }

        public static bool sayiKontrol (params string[] sayilar)
        {
            bool sonuc = true;

            for (int i = 0; i < sayilar.Length; i++)
            {
                foreach (char item in sayilar[i])
                {
                    if (Char.IsNumber(item)==false)
                    {
                       sonuc = false;
                        break;
                    }
                }
            }

            return sonuc;
        }

        public static string boslukKaldir(string veri)
        {
            List<char> dizi = veri.ToList();
            List<char> gonderilen = new List<char>();

            for (int i = 0; i < dizi.Count; i++)
            {
                if(dizi[i]!=' ')
                {
                    gonderilen.Add(dizi[i]);
                }
            }

            string gonderilecek="";

            for (int i = 0; i < gonderilen.Count; i++)
            {
                gonderilecek += gonderilen[i];
            }

            return gonderilecek;
        }

        public static float tutarCevir(string gelen)
        {
            List<char> gelenDizi = gelen.ToList();
            List<char> gonderilen = new List<char>();
            for (int i = 0; i < gelenDizi.Count; i++)
            {
                if (gelenDizi[i] == ' ')
                {
                    continue;
                }
                else if (gelenDizi[i] == 'T')
                {
                    break;
                }

                else
                {
                    gonderilen.Add(gelenDizi[i]);
                }
            }
            
            string gonderilecek="";

            for (int j = 0; j<gonderilen.Count; j++)
            {
                gonderilecek += gonderilen[j].ToString();
            }

            return float.Parse(gonderilecek);
        }
    }
}
