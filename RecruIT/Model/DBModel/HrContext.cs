﻿using Microsoft.EntityFrameworkCore;

namespace RecruIT.Model.DBModel
{

    internal class HrContext : DbContext
    {
        public DbSet<Employees> Employees { get; set; }
        public DbSet<ContactInfo> ContectInfo { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Posts> Posts { get; set; }
        public DbSet<Departments> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=HrDatabase.db");
        }
    }
}
