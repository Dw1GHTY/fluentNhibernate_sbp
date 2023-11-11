using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deathstar.Entiteti
{
    public class Igrac
    {
        public virtual int Id { get; protected set; }
        public virtual string KorisnickoIme { get; set; }
        public virtual DateTime DatumOtvaranjaNaloga { get; set; }
        public virtual string LicnoIme { get; set; }
        public virtual string SrednjeSlovo { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string Email { get; set; }
        public virtual string Pol { get; set; }
        public virtual DateTime DatumRodjenja { get; set; }
        public virtual string Drzava{ get; set; }
        public virtual string TekstualniOpis { get; set; }
        public virtual string Slika { get; set; }

        public virtual Savez SavezId { get; set; }
        public virtual IList<Brod> Brodovi { get; set; }
        public virtual IList<Planeta> Planete { get; set; } 
        public virtual IList<Kolonizacija> Kolonizacije { get; set; }
        public virtual IList<Osvajanje> Osvajanja { get; set; }

        public Igrac()
        {
            Brodovi = new List<Brod>();
            Planete = new List<Planeta>();
            Kolonizacije = new List<Kolonizacija>();
            Osvajanja = new List<Osvajanje>();
        }

        

    }
}
