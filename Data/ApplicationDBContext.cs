using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiaryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DiaryApp.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DiaryEntry>().HasData(
                new DiaryEntry
                {
                    Id = 1,
                    Title = "Went Hiking",
                    Content = "Went hiking with friends. Great weather and views.",
                    DateCreated = new DateTime(2024, 1, 15, 0, 0, 0, DateTimeKind.Utc)
                },
                new DiaryEntry
                {
                    Id = 2,
                    Title = "Road Trip",
                    Content = "Drove to the coast. Enjoyed the scenic route.",
                    DateCreated = new DateTime(2024, 1, 16, 0, 0, 0, DateTimeKind.Utc)
                },
                new DiaryEntry
                {
                    Id = 3,
                    Title = "Diving Adventure",
                    Content = "Tried diving. Saw colorful fish and coral.",
                    DateCreated = new DateTime(2024, 1, 17, 0, 0, 0, DateTimeKind.Utc)
                }
            );
        }

        public DbSet<DiaryEntry> DiaryEntry { get; set; }
    }
}