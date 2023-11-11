using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deathstar.Entiteti;

namespace Deathstar
{
    #region SAVEZ
    public class DTOSavez 
    {
        public int Id { get; protected set; }
        public string Naziv { get; set; }
        public DateTime DatumFormiranja { get; set; }
        public string SavezId_Naziv { get; set; }


        public IList<Igrac> Igraci { get; set; }
        public IList<Brod> Brodovi { get; set; }
        public IList<Kolonizacija> Kolonizacije { get; set; }
        public IList<Osvajanje> Osvajanja { get; set; }

        public DTOSavez() 
        {
            Igraci = new List<Igrac>();
            Brodovi = new List<Brod>();
            Kolonizacije = new List<Kolonizacija>();
            Osvajanja = new List<Osvajanje>();
        }
        public DTOSavez(int Id, string Naziv, DateTime DatumFormiranja, string SavezId_Naziv) 
        {
            Igraci = new List<Igrac>();
            Brodovi = new List<Brod>();
            Kolonizacije = new List<Kolonizacija>();
            Osvajanja = new List<Osvajanje>();

            this.Id = Id;
            this.Naziv = Naziv;
            this.DatumFormiranja = DatumFormiranja;
            this.SavezId_Naziv = SavezId_Naziv;
        }
    }
    #endregion

    #region PLANETA
    public class DTOPlaneta
    {
        public virtual int Id { get; set; }
        public virtual string Naziv { get; set; }
        public virtual int BrojStanovnika { get; set; }
        public virtual string DominantnaRasa { get; set; }
        public virtual string DrustvenoUredjenje { get; set; }
        public virtual int Trilijum { get; set; }
        public virtual int Berilijum { get; set; }
        public virtual int Plutonijum { get; set; }
        public virtual int x { get; set; }
        public virtual int y { get; set; }
        public virtual int z { get; set; }
        public virtual string Maticna { get; set; }

        public virtual string IgracId_KorisnickoIme { get; set; }
        public virtual string GalaksijaId_Ime { get; set; }
        public virtual IList<Brod> Brodovi { get; set; }
        public virtual IList<Grad> Gradovi { get; set; }
        public virtual IList<PrirodniSatelit> PrirodniSateliti { get; set; }
        public virtual IList<CivilnaStanica> CivilneStanice { get; set; }
        public virtual IList<VojnaStanica> VojneStanice { get; set; }
        public virtual IList<Kolonizacija> Kolonizacije { get; set; }
        public virtual IList<Osvajanje> Osvajanja { get; set; }
        public virtual IList<Zvezda> Zvezde { get; set; }
        public virtual IList<SpecPojava> SpecPojave { get; set; }

        public DTOPlaneta()
        {
            Brodovi = new List<Brod>();
            Gradovi = new List<Grad>();
            PrirodniSateliti = new List<PrirodniSatelit>();
            CivilneStanice = new List<CivilnaStanica>();
            VojneStanice = new List<VojnaStanica>();
            Kolonizacije = new List<Kolonizacija>();
            Osvajanja = new List<Osvajanje>();
            Zvezde = new List<Zvezda>();
            SpecPojave = new List<SpecPojava>();
        }

        public DTOPlaneta(int Id, string Naziv, int BrojStanovnika, string DominantnaRasa, string DrustvenoUredjenje, int Trilijum, int Berilijum, int Plutonijum
                            ,int x, int y, int z, string Maticna, string IgracId_KorisnickoIme, string GalaksijaId_Ime)
        {
            Brodovi = new List<Brod>();
            Gradovi = new List<Grad>();
            PrirodniSateliti = new List<PrirodniSatelit>();
            CivilneStanice = new List<CivilnaStanica>();
            VojneStanice = new List<VojnaStanica>();
            Kolonizacije = new List<Kolonizacija>();
            Osvajanja = new List<Osvajanje>();
            Zvezde = new List<Zvezda>();
            SpecPojave = new List<SpecPojava>();

            this.Id= Id;
            this.Naziv= Naziv;
            this.BrojStanovnika= BrojStanovnika;
            this.DominantnaRasa= DominantnaRasa;
            this.DrustvenoUredjenje = DrustvenoUredjenje;
            this.Trilijum = Trilijum;
            this.Berilijum = Berilijum;
            this.Plutonijum = Plutonijum;
            this.x = x;
            this.y = y;
            this.z = z;
            this.Maticna = Maticna;
            this.IgracId_KorisnickoIme = IgracId_KorisnickoIme;
            this.GalaksijaId_Ime = GalaksijaId_Ime;
        }
    }
    #endregion

