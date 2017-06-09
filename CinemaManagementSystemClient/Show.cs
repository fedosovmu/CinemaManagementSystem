using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaManagementSystemClient
{
    public class Show
    {
        public int ID;
        public int Movie_ID;
        public string Date;
        public int Hall_ID;
        public int Price;

        public Show(int ID, int Movie_ID, string Date, int Hall_ID, int Price)
        {
            this.ID = ID;
            this.Movie_ID = Movie_ID;
            this.Date = Date;
            this.Hall_ID = Hall_ID;
            this.Price = Price;
        }
    }
}
