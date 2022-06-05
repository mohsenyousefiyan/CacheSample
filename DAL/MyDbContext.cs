using Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DAL
{
    public class MyDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Password=1;User=sa;Initial Catalog=CacheSample;Data Source=.");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Tbl_Users");
            modelBuilder.Entity<User>().Property(x => x.FirstName).HasMaxLength(30).IsUnicode();
            modelBuilder.Entity<User>().Property(x => x.LastName).HasMaxLength(50).IsUnicode();
            modelBuilder.Entity<User>().Property(x => x.UserName).HasMaxLength(100).IsUnicode(false);
            modelBuilder.Entity<User>().Property(x => x.Address).HasMaxLength(200).IsUnicode();
            modelBuilder.Entity<User>().Property(x => x.PhoneNumber).HasMaxLength(30).IsUnicode(false);

            var users = new List<User>();
            for (int i = 0; i < 100; i++)
                users.Add(new User() { Id = i + 1, FirstName = $"FirstName{i + 1}", LastName = $"LastName{i + 1}", UserName = $"U{i + 1}" });

            modelBuilder.Entity<User>().HasData(users);
        }

    }
}
