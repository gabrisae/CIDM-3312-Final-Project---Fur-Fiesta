using Microsoft.EntityFrameworkCore;
using FurFiesta.Models;

namespace FurFiesta.Data
{

public class FurFiestaContext : DbContext
{
    public FurFiestaContext(DbContextOptions<FurFiestaContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Pet> Pets { get; set; }
    public DbSet<Post> Posts { get; set; } 
}
}