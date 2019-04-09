using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain
{
    public class Song
    {
        private static List<Critter> critters;
  
        private static List<List<string>> Data = new List<List<string>>
        {
            new List<string>{"horse",null, "She died, of course!" },
            new List<string>{ "cow", null, "I don't know how she swallowed a cow!" },
            new List<string>{ "goat", null, "She just opened her throat and swallowed a goat!" },
            new List<string>{ "dog", null, "What a hog, to swallow a dog!" },
            new List<string>{ "cat", null, "Imagine that! She swallowed a cat!" },
            new List<string>{ "bird", null, "How absurd to swallow a bird!" },
            new List<string>{ "spider", "that wriggled and jiggled and tickled inside her", "It wriggled and jiggled and tickled inside her." },
            new List<string>{ "fly", null, "I don't know why she swallowed a fly. Perhaps she'll die!" },
        };

        public static void Initialize()
        {
            Initialize(Data);
        }
 
        public static void Initialize(List<List<string>> data) {
            critters = Enumerable.Range(0, data.Count).ToList().Map(i => new Critter { Name = data[i][0], Epithet = data[i][1], Aside = data[i][2] });
        }

        public static Func<string> Lyrics = () =>
        {
            return Enumerable.Range(1, critters.Count).ToList().Map(i => new Verse(critters.Last(i)).ToString()).Join("\r\n");
        };
    }
}
