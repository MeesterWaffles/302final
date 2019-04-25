using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsProject
{
    class Player
    {
        private string _fName;
        private string _lName;
        private int _age;
        private int _wins;
        private int _losses;
        private int _points;

        public string fName
        {
            get { return _fName; }
            set { _fName = value; }
        }
        public string lName
        {
            get { return _lName; }
            set { _lName = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public int Wins
        {
            get { return _wins; }
            set { _wins = value; }
        }
        public int Losses
        {
            get { return _losses; }
            set { _losses = value; }
        }
        public int Points
        {
            get { return _points; }
            set { _points = value; }
        }
    }
}