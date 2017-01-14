﻿using Cacti.Web.Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Cacti.Web.Infrastructure.Data
{
    public class CactiDbContext : IdentityDbContext<User>
    {
        public CactiDbContext() {}
        public CactiDbContext(DbContextOptions<CactiDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder )
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.
                Entity<BlogPost>()
                .HasIndex(b => b.Title)
                .IsUnique();

            builder
                .Entity<ContentTag>()
                .HasIndex(b => b.Name)
                .IsUnique();

            builder.Entity<BlogPostContentTag>()
                .HasKey(t => new { t.BlogPostId, t.ContentTagId });

            builder.Entity<BlogPostContentTag>()
                .HasOne(pt => pt.BlogPost)
                .WithMany(p => p.BlogPostsContentTags)
                .HasForeignKey(pt => pt.BlogPostId);

            builder.Entity<BlogPostContentTag>()
                .HasOne(pt => pt.ContentTag)
                .WithMany(t => t.BlogPostsContentTags)
                .HasForeignKey(pt => pt.ContentTagId);

            base.OnModelCreating(builder);
        }

        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<ContentTag> ContentTags { get; set; }
        public DbSet<BlogPostContentTag> BlogPostsContentTags { get; set; }
    }
}
