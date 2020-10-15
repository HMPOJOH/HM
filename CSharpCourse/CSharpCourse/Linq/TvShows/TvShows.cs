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
            List<Show> allShowssss = ParseTvShows_Linq(rows);

        }

        private static List<Show> ParseTvShows_Linq(string[] rows)
        {
            throw new NotImplementedException();
        }

        private static List<Show> ParseTvShows(string[] rows)
        {
            var result = new List<Show>();

            foreach (var item in rows)
            {
                // do stuff
            }
            return result;
        }
        // 13:40


        private static string[] ReadTvShowFile()
        {
            return File.ReadAllLines(@"Linq\TvShows\tv-data.txt");
        }
    }
}
