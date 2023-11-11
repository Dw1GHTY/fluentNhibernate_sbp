using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deathstar.Entiteti;
using FluentNHibernate.Mapping;

namespace Deathstar.Mapiranja
{
    class PrirodniSatelitMapiranja : ClassMap<PrirodniSatelit>
    {
        public PrirodniSatelitMapiranja() 
        {
            //mapiranje tabele
            Table("PRIRODNI_SATELIT");


            //mapiranje primarnog kljuca
            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();


            //mapiranje svojstava
            Map(x => x.Naziv).Column("NAZIV");
            Map(x => x.Precnik).Column("PRECNIK");
            Map(x => x.Naseobine).Column("NASEOBINE");
            Map(x => x.Udaljenost).Column("UDALJENOST");


            //mapiranje ka planeti
            References(x => x.PlanetaId)
               .Column("PLANETA_ID")
               .LazyLoad();
        }
    }
}
