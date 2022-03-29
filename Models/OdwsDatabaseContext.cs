using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Odws.Models
{
    public partial class OdwsDatabaseContext : DbContext
    {
        public OdwsDatabaseContext()
        {
        }

        public OdwsDatabaseContext(DbContextOptions<OdwsDatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Note> Notes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=database-2.csxzt6digvht.us-east-1.rds.amazonaws.com;Database=OdwsDatabase;Username=odwsdatabase;Password=etj810c222");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Note>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Date).HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
