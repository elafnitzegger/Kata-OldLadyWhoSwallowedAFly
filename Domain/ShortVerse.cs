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
            return string.Format("There was an old lady who swallowed a {0}.\r\n{1}\r\n", Critter.Name, Critter.Aside);

        }

        public virtual string Recap()
        {
            return "";
        }
    }
}
