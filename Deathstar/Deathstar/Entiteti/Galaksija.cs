using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deathstar.Entiteti
{
    public class Galaksija
    {
        public virtual int Id { get; set; }
        public virtual string Ime { get; set; }
        public virtual string DominantnaRasa { get; set; }
        public virtual int ProcenjeniBrojPlaneta { get; set; }
        public virtual int ProcenjeniBrojZvezda { get; set; }
        public virtual IList<Planeta> Planete { get; set; }
        public virtual IList<Kvadrant> Kvadranti { get; set; }
        public Galaksija()
        {
            Planete = new List<Planeta>();
            Kvadranti = new List<Kvadrant>();
        }
    }
}
