﻿using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using WebApplication1.Models.Entities;

namespace WebApplication1.Models.Contexts
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions options)
            : base(options)
        {

        }
        public DbSet<Country> Countries { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

    }
}
