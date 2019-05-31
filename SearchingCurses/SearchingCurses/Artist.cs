using System;
using System.Collections.Generic;

namespace SearchingCurses {
    class Artist {
        public string name;
        public List<string> songTitles;

        public Artist(string name) {
            this.name = name;
        }

        public void ShowProfanityStats() {
            var profanityFinder = new ProfanityFinder();

            foreach (var title in songTitles) {
                var song = new Song(name, title);
                var profanitiesAmount = profanityFinder.CountBadWords(song.lyrics);
                Console.WriteLine(song.title + ": " + profanitiesAmount);
            }
        }
    }
}