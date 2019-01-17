﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace Bookly.Models
{
    public class BooklyContext : DbContext
    {
       public DbSet<Book> Books { get; set; }
       public DbSet<Customer> Customers { get; set; }
    }
}