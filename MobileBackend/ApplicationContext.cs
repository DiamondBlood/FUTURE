using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL3.Models;

namespace MobileBackend
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserFatDownProgress>()
                .HasNoKey();
            modelBuilder.Entity<UserMuscleUpProgress>()
               .HasNoKey();
            modelBuilder.Entity<UserReliefProgress>()
               .HasNoKey();
        }

        public DbSet<FatDownProgress> FatDownProgress {get;set;}
        public DbSet<MuscleUpProgress> MuscleUpProgress {get;set;}   
        public DbSet<ReliefProgress> ReliefProgress{ get; set; }
        public DbSet<UserData> UserData {get;set;}
        public DbSet<UserFatDownProgress> UserFatDownProgress {get;set;}
        public DbSet<UserMuscleUpProgress> UserMuscleUpProgress {get;set;}
        public DbSet<UserReliefProgress> UserReliefProgress {get;set;}
}
}
