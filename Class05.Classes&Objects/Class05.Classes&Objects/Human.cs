﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class05.Classes_Objects
{
    public class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public string GetPersonalDetails()
        {
            return $"{FirstName} {LastName} is {Age} years old";
        }
    }
}
