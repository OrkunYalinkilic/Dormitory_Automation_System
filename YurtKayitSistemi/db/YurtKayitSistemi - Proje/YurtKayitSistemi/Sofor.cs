using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YurtKayitSistemi
{
    public class Sofor:Person
    {
        public string yas { get; set; }

        public bool boslukKontrol()
        {
            if (string.IsNullOrEmpty(adi) == true ||
                string.IsNullOrEmpty(soyadi) == true ||
                string.IsNullOrEmpty(CepTelefonu) == true ||
                string.IsNullOrEmpty(tcKimlikNo) == true||
                string.IsNullOrEmpty(soyadi) == true)
            {
                return false;
            }

            return true;
        }

    }
}
