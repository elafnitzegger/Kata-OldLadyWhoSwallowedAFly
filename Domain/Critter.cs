﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain
{
    public class Critter
    {
        public string Name { get; set; }
  
        public string Epithet { get; set; }

        public string EmbellishedName
        {
            get { return new List<string> { Name, Epithet }.Compact().Join(" "); }
        }
    }
}