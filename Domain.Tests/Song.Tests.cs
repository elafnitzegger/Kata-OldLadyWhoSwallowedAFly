using System;
using System.Collections.Generic;
using Xunit;

namespace Domain.Tests
{
    public class SongTests
    {
        [Fact]
        public void ShouldReturnSong()
        {
            string @expected = @"There was an old lady who swallowed a fly.
I don't know why she swallowed a fly. Perhaps she'll die!

There was an old lady who swallowed a spider.
It wriggled and jiggled and tickled inside her.
She swallowed the spider to catch the fly.
I don't know why she swallowed a fly. Perhaps she'll die!

There was an old lady who swallowed a bird.
How absurd to swallow a bird!
She swallowed the bird to catch the spider that wriggled and jiggled and tickled inside her.
She swallowed the spider to catch the fly.
I don't know why she swallowed a fly. Perhaps she'll die!

There was an old lady who swallowed a cat.
Imagine that! She swallowed a cat!
She swallowed the cat to catch the bird.
She swallowed the bird to catch the spider that wriggled and jiggled and tickled inside her.
She swallowed the spider to catch the fly.
I don't know why she swallowed a fly. Perhaps she'll die!

There was an old lady who swallowed a dog.
What a hog, to swallow a dog!
She swallowed the dog to catch the cat.
She swallowed the cat to catch the bird.
She swallowed the bird to catch the spider that wriggled and jiggled and tickled inside her.
She swallowed the spider to catch the fly.
I don't know why she swallowed a fly. Perhaps she'll die!

There was an old lady who swallowed a goat.
She just opened her throat and swallowed a goat!
She swallowed the goat to catch the dog.
She swallowed the dog to catch the cat.
She swallowed the cat to catch the bird.
She swallowed the bird to catch the spider that wriggled and jiggled and tickled inside her.
She swallowed the spider to catch the fly.
I don't know why she swallowed a fly. Perhaps she'll die!

There was an old lady who swallowed a cow.
I don't know how she swallowed a cow!
She swallowed the cow to catch the goat.
She swallowed the goat to catch the dog.
She swallowed the dog to catch the cat.
She swallowed the cat to catch the bird.
She swallowed the bird to catch the spider that wriggled and jiggled and tickled inside her.
She swallowed the spider to catch the fly.
I don't know why she swallowed a fly. Perhaps she'll die!

There was an old lady who swallowed a horse.
She died, of course!
";

            Assert.Equal(expected, Song.Lyrics());
        }

        [Fact]
        public void ShouldProvideMotivationString()
        {
            var expected = "She swallowed the A to catch the B.";

            List<Critter> pair = new List<Critter>{
                new Critter {Name = "A", Epithet = "" },
                new Critter {Name = "B", Epithet = "" }
            };

            Assert.Equal(expected, Song.Motivation(pair));
        }

        [Fact]
        public void ShouldReturnListOfPreditorsAndPrey()
        {
            List<Critter> critters = new List<Critter>{
                new Critter {Name = "A", Epithet = "" },
                new Critter {Name = "B", Epithet = "" },
                new Critter {Name = "C", Epithet = "" }
            };

            string expected = "She swallowed the A to catch the B.\r\n" +
                "She swallowed the B to catch the C.";

            Assert.Equal(expected, Song.Chain(critters));
        }
    }

}
