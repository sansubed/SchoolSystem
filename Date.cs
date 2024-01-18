﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calenders
{
    internal class Date 
    {
        private int _year;
        private int _month;
        private int _day;

        public Date(int year, int month, int day)
        {
            _year = year;
            _month = month;
            _day = day;

        }

        public override string ToString()
        {
            return _month + "/" + _day + "/" + _year;
        }
    }

   
}
