using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing
{
  public class PizzaBoxContext : DbContext
  {


    public DbSet<Store> Stores { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<APizzaModel> Pizzas { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Topping> Toppings { get; set; }
    public DbSet<Crust> Crusts { get; set; }
    public DbSet<Size> Sizes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
      builder.UseSqlServer("Server=tcp:;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      
      //Configure domain classes using modelBuilder here  
      builder.Entity<Store>().HasKey(s => s.EntityId);
     
      builder.Entity<User>().HasKey(u => u.EntityId);
                
      builder.Entity<Crust>().HasKey(c => c.EntityId);
      builder.Entity<Order>().HasKey(o => o.EntityId);

            builder.Entity<Order>().HasOne(o => o.User)
            .WithMany(u => u.Orders);

            builder.Entity<Order>().HasOne(o => o.Store)
            .WithMany(s => s.Orders);

            builder.Entity<APizzaModel>().HasOne(a => a.Order)
            .WithMany(o => o.Pizzas);
            /*
            //new..
            builder.Entity<Order>()
                .HasMany(o => o.Pizzas);
            builder.Entity<Order>()
                .HasOne(o => o.User);
             builder.Entity<Order>()
                .HasOne(o => o.Store);
            builder.Entity<Store>()
                .HasMany(s => s.Orders);
            builder.Entity<User>()
                .HasMany(u => u.Orders);
            */
            //builder.Entity<User>()
            //    .HasMany(u => u.SelectedStore);
            /*
           builder.Entity<Order>().HasOne(o => o.store)
            .WithMany(s => s.Orders);
            */

      builder.Entity<APizzaModel>().HasKey(p => p.EntityId);
      builder.Entity<Topping>().HasKey(t => t.EntityId);
      builder.Entity<Size>().HasKey(s => s.EntityId);
     // builder.Entity<Pizza>().HasKey(p => p.PizzaId);
   //   builder.Entity<APizzaModel>().ToTable("APizzaModel");
   //   builder.Entity<Store>().ToTable("Store");
   //   builder.Entity<User>().ToTable("User");
   //   builder.Entity<Order>().ToTable("Order");
   //   builder.Entity<Pizza>().ToTable("Pizza");
      //builder.Entity<Store>().ToTable("Store");
   //   builder.Entity<Store>().Property(s => s.StoreId).ValueGeneratedNever();
      SeedData(builder);
      
    }
/*
 
 public int ID { get; set; }
    public List<Order> Orders { get; set; }
    public string Name { get; set; }
    public List<Topping> Toppings { get; set; }
    public List<Size> Sizes { get; set; }
    public List<Crust> Crusts { get; set; }

 */
    private void SeedData(ModelBuilder builder)
    {
          
        builder.Entity<Store>().HasData(new System.Collections.Generic.List<Store>
            {
                new Store() {EntityId = 2,  Name = "PizzaHut"},
                new Store() {EntityId = 3,  Name = "Domino"},
                new Store() {EntityId = 4,  Name = "RoundTable"}
            }
            );
         builder.Entity<Topping>().HasData(new System.Collections.Generic.List<Topping>
            {
                new Topping("Pineapple", 3) { EntityId = 301, Name = "Pineapple", Price = 3},
                new Topping("Olives", 1) { EntityId = 302, Name = "Olives", Price = 1},
                new Topping("Pepperoni", 4) { EntityId = 303, Name = "Pepperoni", Price = 4}
            }
            );

        // populate Crust, size,
         builder.Entity<Size>().HasData(new System.Collections.Generic.List<Size>
            {
                new Size("Large", 10) { EntityId = 101, Name = "Large", Price = 10},
                new Size("Medium", 8) { EntityId = 102, Name = "Medium", Price = 8},
                new Size("Small", 6) { EntityId = 103, Name = "Samll", Price = 6}
            }
            );

             builder.Entity<Crust>().HasData(new System.Collections.Generic.List<Crust>
            {
                new Crust("Double-dough", 5) { EntityId = 201, Name = "Double-dough", Price = 5},
                new Crust("Deep Dish", 6) { EntityId = 203, Name = "Deep Dish", Price = 6},
                new Crust("St. Louis", 4) { EntityId = 202, Name = "St. Louis", Price = 4}
            }
            );
     /*  builder.Enti
            {
                entity.ToTable("Topping");

                entity.HasOne(d => d.Pizza)
                    .WithMany(p => p.Topping)
                    .HasForeignKey(d => d.PizzaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PizzaId");

                entity.HasOne(d => d.Topping)
                    .WithMany(p => p.PizzaTopping)
                    .HasForeignKey(d => d.ToppingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ToppingId");
            });
 
            builder.Entity<Size>(entity =>
            {
                entity.ToTable("Size");

                entity.Property(e => e.SizeId).ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Price).HasColumnType("money");
            });
         /*    
          *  
         builder.Entity<User>().HasData(new System.Collections.Generic.List<User>
            {
                new User() {EntityId = 2, Name = "Yichen"};
                new User() {EntityId = 3, Name = "Seraphina"}
            }
        );
         builder.Entity<Order>().HasData(new List<User>)
            {
                new Order() {EntityId = 2, Name = "MeatPizza"};
                new Order() {EntityId = 3, Name = "VeggiePizza"}
            };
            */
            
    }
    //private void ViewOrdersByStore(Store store){
    //    }

  }
}
