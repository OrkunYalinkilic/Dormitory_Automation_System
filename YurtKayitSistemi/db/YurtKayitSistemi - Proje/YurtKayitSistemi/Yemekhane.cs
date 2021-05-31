using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YurtKayitSistemi
{
    public class Yemekhane
    {
        public string Yil { get; set; }
        public string ay { get; set; }
        public string gun { get; set; }
        public string ogun { get; set; }
        public string birinci_yemek { get; set; }
        public string ikinci_yemek { get; set; }
        public string ucuncu_yemek { get; set; }
        public string dorduncu_yemek { get; set; }

        public bool boslukKontrol()
        {
            if (string.IsNullOrEmpty(Yil.ToString()) == true ||
                string.IsNullOrEmpty(ay.ToString()) == true ||
                string.IsNullOrEmpty(gun.ToString()) == true ||
                string.IsNullOrEmpty(ogun.ToString()) == true ||
                string.IsNullOrEmpty(birinci_yemek.ToString()) == true ||
                string.IsNullOrEmpty(ikinci_yemek.ToString()) == true ||
                string.IsNullOrEmpty(ucuncu_yemek.ToString()) == true||
                string.IsNullOrEmpty(dorduncu_yemek.ToString()) == true)
            {
                return false;
            }

            return true;
        }

    }
}
