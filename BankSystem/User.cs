﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    internal class User
    {
        public string UserName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }






        public override string ToString()
        {
            return $"UserName {UserName} LastName {LastName} Age {Age}";
        }
    }
}
