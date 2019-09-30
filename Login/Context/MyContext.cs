﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Login.Models;

namespace Login.Context
{
    class MyContext:DbContext
    {
        public MyContext() : base("DbConnectionString")
        {
        }
        public DbSet<User> Users { get; set; }
    }
}
