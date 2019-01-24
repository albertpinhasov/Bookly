﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace Bookly.Models
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public Address Address { get; set; }
        public DateTime DOB { get; set; }
        public MembershipType MembershipType { get; set; }

        

    }
}