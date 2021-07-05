using System;
using System.Collections.Generic;
using System.Text;
using authdemo.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace authdemo.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Stage> Stages { get; set; }
        public DbSet<Rapport> Rapports { get; set; }
        public DbSet<Correction> Corrections { get; set; }
        public DbSet<Claim> Claims { get; set; }


#pragma warning disable CS0114 // Un membre masque un membre hérité ; le mot clé override est manquant
        protected void OnModelCreating(ModelBuilder modelBuilder)
#pragma warning restore CS0114 // Un membre masque un membre hérité ; le mot clé override est manquant
        {
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Stage>().ToTable("Stage");
            modelBuilder.Entity<Instructor>().ToTable("Instructor");
            modelBuilder.Entity<Rapport>().ToTable("Rapport");
            modelBuilder.Entity<Correction>().ToTable("Correction");
            modelBuilder.Entity<Choix>().ToTable("Choix");

        }
    }
}
