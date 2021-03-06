﻿using ChatApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreApiStarter.Data
{
    public class BusinessDbContext : DbContext
    {
        public BusinessDbContext(DbContextOptions<BusinessDbContext> options)
            : base(options)
        { }

        public DbSet<User> users { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}
