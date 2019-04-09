using System.Collections.Generic;


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

        public string Aside { get; set; }
    }
}