    #region BROD
    public class DTOBrod
    {
        public int JedinstveniBroj { get; set; }
        public string Naziv { get; set; }
        public int MaxWarp { get; set; }
        public int BrojLaserskihTopova { get; set; }
        public string FotonskaTorpeda { get; set; }
        public string Tip { get; set; }
        public string ZastitnaOplata { get; set; }
        public int Nosivost { get; set; }
        public string VrstaBroda { get; set; }

        public string IgracId_KorisnickoIme { get; set; }
        public string SavezId_NazivSaveza { get; set; }
        public string PlanetaId_NazivPlanete { get; set; }

        public DTOBrod()
        {

        }

        public DTOBrod(int JedinstveniBroj, string Naziv, int MaxWarp, int BrojLaserskihTopova,
                       string FotonskaTorpeda, string Tip, string ZastitnaOplata, int Nosivost,
                       string VrstaBroda,
                       string IgracId_KorisnickoIme, string SavezId_NazivSaveza, string PlanetaId_NazivPlanete)
        {
            this.JedinstveniBroj = JedinstveniBroj;
            this.Naziv = Naziv;
            this.MaxWarp = MaxWarp;
            this.BrojLaserskihTopova = BrojLaserskihTopova;
            this.FotonskaTorpeda = FotonskaTorpeda;
            this.Tip = Tip;
            this.ZastitnaOplata = ZastitnaOplata;
            this.Nosivost = Nosivost;
            this.VrstaBroda = VrstaBroda;
            this.IgracId_KorisnickoIme = IgracId_KorisnickoIme;
            this.SavezId_NazivSaveza = SavezId_NazivSaveza;
            this.PlanetaId_NazivPlanete = PlanetaId_NazivPlanete;

        }
    }
    #endregion

    #region IGRAC
    public class DTOIgrac
    {
        public int Id { get; protected set; }
        public string KorisnickoIme { get; set; }
        public DateTime DatumOtvaranjaNaloga { get; set; }
        public string LicnoIme { get; set; }
        public string SrednjeSlovo { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Pol { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Drzava { get; set; }
        public string TekstualniOpis { get; set; }
        public string Slika { get; set; }

        public string SavezId_NazivSaveza { get; set; }
        public IList<Brod> Brodovi { get; set; }
        public IList<Planeta> Planete { get; set; }
        public IList<Kolonizacija> Kolonizacije { get; set; }
        public IList<Osvajanje> Osvajanja { get; set; }

        public DTOIgrac()
        {
            Brodovi = new List<Brod>();
            Planete = new List<Planeta>();
            Kolonizacije = new List<Kolonizacija>();
            Osvajanja = new List<Osvajanje>();
        }
        public DTOIgrac(int Id, string KorisnickoIme, DateTime DatumOtvaranjaNaloga, string LicnoIme, string SrednjeSlovo, string Prezime,
                                    string Email, string Pol, DateTime DatumRodjenja, string Drzava, string TekstualniOpis, string Slika, string SavezId_NazivSaveza)
        {
            Brodovi = new List<Brod>();
            Planete = new List<Planeta>();
            Kolonizacije = new List<Kolonizacija>();
            Osvajanja = new List<Osvajanje>();

            this.Id = Id;
            this.KorisnickoIme = KorisnickoIme;
            this.DatumOtvaranjaNaloga = DatumOtvaranjaNaloga;
            this.LicnoIme = LicnoIme;
            this.SrednjeSlovo = SrednjeSlovo;
            this.Prezime = Prezime;
            this.Email = Email;
            this.Pol = Pol;
            this.DatumRodjenja = DatumRodjenja;
            this.Drzava = Drzava;
            this.TekstualniOpis = TekstualniOpis;
            this.Slika = Slika;
            this.SavezId_NazivSaveza = SavezId_NazivSaveza;
        }
    }
    #endregion

    #region KOLONIZACIJA
    public class DTOKolonizacija
    {
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public string IgracVrsi_ImeIgraca { get; set; }
        public string SavezVrsi_ImeSaveza { get; set; }
        public string PlanetaKolonizuje_ImePlanete { get; set; }

        public DTOKolonizacija() { }
        public DTOKolonizacija(int Id, DateTime Datum, string IgracVrsi_ImeIgraca, string SavezVrsi_ImeSaveza, string PlanetaKolonizuje_ImePlanete)
        {
            this.Id = Id;
            this.Datum = Datum;
            this.IgracVrsi_ImeIgraca = IgracVrsi_ImeIgraca;
            this.SavezVrsi_ImeSaveza = SavezVrsi_ImeSaveza;
            this.PlanetaKolonizuje_ImePlanete = PlanetaKolonizuje_ImePlanete;
        }
    }
    #endregion

    #region OSVAJANJA
    public class DTOOsvajanje
    {
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public string PrethodniVlasnikIgrac { get; set; }
        public string PrethodniVlasnikSavez { get; set; }
        public string IgracVrsi_ImeIgraca { get; set; }
        public string SavezVrsi_ImeSaveza { get; set; }
        public string PlanetaOsvaja_ImePlanete { get; set; }

        public DTOOsvajanje() { }
        public DTOOsvajanje(int id, DateTime datum, string prethodniVlasnikIgrac, string prethodniVlasnikSavez,
                            string igracVrsi_ImeIgraca, string savezVrsi_ImeSaveza, string planetaOsvaja_ImePlanete)
        {
            Id = id;
            Datum = datum;
            PrethodniVlasnikIgrac = prethodniVlasnikIgrac;
            PrethodniVlasnikSavez = prethodniVlasnikSavez;
            IgracVrsi_ImeIgraca = igracVrsi_ImeIgraca;
            SavezVrsi_ImeSaveza = savezVrsi_ImeSaveza;
            PlanetaOsvaja_ImePlanete = planetaOsvaja_ImePlanete;
        }
    }
    #endregion

    #region GRAD
    public class DTOGrad
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Glavni { get; set; }
        public string PlanetaId_ImePlanete { get; set; }
        public DTOGrad() { }
        public DTOGrad(int id, string naziv, string glavni, string planetaId_ImePlanete)
        {
            Id = id;
            Naziv = naziv;
            Glavni = glavni;
            PlanetaId_ImePlanete = planetaId_ImePlanete;
        }
    }
    #endregion

