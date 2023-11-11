using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deathstar.Entiteti;
using FluentNHibernate.Mapping;

namespace Deathstar.Mapiranja
{
    class ZvezdaMapiranja : ClassMap<Zvezda>
    {
        public ZvezdaMapiranja() 
        {
            //mapiranje tabele
            Table("ZVEZDA");


            //mapiranje primarnog kljuca
            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();


            //mapiranje svojstava

            Map(x => x.Ime).Column("IME");
            Map(x => x.Tip).Column("TIP");

            //mapiranje planete M:N
            HasManyToMany(x => x.Planete)
                .Table("ZVEZDA_PLANETA_BLIZINA")
                .ParentKeyColumn("ZVEZDA_ID")
                .ChildKeyColumn("PLANETA_ID")
                .Cascade.All();

        }
    }
}
