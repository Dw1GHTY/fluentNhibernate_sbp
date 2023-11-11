using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deathstar.Entiteti
{
    public class PrirodniSatelit
    {
        public virtual int Id { get; set; }
        public virtual string Naziv { get; set; }
        public virtual int Precnik { get; set; }
        public virtual string Naseobine { get; set; }
        public virtual int Udaljenost { get; set; }
        public virtual Planeta PlanetaId { get; set; }
}
}
