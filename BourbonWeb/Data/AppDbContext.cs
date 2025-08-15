﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BourbonWeb.Models;

namespace BourbonWeb.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<BourbonWeb.Models.Sample> Sample { get; set; } = default!;
        public DbSet<BourbonWeb.Models.HansokuSinsei> HansokuSinsei { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Sample>()
                .Property(p => p.Price)
                .HasPrecision(18, 4);

            modelBuilder.Ignore<HansokuSinsei>();
        }
    }
}
