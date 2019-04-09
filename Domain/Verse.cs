using System.Collections.Generic;

namespace Domain
{
    public static class Verse
    {
        public static IVerse For(List<Critter> critters, int i)
        {
            if (i == 1 || i == critters.Count)
            {
                return new ShortVerse(critters.Last(i));
            }
            else
            {
                return new LongVerse(critters.Last(i));
            }
        }
    }
}
