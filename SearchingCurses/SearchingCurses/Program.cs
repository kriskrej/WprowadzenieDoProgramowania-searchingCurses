using System;
using System.Collections.Generic;

namespace SearchingCurses
{
    class Program
    {
        static void Main() {
            var eminem = new Artist("Eminem");
            eminem.songTitles = new List<string> {
                "Lose Yourself",
                "Not Afraid",
                "Sing for the Moment"
            };

            eminem.ShowProfanityStats();
                
            Console.WriteLine("Done.");
        }
    }
}

