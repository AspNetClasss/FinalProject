using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;
using FinalProject.BackEnd.Models.DomainModels.PersonAggregates;
using FinalProject.BackEnd.Models.DomainModels.ProductAggregates;

namespace FinalProject.BackEnd.Models
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Person> Person { get; set; }
        public DbSet<Product>Product { get; set; }
    }

}

