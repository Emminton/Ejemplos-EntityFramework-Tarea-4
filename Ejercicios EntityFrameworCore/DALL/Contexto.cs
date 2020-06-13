using Ejercicios_EntityFrameworCore.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace Ejercicios_EntityFrameworCore.DALL
{
    class Contexto : DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = .\SqlExpress; Database = SchoolDB; Trusted_Connection = True; ");
        }

        //Example of modelBuilder
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //With this configurations I force to colocate the primary key manually "Just to Person's entity"
            modelBuilder.Entity<Materia>().Property(p => p.MateriaId).HasColumnName("Id").HasDefaultValue(0).IsRequired();

            //shadow property
            modelBuilder.Entity<Materia>().Property<String>("Ocupacion");
            modelBuilder.Entity<Materia>().Property<int>("Edad");
        }

        public DbSet<Studen> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Materia> Materias { get; set; }
    }
}
