using System;
using Microsoft.EntityFrameworkCore;
using BlazorWebApp.Models;

namespace BlazorWebApp.Data;

public class UserDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<BlogPost> BlogPosts { get; set; }

    public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder) // using FLuent API (One-to-Many)
    {
        modelBuilder.Entity<User>()
        .HasMany(u => u.blogPosts)          // One-to-Many => one user can have multiple posts
        .WithOne(b => b.Author)             // Each post do has one Author
        .HasForeignKey(a => a.AuthorID);    // Foreign Key => references to the entity of User
    }
}
