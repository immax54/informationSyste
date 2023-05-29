using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace informationSystemN.Entities
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Branches> Branches { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Activity> Activity { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Country> Country { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>()
                .HasMany(e => e.User)
                .WithRequired(e => e.Role)
                .HasForeignKey(e => e.UserRole);

            modelBuilder.Entity<User>()
                .Property(e => e.UserEmail)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserGender)
                .IsUnicode(false);
        }
    }
}
