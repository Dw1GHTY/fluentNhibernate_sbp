using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deathstar.Entiteti;
using FluentNHibernate.Mapping;

namespace Deathstar.Mapiranja
{
    class ZvezdaPlanetaBlizinaMapiranja : ClassMap<ZvezdaPlanetaBlizina>
    {
        public ZvezdaPlanetaBlizinaMapiranja() 
        {
            //mapiranje tabele
            Table("ZVEZDA_PLANETA_BLIZINA");

            //mapiranje primarnog kljuca
            Id(x => x.Id).Column("ID").GeneratedBy.TriggerIdentity();

            //mapiranje ka zvezdi
            References(x => x.ZvezdaId)
                .Column("ZVEZDA_ID")
                .LazyLoad();


            //mapiranje ka planeti
            References(x => x.PlanetaId)
                .Column("PLANETA_ID")
                .LazyLoad();


        }
    }
}
