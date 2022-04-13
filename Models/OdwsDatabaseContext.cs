using Microsoft.EntityFrameworkCore;

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
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=database-2.csxzt6digvht.us-east-1.rds.amazonaws.com;Database=OdwsDatabase;Username=odwsdatabase;Password=etj810c222");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Note>(entity =>
            {
                entity.ToTable("notes");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
