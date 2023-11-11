using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deathstar.Entiteti;
using FluentNHibernate.Mapping;

namespace Deathstar.Mapiranja
{
    class GradMapiranja : ClassMap<Grad>
    {
        public GradMapiranja() 
        {
            //mapiranje tabele
            Table("GRAD");


            //mapiranje primarnog kljuca
            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();


            //mapiranje svojstava
            Map(x => x.Naziv).Column("NAZIV");
            Map(x => x.Glavni).Column("GLAVNI");

            //mapiranje ka Planeti
            References(x => x.PlanetaId)
               .Column("PLANETA_ID")
               .LazyLoad();
        }
    }
}
