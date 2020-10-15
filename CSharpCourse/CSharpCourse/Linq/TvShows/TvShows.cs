using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharpCourse.Linq.TvShows
{
    public class TvShows
    {
        public static void Run()
        {
            string[] rows = ReadTvShowFile();

            List<Show> allShows = ParseTvShows(rows);

            // Extra exercise:
            //List<Show> allShowssss = ParseTvShows_Linq(rows);

            DisplayInfoAboutShows(allShows);

        }

        private static void DisplayInfoAboutShows(List<Show> allShows)
        {
            // All titles to the screen

            // 13:55

            var allTitles = allShows.Select(x => x.Title);

            // Display all titles

            foreach (var item in allTitles)
            {
                Console.WriteLine(item);
            }

        }

        private static List<Show> ParseTvShows_Linq(string[] rows)
        {
            throw new NotImplementedException();
        }

        private static List<Show> ParseTvShows(string[] rows)
        {
            var result = new List<Show>();

            foreach (string row in rows)
            {
                // row = "SVT1*22:00*Fatta Sveriges demokrati

                string[] splittedRows = row.Split('*'); // SVT1,22:00,Fatta Sveriges demokrati

                var show = new Show();

                show.Channel = splittedRows[0];
                show.StartAt = TimeSpan.Parse(splittedRows[1]);
                show.Title = splittedRows[2];

                result.Add(show);
            }
            return result;
        }
        // ----------> 13:40


        private static string[] ReadTvShowFile()
        {
            return File.ReadAllLines(@"Linq\TvShows\tv-data.txt");
        }
    }
}
