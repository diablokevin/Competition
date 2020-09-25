using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Competition.EF.Models
{
    public class CompetitionDbContext : DbContext
    {
        public CompetitionDbContext()
            :base ("name=CompetitionDbContext")
        {
        }

        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Competitor> Competitors { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Chip> Chips { get; set; }
        public virtual DbSet<Judge> Judges { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<Score> Scores { get; set; }

        public System.Data.Entity.DbSet<Competition.EF.Models.EventCriteria> EventCriterias { get; set; }
        public DbSet<ScoreDetail> ScoreDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ScoreDetail>().HasRequired(a => a.EventCriteria).WithMany(u => u.ScoreDetail).WillCascadeOnDelete(false);
            modelBuilder.Entity<ScoreDetail>().HasRequired(a => a.Score).WithMany(u => u.ScoreDetail).WillCascadeOnDelete(false);
        }
    }

   
}
