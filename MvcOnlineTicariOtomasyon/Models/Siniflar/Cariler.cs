﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class Cariler
    {
        [Key]
        public int Cariid { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(30, ErrorMessage ="En fazla 30 karekter girebilirsin.")]
        public string CariAd { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(30)]
        [Required(ErrorMessage ="Bu alanı boş geçemessin.")]
        public string CariSoyad { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(13)]
        public string CariSehir { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string CariMail { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string CariSifre { get; set; }

        public bool Durum { get; set; }
        public ICollection<SatisHareket> SatisHarekets { get; set; }
    }
}