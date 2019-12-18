using DomainModel;
using DomainModel.Entities;
using DomainModel.Entity;
using Microsoft.EntityFrameworkCore;
using System;

namespace DAL
{
    public class BlueContext : DbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Customer> Customers{ get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<BookingRoom> BookingRooms { get; set; }

        public BlueContext() : base()
        {
        }
        public BlueContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // only for AppliConsole
            //optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb; Initial Catalog=BlueDb; Integrated Security=true");
            //Integrated Security=true, connactionString

            base.OnConfiguring(optionsBuilder);
        }
     protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            // relation hotel and room ; many to one
            modelBuilder.Entity<Hotel>()
                .HasMany(h => h.Rooms)
                .WithOne(r => r.Hotel);

            // relation hotel and address ; one to one
            modelBuilder.Entity<Hotel>()
                .HasOne(h => h.Address);

            // relation customer and address ; one to one
            modelBuilder.Entity<Customer>()
                .HasOne(c => c.Address);



            //for many to many
            // declare keys for class BookingRoom
            modelBuilder.Entity<BookingRoom>()
                .HasKey(br => new { br.BookingId, br.RoomId });

            // relation bookingroom and room ; many to one
            modelBuilder.Entity<Room>()
                .HasMany(r => r.BookingRooms)
                .WithOne(br => br.Room);

            // relation bookingroom and booking; many to one
            modelBuilder.Entity<Booking>()
                .HasMany(b => b.BookingRooms)
                .WithOne(br => br.Booking);


            // relation booking and customer ; many to one
            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Bookings)
                .WithOne(b => b.Customer);
             
          base.OnModelCreating(modelBuilder);
        }

    }
}
