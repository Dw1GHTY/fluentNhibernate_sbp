using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deathstar.Entiteti;
using FluentNHibernate.Mapping;

namespace Deathstar.Mapiranja
{
    class PlanetaPojavaBlizinaMapiranja : ClassMap<PlanetaPojavaBlizina>
    {
        public PlanetaPojavaBlizinaMapiranja() 
        {
            //mapiranje tabele
            Table("PLANETA_POJAVA_BLIZINA");

            //mapiranje id-ja
            Id(x => x.Id).Column("ID").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava
            Map(x => x.Udaljenost).Column("UDALJENOST");

            //mapiranje ka pojavi
            References(x => x.SpecPojavaId)
                .Column("SPEC_POJAVA_ID")
                .LazyLoad();


            //mapiranje ka planeti
            References(x => x.PlanetaId)
                .Column("PLANETA_ID")
                .LazyLoad();



        }
    }
}
