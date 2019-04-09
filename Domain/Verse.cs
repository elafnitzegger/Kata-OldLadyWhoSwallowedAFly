using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Verse
    {
        public List<Critter> Critters { get; set; }

        public Verse(List<Critter> inCritters)
        {
            Critters = inCritters;
        }

        public string ToString()
        {
            int i = Critters.Count;

            switch (i)
            {
                case 1:
                case 8:
                    return
                        string.Format("There was an old lady who swallowed a {0}.\r\n", Critters.First().Name) +
                        string.Format("{0}\r\n", Critters.First().Aside);
                default:
                    return
                        string.Format("There was an old lady who swallowed a {0}.\r\n", Critters.First().Name) +
                        string.Format("{0}\r\n", Critters.First().Aside) +
                        string.Format("{0}\r\n", Chain(i)) +
                        string.Format("{0}\r\n", "I don't know why she swallowed a fly. Perhaps she'll die!");
            };
        }

        private string Chain(int i)
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
