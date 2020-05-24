using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Evliya_Celebi_Gezi_Rehberi2.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("GeziVeriTabani")
        {
            Database.SetInitializer(new GeziInitializer());
        }

        public DbSet<Bolge> Bolgeler { get; set; }
        public DbSet<Sehir> Sehirler { get; set; }
        public DbSet<Tarihimekan> Tarihimekanlar { get; set; }
        public DbSet<Eglencemekan> Eglencemekanlar { get; set; }
        public DbSet<Dogalmekan> Dogalmekanlar { get; set; }



    }
}