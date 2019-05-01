using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SportsProject
{
    public class PlayerInactive : PlayerAbstract
    {
        //active player class that extends the abstract player. this class doesnt actually add anything extra unlike the active player class
        private string _fName;
        private string _lName;
        private int _age;
        private bool _active;
        public override string fName
        {
            get { return _fName; }
            set { _fName = value; }
        }
        public override string lName
        {
            get { return _lName; }
            set { _lName = value; }
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