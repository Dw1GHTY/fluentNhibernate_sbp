using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deathstar.Entiteti
{
    public class Kolonizacija
    {
        public virtual int Id { get; set; }
        public virtual DateTime Datum { get; set; }
        public virtual Igrac IgracVrsi { get; set; }
        public virtual Savez SavezVrsi { get; set; }
        public virtual Planeta PlanetaKolonizuje { get; set; }
    }
}
