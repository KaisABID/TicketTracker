#pragma warning disable CS8618
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace TicketsTracker.Models;

public class MyContext : DbContext
{
    public MyContext(DbContextOptions options) : base(options) { }
    public DbSet<User> Users { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Follower> Followers { get; set; }

}

