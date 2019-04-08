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
            new Critter {Name = "horse", Aside = ""},
            new Critter {Name = "cow", Aside = "I don't know how she swallowed a cow!"},
            new Critter {Name = "goat", Aside = "She just opened her throat and swallowed a goat!"},
            new Critter {Name = "dog", Aside = "What a hog, to swallow a dog!"},
            new Critter {Name = "cat", Aside = "Imagine that! She swallowed a cat!"},
            new Critter {Name = "bird", Aside = "How absurd to swallow a bird!"},
            new Critter {Name = "spider", Epithet = "that wriggled and jiggled and tickled inside her", Aside = "It wriggled and jiggled and tickled inside her."},
            new Critter {Name = "fly", Aside = ""}
        };

        public static Func<List<Critter>, string> Motivation = (pair) =>
        {
            Critter preditor = pair[0];
            Critter prey = pair[1];

            return string.Format("She swallowed the {0} to catch the {1}.", preditor.Name, prey.EmbellishedName);
        };

        public static Func<int, string> Chain = (i) =>
        {
            return critters.Last(i).EachCons(2).Map(Motivation).Join("\r\n");
        };

        public static Func<int, string> Verse = (i) =>
        {
            switch (i)
            {
                case 1:
                    return
                        string.Format("There was an old lady who swallowed a {0}.\r\n", critters.Last(i).First().Name) +
                        string.Format("{0}\r\n", "I don't know why she swallowed a fly. Perhaps she'll die!");
                case 8:
                    return
                        string.Format("There was an old lady who swallowed a {0}.\r\n", critters.Last(i).First().Name) +
                        string.Format("{0}\r\n", "She died, of course!");
                default:
                    return
                        string.Format("There was an old lady who swallowed a {0}.\r\n", critters.Last(i).First().Name) +
                        string.Format("{0}\r\n", critters.Last(i).First().Aside) +
                        string.Format("{0}\r\n", Chain(i)) +
                        string.Format("{0}\r\n", "I don't know why she swallowed a fly. Perhaps she'll die!");
            };
        };

        public static Func<string> Lyrics = () =>
        {
            return Enumerable.Range(1, 8).ToList().Map(Verse).Join("\r\n");
        };
    }
}