    #region PRIRODNI_SATELIT
    public class DTOPrirodniSatelit
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int Precnik { get; set; }
        public string Naseobine { get; set; }
        public int Udaljenost { get; set; }

        public string PlanetaId_ImePlanete { get; set; }

        public DTOPrirodniSatelit() { }
        public DTOPrirodniSatelit(int id, string naziv, int precnik, string naseobine, int udaljenost, string planetaId_ImePlanete)
        {
            Id = id;
            Naziv = naziv;
            Precnik = precnik;
            Naseobine = naseobine;
            Udaljenost = udaljenost;
            PlanetaId_ImePlanete = planetaId_ImePlanete;
        }
    }
    #endregion

    #region ZVEZDA
    public class DTOZvezda
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Tip { get; set; }
        public IList<Planeta> Planete { get; set; }

        public DTOZvezda()
        {
            Planete = new List<Planeta>();
        }

        public DTOZvezda(int Id, string Ime, string Tip)
        {
            Planete = new List<Planeta>();

            this.Id = Id;
            this.Ime = Ime;
            this.Tip = Tip;
        }
    }
    #endregion

    #region ZVEZDA_PLANETA_BLIZINA
    public class DTOZvezdaPlanetaBlizina
    {
        public virtual int Id { get; set; }
        public virtual string PlanetaId_ImePlanete { get; set; }
        public virtual string ZvezdaId_ImeZvezde { get; set; }

        public DTOZvezdaPlanetaBlizina() { }
        public DTOZvezdaPlanetaBlizina(int Id, string PlanetaId_ImePlanete, string ZvezdaId_ImeZvezde)
        {
            this.Id = Id;
            this.PlanetaId_ImePlanete = PlanetaId_ImePlanete;
            this.ZvezdaId_ImeZvezde = ZvezdaId_ImeZvezde;
        }
    }
    #endregion

    #region SPEC_POJAVA
    public class DTOSpecPojava
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Tip { get; set; }
        public string PotOpasnost { get; set; }
        public IList<Planeta> Planete { get; set; }

        public DTOSpecPojava()
        {
            Planete = new List<Planeta>();
        }
        public DTOSpecPojava(int Id, string Naziv, string Tip, string PotOpasnost)
        {
            this.Id = Id;
            this.Naziv = Naziv;
            this.Tip = Tip;
            this.PotOpasnost = PotOpasnost;
        }
    }
    #endregion

    #region PLANETA_POJAVA_BLIZINA
    public class DTOPlanetaPojavaBlizina
    {
        public int Id { get; set; }
        public int Udaljenost { get; set; }
        public string PlanetaId_ImePlanete { get; set; }
        public string SpecPojavaId_ImePojave { get; set; }

        public DTOPlanetaPojavaBlizina() { }
        public DTOPlanetaPojavaBlizina(int id, int udaljenost, string planetaId_ImePlanete, string specPojavaId_ImePojave)
        {
            Id = id;
            Udaljenost = udaljenost;
            PlanetaId_ImePlanete = planetaId_ImePlanete;
            SpecPojavaId_ImePojave = specPojavaId_ImePojave;
        }
    }
    #endregion

    #region GALAKSIJA
    public class DTOGalaksija
    {
        public virtual int Id { get; set; }
        public virtual string Ime { get; set; }
        public virtual string DominantnaRasa { get; set; }
        public virtual int ProcenjeniBrojPlaneta { get; set; }
        public virtual int ProcenjeniBrojZvezda { get; set; }
        public virtual IList<Planeta> Planete { get; set; }
        public virtual IList<Kvadrant> Kvadranti { get; set; }
        public DTOGalaksija()
        {
            Planete = new List<Planeta>();
            Kvadranti = new List<Kvadrant>();
        }
        public DTOGalaksija(int id, string ime, string dominantnaRasa, int procenjeniBrojPlaneta, int procenjeniBrojZvezda)
        {
            Planete = new List<Planeta>();
            Kvadranti = new List<Kvadrant>();

            Id = id;
            Ime = ime;
            DominantnaRasa = dominantnaRasa;
            ProcenjeniBrojPlaneta = procenjeniBrojPlaneta;
            ProcenjeniBrojZvezda = procenjeniBrojZvezda;
        }
    }
    #endregion

    #region KVADRANT
    public class DTOKvadrant
    {
        public virtual int Id { get; set; }
        public virtual int ProcenjeniPrecnik { get; set; }
        public virtual int RedniBroj { get; set; }
        public virtual string GalaksijaId_ImeGalaksije { get; set; }

        public DTOKvadrant() { }
        public DTOKvadrant(int id, int procenjeniPrecnik, int redniBroj, string galaksijaId_ImeGalaksije)
        {
            Id = id;
            ProcenjeniPrecnik = procenjeniPrecnik;
            RedniBroj = redniBroj;
            GalaksijaId_ImeGalaksije = galaksijaId_ImeGalaksije;
        }
    }
    #endregion

    #region CIVILNA_STANICA
    public class DTOCivilnaStanica
    {
        public virtual int Id { get; set; }
        public virtual string Naziv { get; set; }
        public virtual int BrojLjudi { get; set; }
        public virtual int Velicina { get; set; }
        public virtual int Udaljenost { get; set; }
        public virtual string ZaTrgovinu { get; set; }
        public virtual string ZaNaucnaIstrazivanja { get; set; }

        public virtual string PlanetaId_ImePlanete { get; set; }

        public DTOCivilnaStanica() { }
        public DTOCivilnaStanica(int id, string naziv, int brojLjudi, int velicina, int udaljenost, string zaTrgovinu, string zaNaucnaIstrazivanja, string planetaId_ImePlanete)
        {
            Id = id;
            Naziv = naziv;
            BrojLjudi = brojLjudi;
            Velicina = velicina;
            Udaljenost = udaljenost;
            ZaTrgovinu = zaTrgovinu;
            ZaNaucnaIstrazivanja = zaNaucnaIstrazivanja;
            PlanetaId_ImePlanete = planetaId_ImePlanete;
        }
    }
    #endregion

    #region VOJNA_STANICA
    public class DTOVojnaStanica
    {
        public virtual int Id { get; set; }
        public virtual string Naziv { get; set; }
        public virtual int BrojLjudi { get; set; }
        public virtual int Velicina { get; set; }
        public virtual int Udaljenost { get; set; }
        public virtual string SpisakOruzja { get; set; }

        public virtual string PlanetaId_ImePlanete { get; set; }

        public DTOVojnaStanica() { }
        public DTOVojnaStanica(int id, string naziv, int brojLjudi, int velicina, int udaljenost, string spisakOruzja, string planetaId_ImePlanete)
        {
            Id = id;
            Naziv = naziv;
            BrojLjudi = brojLjudi;
            Velicina = velicina;
            Udaljenost = udaljenost;
            SpisakOruzja = spisakOruzja;
            PlanetaId_ImePlanete = planetaId_ImePlanete;
        }
    }
    #endregion
}
