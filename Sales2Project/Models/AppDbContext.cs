using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sales2Project.Models {
    public class AppDbContext : DbContext {
        public virtual DbSet<Customer> Customers { get; set;}

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder Builder);
        }
    }

