using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetcoreModelKimlikUygulamasi.Models
{
    public class Depo
    {
        private static List<Kimlik> _kimlikler = new List<Kimlik>();
            public static List<Kimlik> kimlikler
        {
            get
            {
                //Kimlikler özelliği talep edildiğinde
                //_kimlikler gönderilecek.
                return _kimlikler;
            }
        }
        public static void KimlikEkle(Kimlik kimlik)
        {
            //_kimlikler listesine gönderilen kimlikler ekleniyor.
            _kimlikler.Add(kimlik);
        }
    }
}
