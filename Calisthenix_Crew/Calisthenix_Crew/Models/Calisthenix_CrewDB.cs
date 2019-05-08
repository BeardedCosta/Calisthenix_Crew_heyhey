using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Calisthenix_Crew.Models
{
    public class Calisthenix_CrewDB : DbContext
    {

        // construtor da classe
        public Calisthenix_CrewDB() : base("Calisthenix_CrewDBConnectionString")
        { }

        // identificar as tabelas da base de dados
        public virtual DbSet<Exercise> Exercises { get; set; }
        public virtual DbSet<Guide> Guide { get; set; }
        public virtual DbSet<Multimedia> Multimedia { get; set; }
        public virtual DbSet<ExerciseGuide> ExercisesGuide { get; set; }
        public virtual DbSet<Suplement> Suplements { get; set; }
        public virtual DbSet<Workout> Workout { get; set; }
        public virtual DbSet<User> User { get; set; }

        /// <summary>
        /// configura a forma como as tabelas são criadas
        /// </summary>
        /// <param name="modelBuilder"> objeto que referencia o gerador de base de dados </param>      
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {


            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }

    }
}