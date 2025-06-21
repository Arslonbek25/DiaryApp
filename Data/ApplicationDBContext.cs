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

        public DbSet<DiaryEntry> DiaryEntry { get; set; }
    }
}