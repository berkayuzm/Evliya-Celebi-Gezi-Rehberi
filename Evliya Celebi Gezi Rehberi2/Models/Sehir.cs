using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Evliya_Celebi_Gezi_Rehberi2.Models
{
    public class Sehir
    {
        public int Id { get; set; }
        public string Adi { get; set; }

        public string aciklama { get; set; }

        public string Resim { get; set; }

        public bool Anasayfa { get; set; }

        public List<Dogalmekan> Dogalmekanlar { get; set; }
        public List<Tarihimekan> Tarihimekanlar { get; set; }
        public List<Eglencemekan> Eglencemekanlar { get; set; }

        public int BolgeId { get; set; }
        public Bolge Bolge { get; set; }
    }
}