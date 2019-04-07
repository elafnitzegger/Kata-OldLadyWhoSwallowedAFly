using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Song
    {
        public static Func<int, string> Verse = (i) =>
        {
            switch (i)
            {
                case 1:
                    return
                        "There was an old lady who swallowed a fly.\r\n" +
                        "I don't know why she swallowed a fly. Perhaps she'll die!\r\n";
                case 2:
                    return
                        "There was an old lady who swallowed a spider.\r\n" +
                        "It wriggled and jiggled and tickled inside her.\r\n" +
                        "She swallowed the spider to catch the fly.\r\n" +
                        "I don't know why she swallowed a fly. Perhaps she'll die!\r\n";
                case 3:
                    return
                        "There was an old lady who swallowed a bird.\r\n" +
                        "How absurd to swallow a bird!\r\n" +
                        "She swallowed the bird to catch the spider that wriggled and jiggled and tickled inside her.\r\n" +
                        "She swallowed the spider to catch the fly.\r\n" +
                        "I don't know why she swallowed a fly. Perhaps she'll die!\r\n";
                case 4:
                    return 
                        "There was an old lady who swallowed a cat.\r\n" +
                        "Imagine that! She swallowed a cat!\r\n" +
                        "She swallowed the cat to catch the bird.\r\n" +
                        "She swallowed the bird to catch the spider that wriggled and jiggled and tickled inside her.\r\n" +
                        "She swallowed the spider to catch the fly.\r\n" +
                        "I don't know why she swallowed a fly. Perhaps she'll die!\r\n";
                case 5:
                    return
                        "There was an old lady who swallowed a dog.\r\n" +
                        "What a hog, to swallow a dog!\r\n" +
                        "She swallowed the dog to catch the cat.\r\n" +
                        "She swallowed the cat to catch the bird.\r\n" +
                        "She swallowed the bird to catch the spider that wriggled and jiggled and tickled inside her.\r\n" +
                        "She swallowed the spider to catch the fly.\r\n" +
                        "I don't know why she swallowed a fly. Perhaps she'll die!\r\n";
                case 6:
                    return
                        "There was an old lady who swallowed a goat.\r\n" +
                        "She just opened her throat and swallowed a goat!\r\n" +
                        "She swallowed the goat to catch the dog.\r\n" +
                        "She swallowed the dog to catch the cat.\r\n" +
                        "She swallowed the cat to catch the bird.\r\n" +
                        "She swallowed the bird to catch the spider that wriggled and jiggled and tickled inside her.\r\n" +
                        "She swallowed the spider to catch the fly.\r\n" +
                        "I don't know why she swallowed a fly. Perhaps she'll die!\r\n";
                case 7:
                    return
                        "There was an old lady who swallowed a cow.\r\n" +
                        "I don't know how she swallowed a cow!\r\n" +
                        "She swallowed the cow to catch the goat.\r\n" +
                        "She swallowed the goat to catch the dog.\r\n" +
                        "She swallowed the dog to catch the cat.\r\n" +
                        "She swallowed the cat to catch the bird.\r\n" +
                        "She swallowed the bird to catch the spider that wriggled and jiggled and tickled inside her.\r\n" +
                        "She swallowed the spider to catch the fly.\r\n" +
                        "I don't know why she swallowed a fly. Perhaps she'll die!\r\n";
                case 8:
                    return
                        "There was an old lady who swallowed a horse.\r\n" +
                        "She died, of course!\r\n";
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
