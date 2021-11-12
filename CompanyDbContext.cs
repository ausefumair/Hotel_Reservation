using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Reservation.Models
{
    public class CompanyDbContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }

        public CompanyDbContext(DbContextOptions<CompanyDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().ToTable("Company");
        }
    }

    public class CompanyPlanDbContext : DbContext
    {
        public DbSet<CompanyPlan> CompanyPlans { get; set; }

        public CompanyPlanDbContext(DbContextOptions<CompanyPlanDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CompanyPlan>().ToTable("CompanyPlan");
        }
    }

    public class UserAccountDbContext : DbContext
    {
        public DbSet<UserAccount> UserAccounts { get; set; }

        public UserAccountDbContext(DbContextOptions<UserAccountDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserAccount>().ToTable("UserAccount");
        }
    }

    public class CityDbContext : DbContext
    {
        public DbSet<City> Cities { get; set; }

        public CityDbContext(DbContextOptions<CityDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().ToTable("City");
        }
    }

    public class CountryDbContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }

        public CountryDbContext(DbContextOptions<CountryDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().ToTable("Country");
        }
    }

    public class HotelDbContext : DbContext
    {
        public DbSet<Hotel> Hotels { get; set; }

        public HotelDbContext(DbContextOptions<HotelDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hotel>().ToTable("Hotel");
        }
    }

    public class RoomDbContext : DbContext
    {
        public DbSet<Room> Rooms { get; set; }

        public RoomDbContext(DbContextOptions<RoomDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>().ToTable("Room");
        }
    }

    public class ReservationDbContext : DbContext
    {
        public DbSet<Reservation> Reservations { get; set; }

        public ReservationDbContext(DbContextOptions<ReservationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reservation>().ToTable("Reservation");
        }
    }

    public class ReservationStatusDbContext : DbContext
    {
        public DbSet<ReservationStatus> ReservationStatus { get; set; }

        public ReservationStatusDbContext(DbContextOptions<ReservationStatusDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReservationStatus>().ToTable("ReservationStatus");
        }
    }

    public class GuestsDbContext : DbContext
    {
        public DbSet<Guests> Guests { get; set; }

        public GuestsDbContext(DbContextOptions<GuestsDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Guests>().ToTable("Guests");
        }
    }
}
