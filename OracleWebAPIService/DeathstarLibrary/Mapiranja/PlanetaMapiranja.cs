using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deathstar.Entiteti;
using FluentNHibernate.Mapping;

namespace Deathstar.Mapiranja
{
    class PlanetaMapiranja : ClassMap<Planeta>
    {
        public PlanetaMapiranja() 
        {
            //mapiranje tabele
            Table("PLANETA");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();


            //mapiranje svojstava

            Map(x => x.Naziv).Column("NAZIV");
            Map(x => x.BrojStanovnika).Column("BROJ_STANOVNIKA");
            Map(x => x.DominantnaRasa).Column("DOMINANTNA_RASA");
            Map(x => x.DrustvenoUredjenje).Column("DRUSTVENO_UREDJENJE");
            Map(x => x.Trilijum).Column("TRILIJUM");
            Map(x => x.Berilijum).Column("BERILIJUM");
            Map(x => x.Plutonijum).Column("PLUTONIJUM");
            Map(x => x.x).Column("X");
            Map(x => x.y).Column("Y");
            Map(x => x.z).Column("Z");
            Map(x => x.Maticna).Column("MATICNA");

            //mapiranje ka brodu
            HasMany(x => x.Brodovi)
               .KeyColumn("PLANETA_ID")
               .LazyLoad()
               .Cascade.SaveUpdate();
               //.Inverse();

            //mapiranje ka galaksiji
            References(x => x.GalaksijaId)
               .Column("GALAKSIJA_ID")
               .LazyLoad();

            //mapiranje ka gradu
            HasMany(x => x.Gradovi)
               .KeyColumn("PLANETA_ID")
               .LazyLoad()
               .Cascade.All();


            //mapiranje ka prirodnom satelitu
            HasMany(x => x.PrirodniSateliti)
               .KeyColumn("PLANETA_ID")
               .LazyLoad()
               .Cascade.All();


            //mapiranje ka vojnoj i civilnoj stanici
            HasMany(x => x.CivilneStanice)
               .KeyColumn("PLANETA_ID")
               .LazyLoad()
               .Cascade.All();

            HasMany(x => x.VojneStanice)
               .KeyColumn("PLANETA_ID")
               .LazyLoad()
               .Cascade.All();


            //mapiranje ka igracu
            References(x => x.IgracId)
               .Column("IGRAC_ID")
               .LazyLoad();

            //mapiranje kolonizacije/osvajanja
            HasMany(x => x.Kolonizacije)
               .KeyColumn("PLANETA_ID")
               .LazyLoad()
               .Cascade.SaveUpdate();


            HasMany(x => x.Osvajanja)
               .KeyColumn("PLANETA_ID")
               .LazyLoad()
               .Cascade.SaveUpdate();


            //mapiranje ka zvezdi M:N
            HasManyToMany(x => x.Zvezde)
                .Table("ZVEZDA_PLANETA_BLIZINA")
                .ParentKeyColumn("PLANETA_ID")
                .ChildKeyColumn("ZVEZDA_ID")
                .Cascade.All()
                .Inverse();

            //mapiranje ka spec pojavi
            HasManyToMany(x => x.SpecPojave)
                .Table("PLANETA_POJAVA_BLIZINA")
                .ParentKeyColumn("PLANETA_ID")
                .ChildKeyColumn("SPEC_POJAVA_ID")
                .Cascade.All()
                .Inverse();
        }
    }
}
