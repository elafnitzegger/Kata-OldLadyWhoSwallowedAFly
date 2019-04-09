using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Song
    {
        public static List<Critter> critters = new List<Critter>
        {
            new Critter {Name = "horse", Aside = "She died, of course!"},
            new Critter {Name = "cow", Aside = "I don't know how she swallowed a cow!"},
            new Critter {Name = "goat", Aside = "She just opened her throat and swallowed a goat!"},
            new Critter {Name = "dog", Aside = "What a hog, to swallow a dog!"},
            new Critter {Name = "cat", Aside = "Imagine that! She swallowed a cat!"},
            new Critter {Name = "bird", Aside = "How absurd to swallow a bird!"},
            new Critter {Name = "spider", Epithet = "that wriggled and jiggled and tickled inside her", Aside = "It wriggled and jiggled and tickled inside her."},
            new Critter {Name = "fly", Aside = "I don't know why she swallowed a fly. Perhaps she'll die!"}
        };


        public static Func<string> Lyrics = () =>
        {
            return Enumerable.Range(1, 8).ToList().Map(i => new Verse(critters.Last(i)).ToString()).Join("\r\n");
        };
    }
}
