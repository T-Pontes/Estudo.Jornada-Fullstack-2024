using Fina.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Fina.Api.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Category> Categories { get; set; } = null!;
    public DbSet<Transaction> Transactions { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        // Varre o projeto em busca de tudas a classes que implementam a interface IEntityTypeConfiguration
        => modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
}
