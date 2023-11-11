using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deathstar.Entiteti
{
    public class Kvadrant
    {
        public virtual int Id { get; set; }
        public virtual int ProcenjeniPrecnik { get; set; }
        public virtual int RedniBroj { get; set; } 
        public virtual Galaksija GalaksijaId { get; set; }


    }
}
