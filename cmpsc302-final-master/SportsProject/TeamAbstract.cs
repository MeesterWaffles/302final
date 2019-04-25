using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SportsProject
{
    public abstract class TeamAbstract
    {
        private string _tName;
        private bool _active;
        public abstract string tName
        {
            get;
            set;
        }
        public abstract bool Active
        {
            get;
            set;
        }
    }
}