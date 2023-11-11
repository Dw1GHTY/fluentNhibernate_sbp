using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deathstar.Entiteti;
using FluentNHibernate.Mapping;

namespace Deathstar.Mapiranja
{
    class CivilnaStanicaMapiranja : ClassMap<CivilnaStanica>
    {
        public CivilnaStanicaMapiranja() 
        {
            //mapiranje tabele
            Table("CIVILNA_STANICA");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();


            //mapiranje svojstava
            Map(x => x.Naziv).Column("NAZIV");
            Map(x => x.BrojLjudi).Column("BR_LJUDI");
            Map(x => x.Velicina).Column("VELICINA");
            Map(x => x.Udaljenost).Column("UDALJENOST");
            Map(x => x.ZaTrgovinu).Column("ZA_TRGOVINU");
            Map(x => x.ZaNaucnaIstrazivanja).Column("ZA_NAUCNA_ISTRAZIVANJA");

            //mapiranje ka planeti
            References(x => x.PlanetaId)
               .Column("PLANETA_ID")
               .LazyLoad();
        }
    }
}
