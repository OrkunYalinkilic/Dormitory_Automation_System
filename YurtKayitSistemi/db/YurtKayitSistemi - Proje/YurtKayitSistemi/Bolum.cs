using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YurtKayitSistemi
{
    public class Bolum
    {
        public int bolumID { get; set; }
        public string bolumAdi { get; set; }

        public bool boslukKontrol()
        {
            if (string.IsNullOrEmpty(bolumAdi) == true)       
            {
                return false;
            }
            return true;
        }

    }
}
