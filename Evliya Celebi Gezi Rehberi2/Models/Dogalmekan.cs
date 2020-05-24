using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Evliya_Celebi_Gezi_Rehberi2.Models
{
    public class Dogalmekan
    {
        public int Id { get; set; }

        public string Adi { get; set; }
        public string Aciklama { get; set; }
        public string Image { get; set; }

        public int SehirId { get; set; }
        public Sehir Sehir { get; set; }
    }
}