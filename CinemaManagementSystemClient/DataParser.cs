using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagementSystemClient
{
    public class DataParser
    {
        BusinessModelManager ModelManager;

        public event Action MoviesChanged;
        public event Action HallsChanged;
        public event Action ShowsChanged;
        public event Action TiketsChanged;

        public DataParser(BusinessModelManager modelManager)
        {
            ModelManager = modelManager;
        }

        public void RecognizeMessage(String message)
        {
            var com = message.Split('#');

            if (com.Length < 2) return;
            var cmd = com[0];

            if (cmd == "MoviesList")
            {
                ModelManager.Movies.Clear();
                for (int i = 1; i < com.Count(); i++)
                {
                    var unit = com[i].Split(':');
                    var movie = new Movie(Convert.ToInt32(unit[0]), unit[1], unit[2]);
                    ModelManager.Movies.Add(movie);
                    MoviesChanged();
                }
            }
            else if (cmd == "ShowsList")
            {
                ShowsChanged();
            }
            else if (cmd == "TiketsList")
            {
                TiketsChanged();
            }
            else if (cmd == "HallsList")
            {
                HallsChanged();
            }
        }    
    }
}
