using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deathstar.Entiteti;
using NHibernate.Linq;
using Deathstar;
using NHibernate;
using System.Windows.Forms;

namespace Deathstar
{
    public class DTOManager
    {
        #region SAVEZ
        public static List<DTOSavez> vratiSveSaveze()
        {
            List<DTOSavez> savezi = new List<DTOSavez>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Savez> sviSavezi = from o in s.Query<Savez>()
                                               select o;

                foreach (Savez p in sviSavezi)
                {
                    string savezIme = "/";
                    if (p.SavezId != null)
                        savezIme = p.SavezId.Naziv;
                    savezi.Add(new DTOSavez(p.Id, p.Naziv, p.DatumFormiranja, savezIme));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Greska pri vracanju svih saveza: " + ec);
            }

            return savezi;

        }
        public static List<DTOKolonizacija> vratiKolonizacijeSaveza(int id)
        {
            List<DTOKolonizacija> kolonizacije = new List<DTOKolonizacija>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Kolonizacija> sveKolonizacije = from o in s.Query<Kolonizacija>()
                                                            where o.SavezVrsi.Id == id
                                                            select o;


                foreach (Kolonizacija p in sveKolonizacije)
                {
                    string igracIme = "/";
                    string savezIme = "/";
                    string planetaIme = "/";
                    if (p.IgracVrsi != null)
                        igracIme = p.IgracVrsi.KorisnickoIme;
                    if (p.SavezVrsi != null)
                        savezIme = p.SavezVrsi.Naziv;
                    if (p.PlanetaKolonizuje != null)
                        planetaIme = p.PlanetaKolonizuje.Naziv;

                    kolonizacije.Add(new DTOKolonizacija(p.Id, p.Datum, igracIme, savezIme, planetaIme));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Greska pri vracanju svih brodova: " + ec);
            }

            return kolonizacije;
        }
        public static List<DTOOsvajanje> vratiOsvajanjaSaveza(int id)
        {
            List<DTOOsvajanje> osvajanja = new List<DTOOsvajanje>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Osvajanje> svaOsvajanja = from o in s.Query<Osvajanje>()
                                                      where o.SavezVrsi.Id == id
                                                      select o;


                foreach (Osvajanje p in svaOsvajanja)
                {

                    string igracIme = "/";
                    string savezIme = "/";
                    string planetaIme = "/";

                    string prethodniIgrac = "/";
                    string prethodniSavez = "/";
                    if (p.PrethodniVlasnikIgrac != null)
                        prethodniIgrac = (s.Load<Igrac>(Int32.Parse(p.PrethodniVlasnikIgrac))).KorisnickoIme;
                    if (p.PrethodniVlasnikSavez != null)
                        prethodniSavez = (s.Load<Savez>(Int32.Parse(p.PrethodniVlasnikSavez))).Naziv;

                    if (p.IgracVrsi != null)
                        igracIme = p.IgracVrsi.KorisnickoIme;
                    if (p.SavezVrsi != null)
                        savezIme = p.SavezVrsi.Naziv;
                    if (p.PlanetaOsvaja != null)
                        planetaIme = p.PlanetaOsvaja.Naziv;

                    osvajanja.Add(new DTOOsvajanje(p.Id, p.Datum, prethodniIgrac, prethodniSavez, igracIme, savezIme, planetaIme));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Greska pri vracanju svih osvajanja: " + ec);
            }

            return osvajanja;
        }
        public static void obrisiSavez(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Savez o = s.Load<Savez>(id);

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Nije uspesno obrisan savez" + ec);
            }
        }
        public static DTOSavez vratiSavez(int id)
        {
            DTOSavez b = new DTOSavez();
            try
            {
                ISession s = DataLayer.GetSession();


                Savez p = s.Load<Savez>(id);

                string imeSaveza = "";

                if (p.SavezId != null)
                    imeSaveza = p.SavezId.Naziv;

                b = new DTOSavez(p.Id, p.Naziv, p.DatumFormiranja, imeSaveza);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Nije uspesno vracanje saveza" + ec);
            }

            return b;
        }
        public static int azurirajSavez(DTOSavez b)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Savez o = s.Load<Savez>(b.Id);
                Savez podsavez = null;

                if (b.SavezId_Naziv != "")
                    podsavez = s.Load<Savez>(Int32.Parse(b.SavezId_Naziv));

                o.Naziv = b.Naziv;
                o.DatumFormiranja = b.DatumFormiranja;
                o.SavezId = podsavez;

                s.Update(o);
                s.Flush();

