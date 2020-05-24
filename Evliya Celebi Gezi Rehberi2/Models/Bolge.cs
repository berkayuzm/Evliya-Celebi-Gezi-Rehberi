using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Evliya_Celebi_Gezi_Rehberi2.Models
{
    public class Bolge
    {
        public int Id { get; set; }
        public string Adi { get; set; }
 
        public List<Sehir> Sehirler { get; set; }
    }
}