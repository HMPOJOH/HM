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

        // Ctrl T ==> search for anything

        private static void DisplayInfoAboutShows(List<Show> allShows)
        {
            Header("All titles");

            // All titles to the screen

            var allTitles = allShows.Select(x => x.Title);

            // Display all titles

            Console.ForegroundColor = ConsoleColor.White;

            foreach (var item in allTitles)
            {
                Console.WriteLine(item);
            }

            DisplayShows("Programs that start at 21 or later", allShows.Where(x => x.StartAt.Hours >= 21));

            DisplayShows("Programs from SVT2 in chronological order", allShows.Where(x => x.Channel == "SVT2").OrderBy(x => x.StartAt));

            // ---> 9:33 break!
        }

        private static void DisplayShows(string header, IEnumerable<Show> shows)
        {
            Header(header);

            Console.ForegroundColor = ConsoleColor.White;

            foreach (var show in shows)
            {
                Console.WriteLine($"{show.Channel,-4} {show.StartAt} {show.Title}");
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

        private static string[] ReadTvShowFile()
        {
            return File.ReadAllLines(@"Linq\TvShows\tv-data.txt");
        }

        private static void Header(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine(message.ToUpper());
            Console.WriteLine();
        }
    }
}
