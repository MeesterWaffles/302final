using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SportsProject
{
    public class PlayerActive : PlayerAbstract
    {
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