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
            new Critter {Name = "horse", Epithet = ""},
            new Critter {Name = "cow", Epithet = ""},
            new Critter {Name = "goat", Epithet = ""},
            new Critter {Name = "dog", Epithet = ""},
            new Critter {Name = "cat", Epithet = ""},
            new Critter {Name = "bird", Epithet = ""},
            new Critter {Name = "spider", Epithet = "that wriggled and jiggled and tickled inside her"},
            new Critter {Name = "fly", Epithet = ""}
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
                        string.Format("There was an old lady who swallowed a {0}.\r\n", "fly") +
                        string.Format("{0}\r\n", "I don't know why she swallowed a fly. Perhaps she'll die!");
                case 2:
                    return
                        string.Format("There was an old lady who swallowed a {0}.\r\n", "spider") +
                        string.Format("{0}\r\n", "It wriggled and jiggled and tickled inside her.") +
                        string.Format("{0}\r\n", Chain(2)) +
                        string.Format("{0}\r\n", "I don't know why she swallowed a fly. Perhaps she'll die!");
                case 3:
                    return
                        string.Format("There was an old lady who swallowed a {0}.\r\n", "bird") +
                        string.Format("{0}\r\n", "How absurd to swallow a bird!") +
                        string.Format("{0}\r\n", Chain(3)) +
                        string.Format("{0}\r\n", "I don't know why she swallowed a fly. Perhaps she'll die!");
                case 4:
                    return 
                        string.Format("There was an old lady who swallowed a {0}.\r\n", "cat") +
                        string.Format("{0}\r\n", "Imagine that! She swallowed a cat!") +
                        string.Format("{0}\r\n", Chain(4)) +
                        string.Format("{0}\r\n", "I don't know why she swallowed a fly. Perhaps she'll die!");
                case 5:
                    return
                        string.Format("There was an old lady who swallowed a {0}.\r\n", "dog") +
                        string.Format("{0}\r\n", "What a hog, to swallow a dog!") +
                        string.Format("{0}\r\n", Chain(5)) +
                        string.Format("{0}\r\n", "I don't know why she swallowed a fly. Perhaps she'll die!");
                case 6:
                    return
                        string.Format("There was an old lady who swallowed a {0}.\r\n", "goat") +
                        string.Format("{0}\r\n", "She just opened her throat and swallowed a goat!") +
                        string.Format("{0}\r\n", Chain(6)) +
                        string.Format("{0}\r\n", "I don't know why she swallowed a fly. Perhaps she'll die!");
                case 7:
                    return
                        string.Format("There was an old lady who swallowed a {0}.\r\n", "cow") +
                        string.Format("{0}\r\n", "I don't know how she swallowed a cow!") +
                        string.Format("{0}\r\n", Chain(7)) +
                        string.Format("{0}\r\n", "I don't know why she swallowed a fly. Perhaps she'll die!");
                case 8:
                    return
                        string.Format("There was an old lady who swallowed a {0}.\r\n", "horse") +
                        string.Format("{0}\r\n", "She died, of course!");
                default:
                    return "";
            };
        };

        public static Func<string> Lyrics = () =>
        {
            return Enumerable.Range(1, 8).ToList().Map(Verse).Join("\r\n");
        };
    }
}
