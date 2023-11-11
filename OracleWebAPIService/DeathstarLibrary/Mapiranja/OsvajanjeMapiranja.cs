using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deathstar.Entiteti;
using FluentNHibernate.Mapping;

namespace Deathstar.Mapiranja
{
    class OsvajanjeMapiranja : ClassMap<Osvajanje>
    {
        public OsvajanjeMapiranja() 
        {
            //mapiranje tabele
            Table("OSVAJANJE");


            //mapiranje primarnog kljuca
            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();


            //mapiranje svojstava
            //Map(x => x.Tip, "TIP");
            Map(x => x.Datum).Column("DATUM");
            Map(x => x.PrethodniVlasnikIgrac).Column("PRETHODNI_VLASNIK_IGRAC");
            Map(x => x.PrethodniVlasnikSavez).Column("PRETHODNI_VLASNIK_SAVEZ");

            //mapiranje ka igracu
            References(x => x.IgracVrsi)
               .Column("IGRAC_ID")
               .LazyLoad();

            //mapiranje ka savezu
            References(x => x.SavezVrsi)
               .Column("SAVEZ_ID")
               .LazyLoad();

            //mapiranje planete
            References(x => x.PlanetaOsvaja).Column("PLANETA_ID").LazyLoad();
        }
    }
}
