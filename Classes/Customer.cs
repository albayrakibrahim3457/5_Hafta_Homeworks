﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        //Get ve set bloğunun ayrı ayrı kullanımına bir örnek
        //private string _firstName;
        //public string FirstName
        //{
        //  get {return "Mr. " + _firstName;}
        //  set { _firstName = value; }
        //}
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
