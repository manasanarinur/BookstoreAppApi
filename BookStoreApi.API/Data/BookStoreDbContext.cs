using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BookStoreApi.API.Data
{
    public partial class BookStoreDbContext : IdentityDbContext<ApiUser>
    {
        public BookStoreDbContext()
        {
        }

        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Author> Authors { get; set; } = null!;
        public virtual DbSet<Book> Books { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Author>(entity =>
            {
                entity.Property(e => e.Bio).HasMaxLength(250);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasIndex(e => e.Isbn, "UQ__Books__447D36EA559560CB")
                    .IsUnique();

                entity.Property(e => e.Image).HasMaxLength(50);

                entity.Property(e => e.Isbn)
                    .HasMaxLength(50)
                    .HasColumnName("ISBN");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Summary).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.AuthorId)
                    .HasConstraintName("FK_Books_ToTable");

                modelBuilder.Entity<IdentityRole>().HasData(
                    new IdentityRole
                    {
                        Name = "User",
                        NormalizedName = "USER",
                        Id = "50f0ba10-8b59-4286-b019-7eea16ac603f"
                    },
                   new IdentityRole
                   {
                       Name = "Administrator",
                       NormalizedName = "ADMINISTRATOR",
                       Id = "0d58b369-5b5c-4a8c-be13-06afc5d26d6e"

                   }
                    );
                var hasher = new PasswordHasher<ApiUser>();
                modelBuilder.Entity<ApiUser>().HasData(
                   new ApiUser
                   {
                       Id = "58f72d08-555c-47ab-8c8e-4ea6be4216ad",
                       Email = "admin@bookstore.com",
                       NormalizedEmail = "ADMIN@BOOKSTORE.COM",
                       UserName = "admin@bookstore.com",
                       NormalizedUserName = "ADMIN@BOOKSTORE.COM",
                       FirstName = "System",
                       LastName = "Admin",
                       PasswordHash = hasher.HashPassword(null, "P@ssword1")
                   },
                   new ApiUser
                   {
                       Id = "53256e45-7eaa-4e4a-899b-74b36a40362e",
                       Email = "user@booksstore.com",
                       NormalizedEmail = "USER@BOOKSTORE.COM",
                       UserName = "user@bookstore.com",
                       NormalizedUserName = "USER@BOOKSTORE.COM",
                       FirstName = "System",
                       LastName = "User",
                       PasswordHash = hasher.HashPassword(null, "P@ssword1")
                   }
                   );
                modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                    new IdentityUserRole<string>
                    {
                        RoleId = "50f0ba10-8b59-4286-b019-7eea16ac603f",
                        UserId = "53256e45-7eaa-4e4a-899b-74b36a40362e"
                    },
                     new IdentityUserRole<string>
                     {
                         RoleId = "0d58b369-5b5c-4a8c-be13-06afc5d26d6e",
                         UserId = "58f72d08-555c-47ab-8c8e-4ea6be4216ad"
                     }
                    );
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