                s.Close();
                return 0;
            }
            catch (Exception ec)
            {
                MessageBox.Show("Nije uspesno azuriranje saveza" + ec);
                return 1;
            }
        }
        public static void dodajSavez(DTOSavez p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Savez o = new Savez();

                Savez sa = s.Load<Savez>(Int32.Parse(p.SavezId_Naziv));

                o.Naziv = p.Naziv;
                o.DatumFormiranja = p.DatumFormiranja;
                o.SavezId = sa;



                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Neuspesno dodavanje novog saveza" + ec);
            }
        }
        #endregion

        #region IGRAC
        public static List<DTOIgrac> vratiSveIgrace()
        {
            List<DTOIgrac> igraci = new List<DTOIgrac>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Igrac> sviIgraci = from o in s.Query<Igrac>()
                                               select o;

                foreach (Igrac p in sviIgraci)
                {
                    string savezIme = "/";

                    if (p.SavezId != null)
                        savezIme = p.SavezId.Naziv;

                    igraci.Add(new DTOIgrac(p.Id, p.KorisnickoIme, p.DatumOtvaranjaNaloga, p.LicnoIme, p.SrednjeSlovo, p.Prezime, p.Email,
                                                p.Pol, p.DatumRodjenja, p.Drzava, p.TekstualniOpis, p.Slika, savezIme));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Greska pri vracanju svih igraca: " + ec);
            }

            return igraci;
        }
        public static List<DTOKolonizacija> vratiKolonizacijeIgraca(int id)
        {
            List<DTOKolonizacija> kolonizacije = new List<DTOKolonizacija>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Kolonizacija> sveKolonizacije = from o in s.Query<Kolonizacija>()
                                                            where o.IgracVrsi.Id == id
                                                            select o;


                foreach (Kolonizacija p in sveKolonizacije)
                {
                    string igracIme = "/";
                    string savezIme = "/";
                    string planetaIme = "/";
                    if (p.IgracVrsi != null)
                        igracIme = p.IgracVrsi.KorisnickoIme;
                    if (p.SavezVrsi != null)
                        savezIme = p.SavezVrsi.Naziv;
                    if (p.PlanetaKolonizuje != null)
                        planetaIme = p.PlanetaKolonizuje.Naziv;

                    kolonizacije.Add(new DTOKolonizacija(p.Id, p.Datum, igracIme, savezIme, planetaIme));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Greska pri vracanju svih brodova: " + ec);
            }

            return kolonizacije;
        }
        public static List<DTOOsvajanje> vratiOsvajanjaIgraca(int id)
        {
            List<DTOOsvajanje> osvajanja = new List<DTOOsvajanje>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Osvajanje> svaOsvajanja = from o in s.Query<Osvajanje>()
                                                      where o.IgracVrsi.Id == id
                                                      select o;


                foreach (Osvajanje p in svaOsvajanja)
                {
                    string igracIme = "/";
                    string savezIme = "/";
                    string planetaIme = "/";
                    string prethodniIgrac = "/";
                    string prethodniSavez = "/";
                    if (p.PrethodniVlasnikIgrac != null)
                        prethodniIgrac = (s.Load<Igrac>(Int32.Parse(p.PrethodniVlasnikIgrac))).KorisnickoIme;
                    if (p.PrethodniVlasnikSavez != null)
                        prethodniSavez = (s.Load<Savez>(Int32.Parse(p.PrethodniVlasnikSavez))).Naziv;

                    if (p.IgracVrsi != null)
                        igracIme = p.IgracVrsi.KorisnickoIme;
                    if (p.SavezVrsi != null)
                        savezIme = p.SavezVrsi.Naziv;
                    if (p.PlanetaOsvaja != null)
                        planetaIme = p.PlanetaOsvaja.Naziv;

                    osvajanja.Add(new DTOOsvajanje(p.Id, p.Datum, prethodniIgrac, prethodniSavez, igracIme, savezIme, planetaIme));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Greska pri vracanju svih osvajanja: " + ec);
            }

            return osvajanja;
        }
        public static void obrisiIgraca(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Igrac o = s.Load<Igrac>(id);

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Nije uspesno obrisan igrac" + ec);
            }
        }
        public static void dodajIgraca(DTOIgrac p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Igrac o = new Igrac();

                Savez sa1 = s.Load<Savez>(Int32.Parse(p.SavezId_NazivSaveza));

                o.KorisnickoIme = p.KorisnickoIme;
                o.DatumOtvaranjaNaloga = p.DatumOtvaranjaNaloga;
                o.LicnoIme = p.LicnoIme;
                o.SrednjeSlovo = p.SrednjeSlovo;
                o.Prezime = p.Prezime;
                o.Email = p.Email;
                o.Pol = p.Pol;
                o.DatumRodjenja = p.DatumRodjenja;
                o.Drzava = p.Drzava;
                o.TekstualniOpis = p.TekstualniOpis;
                o.Slika = p.Slika;
                o.SavezId = sa1; 

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Neuspesno dodavanje novog igraca" + ec);
            }
        }
        public static DTOIgrac vratiIgraca(int id)
        {
            DTOIgrac b = new DTOIgrac();
            try
            {
                ISession s = DataLayer.GetSession();
                Igrac p = s.Load<Igrac>(id);

                string imeSaveza = "";

                if (p.SavezId != null)
                    imeSaveza = p.SavezId.Naziv;


                b = new DTOIgrac(p.Id, p.KorisnickoIme, p.DatumOtvaranjaNaloga, p.LicnoIme, p.SrednjeSlovo, p.Prezime,
                                   p.Email, p.Pol, p.DatumRodjenja, p.Drzava, p.TekstualniOpis, p.Slika, imeSaveza);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Nije uspesno vracanje igraca" + ec);
            }

            return b;
        }
        public static int azurirajIgraca(DTOIgrac b)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Igrac o = s.Load<Igrac>(b.Id);

                Savez sav = null;
                if (b.SavezId_NazivSaveza != "")
                    sav = s.Load<Savez>(Int32.Parse(b.SavezId_NazivSaveza));


                o.KorisnickoIme = b.KorisnickoIme;
                o.DatumOtvaranjaNaloga = b.DatumOtvaranjaNaloga;
                o.LicnoIme = b.LicnoIme;
                o.SrednjeSlovo = b.SrednjeSlovo;
                o.Prezime = b.Prezime;
                o.Email = b.Email;
                o.Pol = b.Pol;
                o.DatumRodjenja = b.DatumRodjenja;
                o.Drzava = b.Drzava;
                o.TekstualniOpis = b.TekstualniOpis;
                o.Slika = b.Slika;
                o.SavezId = sav;

                s.Update(o);
                s.Flush();

                s.Close();
                return 0;
            }
            catch (Exception ec)
            {
                MessageBox.Show("Nije uspesno azuriranje saveza" + ec);
                return 1;
            }
        }

        #endregion

        #region BROD
        public static List<DTOBrod> vratiSveBrodoveZaIgraca(int id)
        {
            List<DTOBrod> brodovi = new List<DTOBrod>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Brod> sviBrodovi = from o in s.Query<Brod>()
                                               where o.PripadaIgracu.Id == id
                                               select o;


                foreach (Brod p in sviBrodovi)
                {
                    string igracIme = "/";
                    string savezIme = "/";
                    string planetaIme = "/";
                    if (p.PripadaIgracu != null)
                        igracIme = p.PripadaIgracu.KorisnickoIme;
                    if (p.PripadaSavezu != null)
                        savezIme = p.PripadaSavezu.Naziv;
                    if (p.IzgradjenNaPlaneti != null)
                        planetaIme = p.IzgradjenNaPlaneti.Naziv;

                    brodovi.Add(new DTOBrod(p.JedinstveniBroj, p.Naziv, p.MaxWarp, p.BrojLaserskihTopova, p.FotonskaTorpeda, p.Tip, p.ZastitnaOplata, p.Nosivost,
                                                p.VrstaBroda, igracIme, savezIme, planetaIme));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Greska pri vracanju svih brodova: " + ec);
            }

            return brodovi;
        }
        public static List<DTOBrod> vratiSveBrodoveZaSavez(int id)
        {
            List<DTOBrod> brodovi = new List<DTOBrod>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Brod> sviBrodovi = from o in s.Query<Brod>()
                                               where o.PripadaSavezu.Id == id
                                               select o;


                foreach (Brod p in sviBrodovi)
                {
                    string igracIme = "/";
                    string savezIme = "/";
                    string planetaIme = "/";
                    if (p.PripadaIgracu != null)
                        igracIme = p.PripadaIgracu.KorisnickoIme;
                    if (p.PripadaSavezu != null)
                        savezIme = p.PripadaSavezu.Naziv;
                    if (p.IzgradjenNaPlaneti != null)
                        planetaIme = p.IzgradjenNaPlaneti.Naziv;

                    brodovi.Add(new DTOBrod(p.JedinstveniBroj, p.Naziv, p.MaxWarp, p.BrojLaserskihTopova, p.FotonskaTorpeda, p.Tip, p.ZastitnaOplata, p.Nosivost,
                                                p.VrstaBroda, igracIme, savezIme, planetaIme));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Greska pri vracanju svih brodova: " + ec);
            }

            return brodovi;
        }
        public static List<DTOBrod> vratiBrodovePlanete(int id)
        {
            List<DTOBrod> brodovi = new List<DTOBrod>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Brod> sviBrodovi = from o in s.Query<Brod>()
                                               where o.IzgradjenNaPlaneti.Id == id
                                               select o;


                foreach (Brod p in sviBrodovi)
                {
                    string igracIme = "/";
                    string savezIme = "/";
                    string planetaIme = "/";
                    if (p.PripadaIgracu != null)
                        igracIme = p.PripadaIgracu.KorisnickoIme;
                    if (p.PripadaSavezu != null)
                        savezIme = p.PripadaSavezu.Naziv;
                    if (p.IzgradjenNaPlaneti != null)
                        planetaIme = p.IzgradjenNaPlaneti.Naziv;

                    brodovi.Add(new DTOBrod(p.JedinstveniBroj, p.Naziv, p.MaxWarp, p.BrojLaserskihTopova, p.FotonskaTorpeda, p.Tip, p.ZastitnaOplata, p.Nosivost,
                                                p.VrstaBroda, igracIme, savezIme, planetaIme));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Greska pri vracanju svih brodova: " + ec);
            }

            return brodovi;
        }
        public static DTOBrod vratiBrod(int id)
        {
            DTOBrod b = new DTOBrod();
            try
            {
                ISession s = DataLayer.GetSession();

                Brod p = s.Load<Brod>(id);

                string igracIme = "/";
                string savezIme = "/";
                string planetaIme = "/";
                if (p.PripadaIgracu != null)
                    igracIme = p.PripadaIgracu.KorisnickoIme;
                if (p.PripadaSavezu != null)
                    savezIme = p.PripadaSavezu.Naziv;
                if (p.IzgradjenNaPlaneti != null)
                    planetaIme = p.IzgradjenNaPlaneti.Naziv;

                b = new DTOBrod(p.JedinstveniBroj, p.Naziv, p.MaxWarp, p.BrojLaserskihTopova, 
                                p.FotonskaTorpeda, p.Tip, p.ZastitnaOplata, p.Nosivost,
                                p.VrstaBroda, igracIme, savezIme, planetaIme);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Nije uspesno vracanje broda" + ec);
            }

            return b;
        }
        public static void obrisiBrodoveIgraca(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Brod o = s.Load<Brod>(id);

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Nije uspesno obrisan brod" + ec);
            }
        }
        public static void dodajBrodIgracu(DTOBrod p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Brod o = new Brod();
                Planeta pl = new Planeta();
                Igrac i = new Igrac();

                o.IzgradjenNaPlaneti = null;
                if(p.PlanetaId_NazivPlanete != "")
                    pl = s.Load<Planeta>(Int32.Parse(p.PlanetaId_NazivPlanete));
                i = s.Load<Igrac>(Int32.Parse(p.IgracId_KorisnickoIme));

                o.Naziv = p.Naziv;
                o.MaxWarp = p.MaxWarp;
                o.BrojLaserskihTopova = p.BrojLaserskihTopova;
                o.FotonskaTorpeda = p.FotonskaTorpeda;
                o.Tip = p.Tip;
                o.ZastitnaOplata = p.ZastitnaOplata;
                o.Nosivost = p.Nosivost;
                o.VrstaBroda = p.VrstaBroda;
                o.PripadaIgracu = i;
                o.IzgradjenNaPlaneti = pl;


                s.Save(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Neuspesno dodavanje novog broda igracu" + ec);
            }
        }
        public static void dodajBrodPlaneti(DTOBrod p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Brod o = new Brod();
               
                Planeta pl = null;
                Igrac igr = null;
                Savez sav = null;
                
                if(p.PlanetaId_NazivPlanete != "")
                    pl = s.Load<Planeta>(Int32.Parse(p.PlanetaId_NazivPlanete));
                if (p.SavezId_NazivSaveza != "")
                    sav = s.Load<Savez>(Int32.Parse(p.SavezId_NazivSaveza));
                if (p.IgracId_KorisnickoIme != "")
                    igr = s.Load<Igrac>(Int32.Parse(p.IgracId_KorisnickoIme));

                o.Naziv = p.Naziv;
                o.MaxWarp = p.MaxWarp;
                o.BrojLaserskihTopova = p.BrojLaserskihTopova;
                o.FotonskaTorpeda = p.FotonskaTorpeda;
                o.Tip = p.Tip;
                o.ZastitnaOplata = p.ZastitnaOplata;
                o.Nosivost = p.Nosivost;
                o.VrstaBroda = p.VrstaBroda;
                o.IzgradjenNaPlaneti = pl;
                o.PripadaSavezu = sav;
                o.PripadaIgracu = igr;
                


                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Neuspesno dodavanje novog broda planeti" + ec);
            }
        }
        public static void obrisiBrodPlanete(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Brod o = s.Load<Brod>(id);

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Nije uspesno obrisan brod" + ec);
            }
        }
        public static int azurirajBrod(DTOBrod b)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Brod o = s.Load<Brod>(b.JedinstveniBroj);         
                o.Naziv = b.Naziv;
                o.MaxWarp = b.MaxWarp;
                o.BrojLaserskihTopova = b.BrojLaserskihTopova;
                o.FotonskaTorpeda = b.FotonskaTorpeda;
                o.Tip = b.Tip;
                o.ZastitnaOplata = b.ZastitnaOplata;
                o.Nosivost = b.Nosivost;
                o.VrstaBroda = b.VrstaBroda;            

                s.Update(o);
                s.Flush();

                s.Close();
                return 0;
            }
            catch (Exception ec)
            {
                MessageBox.Show("Nije uspesno azuriranje broda" + ec);
                return 1;
            }

        }

        #endregion

        #region OSVAJANJE
        public static void dodajOsvajanje(DTOOsvajanje p)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Osvajanje o = new Osvajanje();

                Igrac igr = null;
                Savez sav = null;
                Planeta pla = null;
                IEnumerable<Osvajanje> svaOsvajanja = null;
                Osvajanje poslednjeOsvajanje = null;
                o.PrethodniVlasnikIgrac = "";
                o.PrethodniVlasnikSavez = "";

                if (p.IgracVrsi_ImeIgraca != "")
                    igr = s.Load<Igrac>(Int32.Parse(p.IgracVrsi_ImeIgraca));
                if (p.SavezVrsi_ImeSaveza != "")
                    sav = s.Load<Savez>(Int32.Parse(p.SavezVrsi_ImeSaveza));
                if (p.PlanetaOsvaja_ImePlanete != "")
                    pla = s.Load<Planeta>(Int32.Parse(p.PlanetaOsvaja_ImePlanete));
                if (pla != null)
                {
                    svaOsvajanja = from oo in s.Query<Osvajanje>()
                                   where oo.PlanetaOsvaja == pla
                                   select oo;
                    if (svaOsvajanja != null)
                        poslednjeOsvajanje = svaOsvajanja.LastOrDefault();
                }
                if (poslednjeOsvajanje != null)
                {
                    if (poslednjeOsvajanje.IgracVrsi != null)
                    {
                        o.PrethodniVlasnikIgrac = poslednjeOsvajanje.IgracVrsi.Id.ToString();
                        o.PrethodniVlasnikSavez = "";
                    }
                    if (poslednjeOsvajanje.SavezVrsi != null)
                    {
                        o.PrethodniVlasnikIgrac = "";
                        o.PrethodniVlasnikSavez = poslednjeOsvajanje.SavezVrsi.Id.ToString();
                    }
                }
                o.Datum = p.Datum;
                o.IgracVrsi = igr;
                o.SavezVrsi = sav;
                o.PlanetaOsvaja = pla;

                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Neuspesno dodavanje novog osvajanja" + ec);
            }
        }
        #endregion

        #region KOLONIZACIJA
        public static void dodajKolonizaciju(DTOKolonizacija p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Kolonizacija o = new Kolonizacija();

                Igrac igr = null;
                Savez sav = null;
                Planeta pla = null;

                if (p.IgracVrsi_ImeIgraca != "")
                    igr = s.Load<Igrac>(Int32.Parse(p.IgracVrsi_ImeIgraca));
                if (p.SavezVrsi_ImeSaveza != "")
                    sav = s.Load<Savez>(Int32.Parse(p.SavezVrsi_ImeSaveza));
                if (p.PlanetaKolonizuje_ImePlanete != "")
                    pla = s.Load<Planeta>(Int32.Parse(p.PlanetaKolonizuje_ImePlanete));

                o.Datum = p.Datum;
                o.IgracVrsi = igr;
                o.SavezVrsi = sav;
                o.PlanetaKolonizuje = pla;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Neuspesno dodavanje nove kolonizacije" + ec);
            }
        }
        #endregion

        #region PLANETA
        public static List<DTOPlaneta> vratiSvePlanete()
        {
            List<DTOPlaneta> planete = new List<DTOPlaneta>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Planeta> svePlanete = from o in s.Query<Planeta>()
                                                  select o;

                foreach (Planeta p in svePlanete)
                {
                    string igracIme = "/";
                    string galaksijaIme = "/";
                    if (p.IgracId != null)
                        igracIme = p.IgracId.KorisnickoIme;
                    if (p.GalaksijaId != null)
                        galaksijaIme = p.GalaksijaId.Ime;

                    planete.Add(new DTOPlaneta(p.Id, p.Naziv, p.BrojStanovnika, p.DominantnaRasa, p.DrustvenoUredjenje
                            , p.Trilijum, p.Berilijum, p.Plutonijum
                            , p.x, p.y, p.z, p.Maticna, igracIme, galaksijaIme));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Greska pri vracanju svih planeta: " + ec);
            }

            return planete;
        }
        public static void obrisiPlanetu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Planeta o = s.Load<Planeta>(id);

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Nije uspesno obrisana planeta" + ec);
            }
        }
        public static DTOPlaneta vratiPlanetu(int id)
        {
            DTOPlaneta b = new DTOPlaneta();
            try
            {
                ISession s = DataLayer.GetSession();
                Planeta p = s.Load<Planeta>(id);

                string imeIgraca = "";
                string imeGalaksije = "";

                if (p.IgracId != null)
                    imeIgraca = p.IgracId.KorisnickoIme;
                if (p.GalaksijaId != null)
                    imeGalaksije = p.GalaksijaId.Ime;

                b = new DTOPlaneta(p.Id, p.Naziv, p.BrojStanovnika, p.DominantnaRasa, p.DrustvenoUredjenje, p.Trilijum, p.Berilijum, p.Plutonijum
                            , p.x, p.y, p.z, p.Maticna, imeIgraca, imeGalaksije);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Nije uspesno vracanje planete" + ec);
            }

            return b;
        }
        public static int azurirajPlanetu(DTOPlaneta b)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Planeta o = s.Load<Planeta>(b.Id);

                Igrac i = null;
                Galaksija g = null;

                if (b.GalaksijaId_Ime != "")
                    g = s.Load<Galaksija>(Int32.Parse(b.GalaksijaId_Ime));
                if (b.IgracId_KorisnickoIme != "")
                    i = s.Load<Igrac>(Int32.Parse(b.IgracId_KorisnickoIme));

                o.Naziv = b.Naziv;
                o.BrojStanovnika = b.BrojStanovnika;
                o.DominantnaRasa = b.DominantnaRasa;
                o.DrustvenoUredjenje = b.DrustvenoUredjenje;
                o.Trilijum = b.Trilijum;
                o.Berilijum = b.Berilijum;
                o.Plutonijum = b.Plutonijum;
                o.x = b.x;
                o.y = b.y;
                o.z = b.z;
                o.Maticna = b.Maticna;
                o.IgracId = i;
                o.GalaksijaId = g;

                s.Update(o);
                s.Flush();

                s.Close();
                return 0;
            }
            catch (Exception ec)
            {
                MessageBox.Show("Nije uspesno azuriranje planete" + ec);
                return 1;
            }
        }
        public static void dodajPlanetu(DTOPlaneta p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Planeta o = new Planeta();

                Igrac ig = s.Load<Igrac>(Int32.Parse(p.IgracId_KorisnickoIme));
                Galaksija ga = s.Load<Galaksija>(Int32.Parse(p.GalaksijaId_Ime));

                o.Naziv = p.Naziv;
                o.BrojStanovnika = p.BrojStanovnika;
                o.DominantnaRasa = p.DominantnaRasa;
                o.DrustvenoUredjenje = p.DrustvenoUredjenje;
                o.Trilijum = p.Trilijum;
                o.Berilijum = p.Berilijum;
                o.Plutonijum = p.Plutonijum;
                o.x = p.x;
                o.y = p.y;
                o.z = p.z;
                o.Maticna = p.Maticna;
                o.IgracId = ig;
                o.GalaksijaId = ga;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Neuspesno dodavanje nove planete" + ec);
            }
        }
        public static List<DTOPlaneta> vratiPlaneteizGalaksije(int id)
        {
            List<DTOPlaneta> planete = new List<DTOPlaneta>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Planeta> svePlanete = from o in s.Query<Planeta>()
                                                  where o.GalaksijaId.Id == id
                                                  select o;


                foreach (Planeta p in svePlanete)
                {
                    string igracIme = "/";
                    string galaksijaIme = "/";

                    if (p.IgracId != null)
                        igracIme = p.IgracId.KorisnickoIme;
                    if (p.GalaksijaId != null)
                        galaksijaIme = p.GalaksijaId.Ime;

                    planete.Add(new DTOPlaneta(p.Id, p.Naziv, p.BrojStanovnika, p.DominantnaRasa, p.DrustvenoUredjenje, p.Trilijum, p.Berilijum, p.Plutonijum
                            , p.x, p.y, p.z, p.Maticna, igracIme, galaksijaIme));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Greska pri vracanju svih planeta: " + ec);
            }

            return planete;
        }


        #endregion

        #region GRAD
        public static List<DTOGrad> vratiGradovePlanete(int id)
        {
            List<DTOGrad> gradovi = new List<DTOGrad>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Grad> sviGradovi = from o in s.Query<Grad>()
                                               where o.PlanetaId.Id == id
                                               select o;

                foreach (Grad p in sviGradovi)
                {

                    string planetaIme = "/";

                    if (p.PlanetaId != null)
                        planetaIme = p.PlanetaId.Naziv;

                    gradovi.Add(new DTOGrad(p.Id, p.Naziv, p.Glavni, planetaIme));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Greska pri vracanju svih gradova: " + ec);
            }

            return gradovi;
        }
        public static void obrisiGrad(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Grad o = s.Load<Grad>(id);

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Nije uspesno obrisan grad" + ec);
            }
        }
        public static void dodajGradPlaneti(DTOGrad p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Grad o = new Grad();

                Planeta pl = null;

                if(p.PlanetaId_ImePlanete != "")
                    pl = s.Load<Planeta>(Int32.Parse(p.PlanetaId_ImePlanete));

                o.Naziv = p.Naziv;
                o.Glavni = p.Glavni;
                o.PlanetaId = pl;


                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Neuspesno dodavanje novog grada planeti" + ec);
            }
        }
        #endregion

        #region PRIRODNI_SATELIT
        public static List<DTOPrirodniSatelit> vratiSatelitePlanete(int id)
        {
            List<DTOPrirodniSatelit> sateliti = new List<DTOPrirodniSatelit>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<PrirodniSatelit> sviSateliti = from o in s.Query<PrirodniSatelit>()
                                                           where o.PlanetaId.Id == id
                                                           select o;


                foreach (PrirodniSatelit p in sviSateliti)
                {

                    string planetaIme = "/";
                    if (p.PlanetaId != null)
                        planetaIme = p.PlanetaId.Naziv;

                    sateliti.Add(new DTOPrirodniSatelit(p.Id, p.Naziv, p.Precnik, p.Naseobine, p.Udaljenost, planetaIme));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Greska pri vracanju svih satelita: " + ec);
            }

            return sateliti;
        }
        public static void obrisiPrirodniSatelit(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PrirodniSatelit o = s.Load<PrirodniSatelit>(id);

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Nije uspesno obrisan prirodni satelit" + ec);
            }
        }
        public static void dodajPrirodniSatelit(DTOPrirodniSatelit p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PrirodniSatelit o = new PrirodniSatelit();

                Planeta pl = null;

                if(p.PlanetaId_ImePlanete != null)
                    pl = s.Load<Planeta>(Int32.Parse(p.PlanetaId_ImePlanete));

                o.Naziv = p.Naziv;
                o.Precnik = p.Precnik;
                o.Naseobine = p.Naseobine;
                o.Udaljenost = p.Udaljenost;
                o.PlanetaId = pl;

                o.PlanetaId = pl;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Neuspesno dodavanje novog prirodnog satelita" + ec);
            }
        }
        #endregion

        #region ZVEZDA
        public static List<DTOZvezda> vratiSveZvezde()
        {
            List<DTOZvezda> zvezde = new List<DTOZvezda>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Zvezda> sveZvezde = from o in s.Query<Zvezda>()
                                                select o;


                foreach (Zvezda p in sveZvezde)
                {
                    zvezde.Add(new DTOZvezda(p.Id, p.Ime, p.Tip));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Greska pri vracanju svih zvezda: " + ec);
            }

            return zvezde;
        }
        public static void obrisiZvezdu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zvezda o = s.Load<Zvezda>(id);

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Nije uspesno obrisana zvezda" + ec);
            }
        }
        public static void dodajZvezdu(DTOZvezda p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zvezda o = new Zvezda();

                o.Ime = p.Ime;
                o.Tip = p.Tip;


                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Neuspesno dodavanje nove zvezde" + ec);
            }
        }
        #endregion

        #region SPEC_POJAVA
        public static List<DTOSpecPojava> vratiSveSpecPojave()
        {
            List<DTOSpecPojava> pojave = new List<DTOSpecPojava>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<SpecPojava> svePojave = from o in s.Query<SpecPojava>()
                                                    select o;

                foreach (SpecPojava p in svePojave)
                {
                    pojave.Add(new DTOSpecPojava(p.Id, p.Naziv, p.Tip, p.PotOpasnost));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Greska pri vracanju svih pojava: " + ec);
            }

            return pojave;
        }
        public static void obrisiPojavu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                SpecPojava o = s.Load<SpecPojava>(id);

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Nije uspesno obrisana specijalna pojava" + ec);
            }
        }
        public static void dodajSpecPojavu(DTOSpecPojava p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Deathstar.Entiteti.SpecPojava o = new Deathstar.Entiteti.SpecPojava();

                o.Naziv = p.Naziv;
                o.Tip = p.Tip;
                o.PotOpasnost = p.PotOpasnost;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Neuspesno dodavanje nove specijalne pojave" + ec);
            }
        }
        #endregion

        #region PLANETA_POJAVA_BLIZINA
        public static List<DTOPlanetaPojavaBlizina> vratiPlanetePojaveBlizine(int id)
        {
            List<DTOPlanetaPojavaBlizina> planetePojaveBlizine = new List<DTOPlanetaPojavaBlizina>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<PlanetaPojavaBlizina> svePlanetePojaveBlizine = from o in s.Query<PlanetaPojavaBlizina>()
                                                                            where o.SpecPojavaId.Id == id
                                                                            select o;


                foreach (PlanetaPojavaBlizina p in svePlanetePojaveBlizine)
                {
                    string pojavaIme = "/";
                    string planetaIme = "/";
                    if (p.PlanetaId != null)
                        planetaIme = p.PlanetaId.Naziv;
                    if (p.SpecPojavaId != null)
                        pojavaIme = p.SpecPojavaId.Naziv;

                    planetePojaveBlizine.Add(new DTOPlanetaPojavaBlizina(p.Id, p.Udaljenost, planetaIme, pojavaIme));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Greska pri vracanju planeta_pojava_blizina: " + ec);
            }

            return planetePojaveBlizine;
        }
        public static void obrisiPlanetaPojavaBlizina(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PlanetaPojavaBlizina o = s.Load<PlanetaPojavaBlizina>(id);

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Nije uspesno obrisana pojava blizu planete" + ec);
            }
        }
        public static void dodajPojavaPlanetaBlizina(DTOPlanetaPojavaBlizina p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PlanetaPojavaBlizina o = new PlanetaPojavaBlizina();

                Planeta pl1 = s.Load<Planeta>(Int32.Parse(p.PlanetaId_ImePlanete));
                SpecPojava sp1 = s.Load<SpecPojava>(Int32.Parse(p.SpecPojavaId_ImePojave));

                o.PlanetaId = pl1;
                o.SpecPojavaId = sp1;
                o.Udaljenost = p.Udaljenost;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Neuspesno dodavanje nove udaljenosti izmedju planete i pojave" + ec);
            }
        }

        #endregion

        #region ZVEZDA_PLANETA_BLIZINA
        public static List<DTOZvezdaPlanetaBlizina> vratiSveZPB()
        {
            List<DTOZvezdaPlanetaBlizina> ZPBovi = new List<DTOZvezdaPlanetaBlizina>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<ZvezdaPlanetaBlizina> sviZPB = from o in s.Query<ZvezdaPlanetaBlizina>()
                                                           select o;


                foreach (ZvezdaPlanetaBlizina p in sviZPB)
                {
                    string zvezdaIme = "/";
                    string planetaIme = "/";

                    if (p.PlanetaId != null)
                        planetaIme = p.PlanetaId.Naziv;
                    if (p.ZvezdaId != null)
                        zvezdaIme = p.ZvezdaId.Ime;

                    ZPBovi.Add(new DTOZvezdaPlanetaBlizina(p.Id, planetaIme, zvezdaIme));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Greska pri vracanju svih ZBP: " + ec);
            }

            return ZPBovi;
        }
        public static void obrisiZvezdaPlanetaBlizina(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ZvezdaPlanetaBlizina o = s.Load<ZvezdaPlanetaBlizina>(id);

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Nije uspesno obrisana blizina" + ec);
            }
        }
        public static void dodajZvezdaPlanetaBlizina(DTOZvezdaPlanetaBlizina p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ZvezdaPlanetaBlizina o = new ZvezdaPlanetaBlizina();

                Planeta pl = s.Load<Planeta>(Int32.Parse(p.PlanetaId_ImePlanete));
                Zvezda zv = s.Load<Zvezda>(Int32.Parse(p.ZvezdaId_ImeZvezde));

                o.PlanetaId = pl;
                o.ZvezdaId = zv;


                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Neuspesno dodavanje nove blizine izmedju planete i zvezde" + ec);
            }
        }

        #endregion

        #region GALAKSIJA
        public static List<DTOGalaksija> vratiSveGalaksije()
        {
            List<DTOGalaksija> galaksije = new List<DTOGalaksija>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Galaksija> sveGalaksije = from o in s.Query<Galaksija>()
                                                      select o;


                foreach (Galaksija p in sveGalaksije)
                {
                    galaksije.Add(new DTOGalaksija(p.Id, p.Ime, p.DominantnaRasa, p.ProcenjeniBrojZvezda, p.ProcenjeniBrojPlaneta));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Greska pri vracanju svih galaksija: " + ec);
            }

            return galaksije;
        }
        public static void obrisiGalaksiju(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Galaksija o = s.Load<Galaksija>(id);

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Nije uspesno obrisana galaksija" + ec);
            }
        }
        public static void dodajGalaksiju(DTOGalaksija p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Galaksija o = new Galaksija();


                o.Ime = p.Ime;
                o.DominantnaRasa = p.DominantnaRasa;
                o.ProcenjeniBrojPlaneta = p.ProcenjeniBrojPlaneta;
                o.ProcenjeniBrojZvezda = p.ProcenjeniBrojZvezda;


                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Neuspesno dodavanje nove galaksije" + ec);
            }
        }
        public static DTOGalaksija vratiGalaksiju(int id)
        {
            DTOGalaksija b = new DTOGalaksija();
            try
            {
                ISession s = DataLayer.GetSession();
                Galaksija p = s.Load<Galaksija>(id);

                b = new DTOGalaksija(p.Id, p.Ime, p.DominantnaRasa, p.ProcenjeniBrojPlaneta, p.ProcenjeniBrojZvezda);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Nije uspesno vracanje galaksije" + ec);
            }

            return b;
        }
        public static int azurirajGalaksiju(DTOGalaksija b)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Galaksija o = s.Load<Galaksija>(b.Id);

                o.Id = b.Id;
                o.Ime = b.Ime;
                o.DominantnaRasa = b.DominantnaRasa;
                o.ProcenjeniBrojPlaneta = b.ProcenjeniBrojPlaneta;
                o.ProcenjeniBrojZvezda = b.ProcenjeniBrojZvezda;

                s.Update(o);
                s.Flush();

                s.Close();
                return 0;
            }
            catch (Exception ec)
            {
                MessageBox.Show("Nije uspesno azuriranje galaksije" + ec);
                return 1;
            }
        }
        #endregion

        #region KVADRANT
        public static List<DTOKvadrant> vratiKvadranteIzGalaksije(int id)
        {
            List<DTOKvadrant> kvadranti = new List<DTOKvadrant>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Kvadrant> sviKvadranti = from o in s.Query<Kvadrant>()
                                                     where o.GalaksijaId.Id == id
                                                     select o;


                foreach (Kvadrant p in sviKvadranti)
                {
                    string galaksijeIme = "/";

                    if (p.GalaksijaId != null)
                        galaksijeIme = p.GalaksijaId.Ime;

                    kvadranti.Add(new DTOKvadrant(p.Id, p.ProcenjeniPrecnik, p.RedniBroj, galaksijeIme));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Greska pri vracanju svih kvadranta: " + ec);
            }

            return kvadranti;
        }
        public static void dodajKvadrant(DTOKvadrant p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Kvadrant o = new Kvadrant();
                Galaksija g = null;

                if (p.GalaksijaId_ImeGalaksije != "")
                    g = s.Load<Galaksija>(Int32.Parse(p.GalaksijaId_ImeGalaksije));

                o.ProcenjeniPrecnik = p.ProcenjeniPrecnik;
                o.RedniBroj = p.RedniBroj;
                o.GalaksijaId = g;



                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Neuspesno dodavanje novog kvadranta u galaksiji" + ec);
            }
        }
        #endregion

        #region CIVILNA_STANICA
        public static List<DTOCivilnaStanica> vratiCivilneStanicePlanete(int id)
        {
            List<DTOCivilnaStanica> civilneStanice = new List<DTOCivilnaStanica>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<CivilnaStanica> sveCivilneStanice = from o in s.Query<CivilnaStanica>()
                                                                where o.PlanetaId.Id == id
                                                                select o;


                foreach (CivilnaStanica p in sveCivilneStanice)
                {
                    string planetaIme = "/";

                    if (p.PlanetaId != null)
                        planetaIme = p.PlanetaId.Naziv;

                    civilneStanice.Add(new DTOCivilnaStanica(p.Id, p.Naziv, p.BrojLjudi, p.Velicina, p.Udaljenost, p.ZaTrgovinu, p.ZaNaucnaIstrazivanja, planetaIme));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Greska pri vracanju svih civilnih stanica: " + ec);
            }

            return civilneStanice;
        }
        public static void obrisiCivilnuStanicu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                CivilnaStanica o = s.Load<CivilnaStanica>(id);

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Nije uspesno obrisana civilna stanica" + ec);
            }
        }
        public static void dodajCivilnuStanicu(DTOCivilnaStanica p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                CivilnaStanica o = new CivilnaStanica();
                Planeta pl = null;

                if (p.PlanetaId_ImePlanete != "")
                    pl = s.Load<Planeta>(Int32.Parse(p.PlanetaId_ImePlanete));

                o.Naziv = p.Naziv;
                o.BrojLjudi = p.BrojLjudi;
                o.Velicina = p.Velicina;
                o.Udaljenost = p.Udaljenost;
                o.ZaTrgovinu = p.ZaTrgovinu;
                o.ZaNaucnaIstrazivanja = p.ZaNaucnaIstrazivanja;

                o.PlanetaId = pl;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Neuspesno dodavanje nove civilne stanice " + ec);
            }
        }

        #endregion

        #region VOJNA_STANICA
        public static List<DTOVojnaStanica> vratiVojneStanicePlanete(int id)
        {
            List<DTOVojnaStanica> vojneStanice = new List<DTOVojnaStanica>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<VojnaStanica> sveVojneStanice = from o in s.Query<VojnaStanica>()
                                                            where o.PlanetaId.Id == id
                                                            select o;


                foreach (VojnaStanica p in sveVojneStanice)
                {
                    string planetaIme = "/";

                    if (p.PlanetaId != null)
                        planetaIme = p.PlanetaId.Naziv;

                    vojneStanice.Add(new DTOVojnaStanica(p.Id, p.Naziv, p.BrojLjudi, p.Velicina, p.Udaljenost, p.SpisakOruzja, planetaIme));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Greska pri vracanju svih vojnih stanica: " + ec);
            }

            return vojneStanice;
        }
        public static void obrisiVojnuStanicu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                VojnaStanica o = s.Load<VojnaStanica>(id);

                s.Delete(o);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Nije uspesno obrisana vojna stanica" + ec);
            }
        }
        public static void dodajVojnuStanicu(DTOVojnaStanica p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                VojnaStanica v = new VojnaStanica();
                Planeta pl = null;

                if (p.PlanetaId_ImePlanete != "")
                    pl = s.Load<Planeta>(Int32.Parse(p.PlanetaId_ImePlanete));


                v.Naziv = p.Naziv;
                v.BrojLjudi = p.BrojLjudi;
                v.Velicina = p.Velicina;
                v.Udaljenost = p.Udaljenost;
                v.SpisakOruzja = p.SpisakOruzja;
                v.PlanetaId = pl;

                s.SaveOrUpdate(v);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Neuspesno dodavanje nove vojne stanice" + ec);
            }
        }
        #endregion



    }
}
