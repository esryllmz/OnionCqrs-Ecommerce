﻿using Core.Security.Entities;
using ECommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ECommerce.Persistence.Contexts;

public class BaseDbContext : DbContext
{
  public BaseDbContext(DbContextOptions<BaseDbContext> opt) : base(opt)
  {

  }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);
    modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
  }

  public DbSet<Category> Categories { get; set; }
  public DbSet<Product> Products { get; set; }
  public DbSet<ProductImage> ProductImages { get; set; }
  public DbSet<SubCategory> SubCategories { get; set; }
  public DbSet<AppUser> Users { get; set; }
  public DbSet<Order> Orders { get; set; }
  public DbSet<OrderItem> OrderItems { get; set; }
  public DbSet<Tag> Tags { get; set; }
  public DbSet<ProductTag> ProductTags { get; set; }
  public DbSet<OperationClaim> OperationClaims { get; set; }
  public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
}
