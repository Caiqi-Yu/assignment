namespace assignment.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<School> Schools { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<School>()
                .HasMany(e => e.Teachers)
                .WithRequired(e => e.School)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Teacher>()
                .HasMany(e => e.Students)
                .WithRequired(e => e.Teacher)
                .WillCascadeOnDelete(false);
        }

        public System.Data.Entity.DbSet<assignment.Models.Articles> Articles { get; set; }

        public System.Data.Entity.DbSet<assignment.Models.Movies> Movies { get; set; }

        public System.Data.Entity.DbSet<assignment.Models.AspNetRoles> AspNetRoles { get; set; }

        public System.Data.Entity.DbSet<assignment.Models.AspNetUserRoles> AspNetUserRoles { get; set; }
    }
}
