using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Deathstar.Entiteti;

namespace Deathstar.Mapiranja
{
    class BrodMapiranja : ClassMap<Brod>
    {
        public BrodMapiranja() 
        {
            //mapiranje tabele
            Table("BROD");

            //mapiranje primarnog kljuca
            Id(x => x.JedinstveniBroj, "JEDINSTVENI_BROJ").GeneratedBy.TriggerIdentity();


            //mapiranje svojstava
            //Map(x => x.Tip, "TIP");
            Map(x => x.Naziv).Column("NAZIV");
            Map(x => x.MaxWarp).Column("MAX_WARP");
            Map(x => x.BrojLaserskihTopova).Column("BROJ_LASERSKIH_TOPOVA");
            Map(x => x.FotonskaTorpeda).Column("FOTONSKA_TORPEDA");
            Map(x => x.Tip).Column("TIP");
            Map(x => x.ZastitnaOplata).Column("ZASTITNA_OPLATA");
            Map(x => x.Nosivost).Column("NOSIVOST");
            Map(x => x.VrstaBroda).Column("VRSTA_BRODA");


            //mapiranje ka igracu
            References(x => x.PripadaIgracu)
              .Column("IGRAC_ID")
              .LazyLoad();

            //mapiranje ka savezu
            References(x => x.PripadaSavezu)
              .Column("SAVEZ_ID")
              .LazyLoad();

            //mapiranje ka planeti
            References(x => x.IzgradjenNaPlaneti)
               .Column("PLANETA_ID")
               .LazyLoad();



        }

    }
}
