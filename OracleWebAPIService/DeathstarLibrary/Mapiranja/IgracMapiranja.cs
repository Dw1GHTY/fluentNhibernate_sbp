using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deathstar.Entiteti;
using FluentNHibernate.Mapping;

namespace Deathstar.Mapiranja
{
    class IgracMapiranja : ClassMap<Igrac>
    {
        public IgracMapiranja() 
        {
            //mapiranje tabele
            Table("IGRAC");

            //mapiranje primarnog kljuca
            Id(x => x.Id).Column("ID").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava

            Map(x => x.KorisnickoIme).Column("KORISNICKO_IME");
            Map(x => x.DatumOtvaranjaNaloga).Column("DATUM_OTVARANJA_NALOGA");
            Map(x => x.LicnoIme).Column("LICNO_IME");
            Map(x => x.SrednjeSlovo).Column("SREDNJE_SLOVO");
            Map(x => x.Prezime).Column("PREZIME");
            Map(x => x.Email).Column("EMAIL");
            Map(x => x.Pol).Column("POL");
            Map(x => x.DatumRodjenja).Column("DATUM_RODJENJA");
            Map(x => x.Drzava).Column("DRZAVA");
            Map(x => x.TekstualniOpis).Column("TEKSTUALNI_OPIS");
            Map(x => x.Slika).Column("SLIKA");

            //mapiranje ka savezu
            References(x => x.SavezId)
                .Column("SAVEZ_ID");


            //mapiranje ka brodu
            HasMany(x => x.Brodovi)
                 .KeyColumn("IGRAC_ID")
                 .LazyLoad()
                 .Cascade.All()
                 .Inverse();

            //mapiranje ka planeti
            HasMany(x => x.Planete)
                 .KeyColumn("IGRAC_ID")
                 .LazyLoad()
                 .Cascade.SaveUpdate();


            //mapiranje ka kolonizaciji
            HasMany(x => x.Kolonizacije)
                  .KeyColumn("IGRAC_ID")
                  .LazyLoad()
                  .Cascade.SaveUpdate(); 

            //mapiranje ka osvajanju
            HasMany(x => x.Osvajanja)
                  .KeyColumn("IGRAC_ID")
                  .LazyLoad()
                  .Cascade.SaveUpdate();


        }
    }
}
