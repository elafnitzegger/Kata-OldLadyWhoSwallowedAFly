using System.Collections.Generic;
using System.Linq;

namespace Domain
{
    public class ShortVerse : IVerse
    {
        private Critter Critter { get; set; }

        public ShortVerse(List<Critter> inCritters)
        {
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
            return string.Format("There was an old lady who swallowed {0} {1}.\r\n{2}\r\n",Critter.Article, Critter.Name, Critter.Aside);

        }

        public virtual string Recap()
        {
            return "";
        }
    }
}
