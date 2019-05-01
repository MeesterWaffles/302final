using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SportsProject
{
    public class PlayerActive : PlayerAbstract
    {
        //active player class that extends the abstract player by adding information regarding play such as wins, losses, and points
        //exceptions here are thrown if he usre trys to put in a negative number for wins, losses, or points
        private int _wins;
        private int _losses;
        private int _points;
        private int _age;
        private string _fname;
        private string _lname;
        private bool _active;

        public int Wins
        {
            get { return _wins; }
            set
            {
                if (value < 0) throw new Exception("Error: Number of wins can not be negative");
                else _wins = value;
            }
        }
        public int Losses
        {
            get { return _losses; }
            set
            {
                if (value < 0) throw new Exception("Error: Number of losses can not be negative");
                else _losses = value;
            }
        }
        public int Points
        {
            get { return _points; }
            set
            {
                if (value < 0) throw new Exception("Error: Number of points can not be negative");
                else _points = value;
            }
        }
        public override string fName
        {
            get { return _fname; }
            set { _fname = value; }
        }
        public override string lName
        {
            get { return _lname; }
            set { _lname = value; }
        }
        public override int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public override bool Active
        {
            get { return _active; }
            set { _active = value; }
        }
    }
}