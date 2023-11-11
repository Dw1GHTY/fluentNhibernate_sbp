using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deathstar.Entiteti
{
    public class Brod
    {
        public virtual int JedinstveniBroj { get; set; }
        public virtual string Naziv { get; set; }
        public virtual int MaxWarp { get; set; }
        public virtual int BrojLaserskihTopova { get; set; }
        public virtual string FotonskaTorpeda { get; set; }
        public virtual string Tip { get; set; }
        public virtual string ZastitnaOplata { get; set; }
        public virtual int Nosivost { get; set; }
        public virtual string VrstaBroda { get; set; }
        public virtual Igrac PripadaIgracu { get; set; }
        public virtual Savez PripadaSavezu { get; set; }
        public virtual Planeta IzgradjenNaPlaneti { get; set; }

        
    }

    
}
