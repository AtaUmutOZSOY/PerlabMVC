using Microsoft.EntityFrameworkCore;
using Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class PerlabDbContext:DbContext
    {
        public PerlabDbContext(DbContextOptions<PerlabDbContext> options):base(options)
        {
            
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



    }
}
