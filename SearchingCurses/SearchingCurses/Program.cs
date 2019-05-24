using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingCurses
{
    class Program
    {
        static void Main(string[] args)
        {
            var songLyrics = new SongLyrycs(artist:"Eminem", title:"Without me");
            var profoanityFinder = new ProfanityFinder();

            var censored = profoanityFinder.Censore(songLyrics.lyrics);
            
            Console.WriteLine(censored);
                
            Console.WriteLine("Done.");
            Console.ReadLine();
        }
    }

    internal class ProfanityFinder
    {
        private string[] badWords;
        
        public ProfanityFinder()
        {
            var dictFile = File.ReadAllText("../profanities.txt");
            dictFile = dictFile.Replace("*", "");
            badWords = dictFile.Split(new[] {"\",\""}, StringSplitOptions.None);
        }

        public string Censore(string text)
        {
            foreach (var word in badWords)
                text = text.Replace(" "+word+" ", " ____ ");

            return text;
        }
    }
}

