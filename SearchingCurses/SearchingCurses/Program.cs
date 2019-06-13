using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace SearchingCurses {
    class Program {
        static void Main() {
            var webcache = new WebCache();
            webcache.SaveInCache("http://google.com", "html......");
            //var eminem = new Artist("Eminem");
            //eminem.songTitles = new List<string> {
            //    "Lose Yourself",
            //    "Not Afraid",
            //    "Sing for the Moment"
            //};
            //eminem.CalculateSwearAndWordCount();
            //eminem.DisplayStatistics();

            Console.WriteLine("Done.");
        }
    }

    class WebCache {
        SQLiteConnection connection;
        public WebCache() {
            connection = new SQLiteConnection("Data Source=WebCache.sqlite;");
            connection.Open();
        }

        public void SaveInCache(string url, string data) {
            var sql = new SQLiteCommand(
                "INSERT INTO cache (url, data) VALUES (?, ?)", connection);
            var parameterType = DbType.String;
            sql.Parameters.Add(new SQLiteParameter(DbType.String, "param1"){Value = url});
            sql.Parameters.Add(new SQLiteParameter(DbType.String, "param2"){Value = data});
            sql.ExecuteNonQuery();
                
        }
    }
}