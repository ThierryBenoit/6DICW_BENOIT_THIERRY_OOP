using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Wielrenner
    {
        private int rider_id;
        private string name;
        private string nationality;
        private DateTime birthdate;
        private string gender;
        private int total_wins;
        private decimal total_points;
        private int ranking;

        public Wielrenner(int rider_id, string name, string nationality, DateTime birthdate, string gender, int total_wins, decimal total_points, int ranking)
        {
            this.rider_id = rider_id;
            this.name = name;
            this.nationality = nationality;
            this.birthdate = birthdate;
            this.gender = gender;
            this.total_wins = total_wins;
            this.total_points = total_points;
            this.ranking = ranking;
        }
        override
            public string ToString()
        {
            String info = name + " from " + nationality + " born on " + birthdate.ToShortDateString() + " has " + total_wins + " wins and " + total_points + " points and is ranked " + ranking;
            return info;
        }

        public int Rider_id
        {
            get { return rider_id; }
        }

        public string Name
        {
            get { return name; }
        }
        
        public string Nationality
        {
            get { return nationality; }
        }

        public DateTime Birthdate
        {
            get { return birthdate; }
        }

        public string Gender
        {
            get { return gender; }
        }

        public int Total_wins { 
            get { return total_wins; }
        }

        public decimal Total_points
        {
            get { return total_points; }
        }

        public int Ranking
        {
            get { return ranking; }
        }   
    }
}
