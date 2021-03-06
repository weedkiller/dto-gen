﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DtoGen.Sample_02.Model
{
    public class MyContext : DbContext
    {

        public MyContext() : base("Name=DB")
        {
            Database.SetInitializer(new MyContextInitializer());
        }


        public DbSet<User> Users { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Book> Books { get; set; }

    }
}