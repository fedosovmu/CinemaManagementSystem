using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagementSystemClient
{
    public class BusinessModelManager
    {
        public NetConnection Connection;
        public DataParser Parser;
        public List<Movie> Movies;
        public List<Hall> Halls;
        public List<Show> Shows;
        public List<Ticket> Tikets;

        public event Action MoviesChanged;
        public event Action HallsChanged;
        public event Action ShowsChanged;
        public event Action TiketsChanged;

        public BusinessModelManager(NetConnection connection)
        {
            Connection = connection;
            Parser = new DataParser(this);

            Parser.MoviesChanged += () => MoviesChanged();
            Parser.HallsChanged += () => HallsChanged();
            Parser.ShowsChanged += () => ShowsChanged();
            Parser.TiketsChanged += () => TiketsChanged();

            Movies = new List<Movie>();
            Halls = new List<Hall>();
            Shows = new List<Show>();
            Tikets = new List<Ticket>();

            Connection.MsgRecievedEvent += (message) => Parser.RecognizeMessage(message);
        }

        public List<Show> GetShowesList(int MovieId)
        {
            var list = new List<Show>();
            foreach (var show in Shows)
                if (show.Movie_ID == MovieId)
                    list.Add(show);
            return list;
        }
    }
}
