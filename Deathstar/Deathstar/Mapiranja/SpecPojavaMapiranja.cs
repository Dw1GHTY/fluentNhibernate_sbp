using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deathstar.Entiteti;
using FluentNHibernate.Mapping;

namespace Deathstar.Mapiranja
{
    class SpecPojavaMapiranja : ClassMap<SpecPojava>
    {
        public SpecPojavaMapiranja() 
        {
            //mapiranje tabele
            Table("SPEC_POJAVA");


            //mapiranje primarnog kljuca
            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();


            //mapiranje svojstava
            Map(x => x.Naziv).Column("NAZIV");
            Map(x => x.Tip).Column("TIP");
            Map(x => x.PotOpasnost).Column("POT_OPASNOST");

            //mapiranje ka planeti
            HasManyToMany(x => x.Planete)
                .Table("PLANETA_POJAVA_BLIZINA")
                .ParentKeyColumn("SPEC_POJAVA_ID")
                .ChildKeyColumn("PLANETA_ID")
                .Cascade.All();
        }
    }
}
