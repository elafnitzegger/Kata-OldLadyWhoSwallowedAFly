using System.Collections.Generic;
using System.Linq;

namespace Domain
{
    public class Verse
    {
        public List<Critter> Critters { get; set; }
        private Critter Critter { get; set; }

        public Verse(List<Critter> inCritters)
        {
            Critters = inCritters;
            Critter = inCritters.First();
        }

        public new string ToString()
        {
            return
                Incident() +
                Recap();
        }

        private string Incident()
        {
            return string.Format("There was an old lady who swallowed a {0}.\r\n{1}\r\n", Critter.Name, Critter.Aside);

        }
 
        private string Recap()
        {
            switch (Critters.Count)
            {
                case 1:
                case 8:
                    return "";
                default:
                    return
                        string.Format("{0}\r\n", Chain()) +
                        string.Format("{0}\r\n", Critters.Last().Aside);
            };
        }

        private string Chain()
        {
            return Critters.EachCons(2).Map(Motivation).Join("\r\n");
        }

        private string Motivation(List<Critter> pair)
        {
            Critter preditor = pair[0];
            Critter prey = pair[1];

            return string.Format("She swallowed the {0} to catch the {1}.", preditor.Name, prey.EmbellishedName);
        }
    }
}
