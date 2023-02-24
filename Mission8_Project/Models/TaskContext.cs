//Seeding the databases including setting up category and quadrants dropdown values

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission8_Project.Models
{
    public class TaskContext : DbContext
    {
        public TaskContext (DbContextOptions<TaskContext> options) : base(options)
        {
        //blank
        }

        public DbSet<TaskForm> Responses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Quadrant> Quadrants { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryId=1, Categories = "Home" },
                new Category { CategoryId = 2, Categories = "School" },
                new Category { CategoryId = 3, Categories = "Work" },
                new Category { CategoryId = 4, Categories = "Church" }
                );
            mb.Entity<Quadrant>().HasData(
                new Quadrant { QuadrantId = 1, Quadrants = "Quadrant 1" },
                new Quadrant { QuadrantId = 2, Quadrants = "Quadrant 2" },
                new Quadrant { QuadrantId = 3, Quadrants = "Quadrant 3" },
                new Quadrant { QuadrantId = 4, Quadrants = "Quadrant 4" }
                );
        }
    }
}
