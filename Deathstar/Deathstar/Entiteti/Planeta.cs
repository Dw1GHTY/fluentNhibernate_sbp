using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deathstar.Entiteti
{
    public class Planeta
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
        
        public virtual Igrac IgracId { get; set; } 
        public virtual Galaksija GalaksijaId { get; set;}
        public virtual IList<Brod> Brodovi { get; set; }
        public virtual IList<Grad> Gradovi { get; set; }
        public virtual IList<PrirodniSatelit> PrirodniSateliti { get; set; }
        public virtual IList<CivilnaStanica> CivilneStanice { get; set; }
        public virtual IList<VojnaStanica> VojneStanice { get; set; }
        
        public virtual IList<Kolonizacija> Kolonizacije { get; set; }
        public virtual IList<Osvajanje> Osvajanja { get; set; }
        public virtual IList<Zvezda> Zvezde { get; set; }
        public virtual IList<SpecPojava> SpecPojave { get; set; }
        public Planeta()
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

    }
}
