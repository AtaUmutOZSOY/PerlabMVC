﻿using Core.Entity.Concretes;
using Microsoft.EntityFrameworkCore;
using Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class PerlabDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = "server=localhost;database=perlabdb;user=root;password=reostaspytr7B.!";
                var serverVersion = new MySqlServerVersion(new Version(8, 0, 21));

                optionsBuilder.UseMySql(connectionString, serverVersion, mySqlOptions =>
                    mySqlOptions.EnableRetryOnFailure(
                        maxRetryCount: 5, // Maksimum yeniden deneme sayısı
                        maxRetryDelay: TimeSpan.FromSeconds(10), // Yeniden denemeler arasındaki maksimum gecikme süresi
                        errorNumbersToAdd: null) // Yeniden denemeye neden olan spesifik MySQL hata kodları
                );
            }
        }

        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Collaboration> Collaborations { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<NewsFeed> NewsFeeds { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Publication> Publications { get; set; }
        public DbSet<Research> Researches { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<CarouselImage> CarouselImages { get; set; }
    }
}
