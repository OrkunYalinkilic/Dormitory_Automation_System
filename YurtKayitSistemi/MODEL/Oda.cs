using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YurtKayitSistemi
{
    public class Oda
    {
        public int odaID { get; set; }
        public string OdaNo { get; set; }
        public string odaKapasite { get; set; }
        public int kalanKisi { get; set; }
        public bool odaDurumu { get; set; }

        public bool boslukKontrol()
        {
            if (string.IsNullOrEmpty(OdaNo) == true ||
                string.IsNullOrEmpty(odaKapasite) == true ||
                string.IsNullOrEmpty(kalanKisi.ToString()) == true)
            {
                return false;
            }

            return true;
        }
    }
}
