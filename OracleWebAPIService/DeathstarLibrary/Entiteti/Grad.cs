using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deathstar.Entiteti
{
    public class Grad
    {
        public virtual int Id { get; set; }
        public virtual string Naziv { get; set; }
        public virtual string Glavni { get; set; }
        public virtual Planeta PlanetaId { get; set; }
    }

}
