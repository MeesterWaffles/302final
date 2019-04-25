using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SportsProject
{
    public class TeamInactive : TeamAbstract
    {
        private string _tname;
        private bool _active;
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