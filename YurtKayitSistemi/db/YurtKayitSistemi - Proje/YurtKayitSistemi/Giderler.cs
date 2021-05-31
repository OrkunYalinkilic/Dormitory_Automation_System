using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YurtKayitSistemi
{
    public class Giderler
    {
        public int odemeID { get; set; }
        public int elektrik { get; set; }
        public int su { get; set; }
        public int dogalgaz { get; set; }
        public int internet { get; set; }
        public int gida { get; set; }
        public int personel { get; set; }
        public int diger { get; set; }

        public bool boslukKontrol()
        {
            if (string.IsNullOrEmpty(elektrik.ToString()) == true ||
                string.IsNullOrEmpty(su.ToString()) == true ||
                string.IsNullOrEmpty(dogalgaz.ToString()) == true ||
                string.IsNullOrEmpty(internet.ToString()) == true ||
                string.IsNullOrEmpty(gida.ToString()) == true||
                string.IsNullOrEmpty(personel.ToString()) == true ||
                string.IsNullOrEmpty(diger.ToString()) == true)
            {
                return false;
            }

            return true;
        }
    }
}
