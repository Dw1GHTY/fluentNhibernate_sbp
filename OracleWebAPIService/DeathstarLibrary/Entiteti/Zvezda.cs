﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deathstar.Entiteti
{
    public class Zvezda
    {
        public virtual int Id { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Tip { get; set; }
        public virtual IList<Planeta> Planete { get; set; }
        public Zvezda()
        {
            Planete = new List<Planeta>();
        }
    }
}
