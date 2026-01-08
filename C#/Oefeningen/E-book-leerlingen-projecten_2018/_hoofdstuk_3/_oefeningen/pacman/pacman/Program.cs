using System;

namespace Pacman // Note: actual namespace depends on the project name.
{

    class Pacman
    {
        private String _naam;
        private int _aantalLevens;
        private bool _isOnKwetsbaar;
        public Pacman(String naam, int aantalLevens)
        {
            _naam = naam;
            _aantalLevens = aantalLevens;
            _isOnKwetsbaar = false;
        }

        public String Naam
        { 
            get { return _naam; } 
            set { _naam = value; }
        }

        public int AantalLevens
        {
            get { return _aantalLevens; }           
        }

        public bool IsOnkwetsbaar
        {
            get { return _isOnKwetsbaar; }
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Pacman x = new Pacman("Joris", 7);
            int y = x.AantalLevens;
            Console.WriteLine("Hello World!!!" + y);
        }
    }
}