using CleanArch.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.Data.Context
{
    public class UniversalDbContext : DbContext
    {
        public UniversalDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Course> Course { get; set; }
    }
}
