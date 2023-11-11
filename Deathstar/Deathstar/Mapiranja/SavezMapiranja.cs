using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deathstar.Entiteti;
using FluentNHibernate.Mapping;

namespace Deathstar.Mapiranja
{
    class SavezMapiranja : ClassMap<Savez>
    {
        public SavezMapiranja() 
        {
            //mapiranje tabele
            Table("SAVEZ");

            //mapiranje primarnog kljuca
            //Id(x => x.Id).Column("ID").GeneratedBy.Sequence("S18289.SAVEZ_ID_SEQ");
            Id(x => x.Id).Column("ID").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava
            Map(x => x.Naziv, "NAZIV");
            Map(x => x.DatumFormiranja, "DATUM_FORMIRANJA");

            //mapiranje veze 1:N Savez-Savez
            References(x => x.SavezId)
                .Column("SAVEZ_ID")
                .LazyLoad();


            //mapiranje veze 1:N Igrac
            HasMany(x => x.Igraci)
                .KeyColumn("SAVEZ_ID")
                .LazyLoad()
                .Cascade.SaveUpdate();


            //mapiranje veze 1:N Brod
            HasMany(x => x.Brodovi)
             .KeyColumn("SAVEZ_ID")
             .LazyLoad()
             .Cascade.SaveUpdate();


            //mapiranje ka kolonizaciji
            HasMany(x => x.Kolonizacije)
                .KeyColumn("SAVEZ_ID")
                .LazyLoad()
                .Cascade.SaveUpdate();


            //mapiranje ka osvajanju
            HasMany(x => x.Osvajanja)
                  .KeyColumn("SAVEZ_ID")
                  .LazyLoad()
                  .Cascade.SaveUpdate();



        }


    }
}
