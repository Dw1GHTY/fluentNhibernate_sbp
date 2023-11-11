using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deathstar.Entiteti
{
    public class Savez
    {
        public virtual int Id { get; protected set ; }

        public virtual string Naziv { get; set; }

        public virtual DateTime DatumFormiranja {get; set;}
        public virtual Savez SavezId { get; set; }

        public virtual IList<Igrac> Igraci { get; set; }
        public virtual IList<Brod> Brodovi { get; set; }
        public virtual IList<Kolonizacija> Kolonizacije { get; set; }
        public virtual IList<Osvajanje> Osvajanja { get; set; }
        public Savez() 
        {
            Igraci = new List<Igrac>();
            Brodovi = new List<Brod>();
            Kolonizacije = new List<Kolonizacija>();
            Osvajanja = new List<Osvajanje>();
        }
    }

   
}
