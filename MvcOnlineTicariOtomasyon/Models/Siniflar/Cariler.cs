using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class Cariler
    {

        [Key]
        public int Cariid { get; set; }
        public int CariAd { get; set; }
        public int CariSoyad { get; set; }
        public int CariSehir { get; set; }
        public int CariMail { get; set; }
    }
}