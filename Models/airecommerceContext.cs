using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Back_end.Models
{
    public partial class airecommerceContext : DbContext
    {
        public airecommerceContext()
        {
        }

        public airecommerceContext(DbContextOptions<airecommerceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Publication> Publications { get; set; }
        public virtual DbSet<PublicationsPhoto> PublicationsPhotos { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // this uses the secret "ConnectionStrings:airecommerce"
                // this line below is for not using directly the connection string
                optionsBuilder.UseSqlServer("Name=ConnectionStrings:airecommerce");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Publication>(entity =>
            {
                entity.ToTable("publications");

                entity.Property(e => e.PublicationId)
                    .ValueGeneratedNever()
                    .HasColumnName("publication_id");

                entity.Property(e => e.Price)
                    .HasColumnType("numeric(16, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.PubDeleted)
                    .HasColumnName("pub_deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PubDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("pub_description");

                entity.Property(e => e.Publisher)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("publisher");

                entity.HasOne(d => d.PublisherNavigation)
                    .WithMany(p => p.Publications)
                    .HasForeignKey(d => d.Publisher)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_publication_user");
            });

            modelBuilder.Entity<PublicationsPhoto>(entity =>
            {
                entity.HasKey(e => e.PhotoId)
                    .HasName("PK__publicat__CB48C83D6744CB3A");

                entity.ToTable("publications_photos");

                entity.Property(e => e.PhotoId)
                    .ValueGeneratedNever()
                    .HasColumnName("photo_id");

                entity.Property(e => e.PhotoDeleted)
                    .HasColumnName("photo_deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PublicationId).HasColumnName("publication_id");

                entity.HasOne(d => d.Publication)
                    .WithMany(p => p.PublicationsPhotos)
                    .HasForeignKey(d => d.PublicationId)
                    .HasConstraintName("fk_publication_photos");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Username)
                    .HasName("PK__users__F3DBC573E7DC82FF");

                entity.ToTable("users");

                entity.Property(e => e.Username)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("last_name");

                entity.Property(e => e.Photo)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("photo");

                entity.Property(e => e.UsrDeleted)
                    .HasColumnName("usr_deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Verified)
                    .HasColumnName("verified")
                    .HasDefaultValueSql("((0))");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
