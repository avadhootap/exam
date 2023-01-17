using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace myapp.Models
{
    public partial class DBPlayerContext : DbContext
    {
        public DBPlayerContext()
        {
        }

        public DBPlayerContext(DbContextOptions<DBPlayerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Player> Players { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("server=localhost;user id=root;password=Avadhoot@123;database=DBPlayer");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("player");

                entity.Property(e => e.Page)
                    .HasMaxLength(100)
                    .HasColumnName("PAge");

                entity.Property(e => e.Pcountry)
                    .HasMaxLength(100)
                    .HasColumnName("PCountry");

                entity.Property(e => e.Pname)
                    .HasMaxLength(100)
                    .HasColumnName("PName");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
