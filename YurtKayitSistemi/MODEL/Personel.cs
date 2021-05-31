using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YurtKayitSistemi
{
    public class Personel : Person
    {
        public int personelID { get; set; }
        public string departmani { get; set; }
        public string maas { get; set; }

        public bool boslukKontrol()
        {
            if (string.IsNullOrEmpty(departmani) == true ||
                string.IsNullOrEmpty(adi) == true ||
                string.IsNullOrEmpty(soyadi) == true ||
                string.IsNullOrEmpty(CepTelefonu) == true ||
                string.IsNullOrEmpty(tcKimlikNo) == true)
            {
                return false;
            }

            return true;
        }
    }
}
