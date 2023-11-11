using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Deathstar.Entiteti;

namespace Deathstar.Mapiranja
{
    class KvadrantMapiranja : ClassMap<Kvadrant>
    {
        KvadrantMapiranja()
        {
            //mapiranje tabele
            Table("KVADRANT");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();


            //mapiranje svojstava
            Map(x => x.ProcenjeniPrecnik).Column("PROCENJENI_PRECNIK");
            Map(x => x.RedniBroj).Column("REDNI_BROJ");

            //mapiranje ka galaksiji
            References(x => x.GalaksijaId)
               .Column("GALAKSIJA_ID")
               .LazyLoad();
        }
    }
}
