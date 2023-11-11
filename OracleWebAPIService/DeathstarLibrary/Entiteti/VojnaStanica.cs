using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deathstar.Entiteti
{
    public class VojnaStanica
    {
        public virtual int Id { get; set; }
        public virtual string Naziv { get; set; }
        public virtual int BrojLjudi { get; set; }
        public virtual int Velicina { get; set; }
        public virtual int Udaljenost { get; set; }
        public virtual string SpisakOruzja { get; set; }

        public virtual Planeta PlanetaId { get; set; }
}
}
