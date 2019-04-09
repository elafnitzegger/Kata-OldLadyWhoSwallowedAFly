using System.Collections.Generic;
using System.Text.RegularExpressions;

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

        public string Article
        {
            get {
                if (Regex.Match(Name[0].ToString(), "[aeiouAEIOU]").Success) { return "an"; }
                else { return "a"; }
            }
        }
    }
}
