using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deathstar.Entiteti
{
    public class PlanetaPojavaBlizina
    {
        public virtual int Id { get; set; }
        public virtual int Udaljenost { get; set; }
        public virtual Planeta PlanetaId { get; set; }
        public virtual SpecPojava SpecPojavaId { get; set; }
    }
}
