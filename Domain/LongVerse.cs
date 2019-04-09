using System.Collections.Generic;
using System.Linq;

namespace Domain
{
    public class LongVerse : ShortVerse, IVerse
    {
        public List<Critter> Critters { get; set; }

        public LongVerse(List<Critter> inCritters) : base(inCritters)
        {
            Critters = inCritters;
        }

        public override string Recap()
        {
            return
                string.Format("{0}\r\n", Chain()) +
                string.Format("{0}\r\n", Critters.Last().Aside);
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
