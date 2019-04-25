using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SportsProject
{
    public class TeamActive : TeamAbstract
    {
        private int _wins;
        private int _losses;
        private int _points;
        private string _tname;
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

        public override string tName
        {
            get { return _tname; }
            set { _tname = value; }
        }
        public override bool Active
        {
            get { return _active; }
            set { _active = value; }
        }
    }
}