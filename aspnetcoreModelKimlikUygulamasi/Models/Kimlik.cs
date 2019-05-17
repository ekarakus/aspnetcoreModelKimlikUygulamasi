using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetcoreModelKimlikUygulamasi.Models
{
    public class Kimlik
    { [Required(ErrorMessage ="TCKN Girmek Zorunludur . . .")]
        public string TCKN { get; set; }
        [Required(ErrorMessage = "Ad Girmek Zorunludur . . .")]
        public string ad { get; set; }
        public string soyad { get; set; }
        public string anaAdi{ get; set; }
        public string babaAdi{ get; set; }
    }
}
