﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Web.Data.Models;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Web.Data.Models;

namespace Web.Data
{
    public partial class RazorPageBlogContext : DbContext
    {
        public RazorPageBlogContext()
        {
        }

        public RazorPageBlogContext(DbContextOptions<RazorPageBlogContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Article> Article { get; set; }
        public virtual DbSet<ArticleTagCloudMapping> ArticleTagCloudMapping { get; set; }
        public virtual DbSet<TagCloud> TagCloud { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Body).HasDefaultValueSql("('')");

                entity.Property(e => e.CoverPhoto).HasDefaultValueSql("('')");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Title).HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ArticleTagCloudMapping>(entity =>
            {
                entity.HasKey(e => new { e.ArticleId, e.TagId });

                entity.Property(e => e.ArticleId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.TagId).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Article)
                    .WithMany(p => p.ArticleTagCloudMapping)
                    .HasForeignKey(d => d.ArticleId)
                    .HasConstraintName("FK_Article_TagCloud_Mapping_Article");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.ArticleTagCloudMapping)
                    .HasForeignKey(d => d.TagId)
                    .HasConstraintName("FK_Article_TagCloud_Mapping_TagCloud");
            });

            modelBuilder.Entity<TagCloud>(entity =>
            {
                entity.Property(e => e.TagId).ValueGeneratedNever();

                entity.Property(e => e.Name).HasDefaultValueSql("('')");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}