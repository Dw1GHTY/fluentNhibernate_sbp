using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deathstar.Entiteti;
using FluentNHibernate.Mapping;

namespace Deathstar.Mapiranja
{
    class GalaksijaMapiranja : ClassMap<Galaksija>
    {
        public GalaksijaMapiranja() 
        {
            //mapiranje tabele
            Table("GALAKSIJA");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();


            //mapiranje svojstava
            Map(x => x.Ime).Column("IME");
            Map(x => x.DominantnaRasa).Column("DOMINANTNA_RASA");
            Map(x => x.ProcenjeniBrojPlaneta).Column("PROCENJENI_BR_PLANETA");
            Map(x => x.ProcenjeniBrojZvezda).Column("PROCENJENI_BR_ZVEZDA");

            //mapiranje ka planeti
            HasMany(x => x.Planete)
             .KeyColumn("GALAKSIJA_ID")
             .LazyLoad()
             .Cascade.All()
             .Inverse();

            //mapiranje ka kvadrantu
            HasMany(x => x.Kvadranti)
             .KeyColumn("GALAKSIJA_ID")
             .LazyLoad()
             .Cascade.All()
             .Inverse();
        }
    }
}
