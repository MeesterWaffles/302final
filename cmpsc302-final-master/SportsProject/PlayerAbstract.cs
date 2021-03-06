﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SportsProject
{
    public abstract class PlayerAbstract
    {
        //Abstract general class for a player. It only contains vital information about a player for name, age, and active status
        private string _fName;
        private string _lName;
        private int _age;
        private bool _active;
        public abstract string fName
        {
            get;
            set;
        }
        public abstract string lName
        {
            get;
            set;
        }
        public abstract int Age
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