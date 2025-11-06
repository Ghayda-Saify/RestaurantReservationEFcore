using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RestaurantReservation.Db.Views;

namespace RestaurantReservation.Db
{
    public class RestaurantReservationDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<RestaurantTable> RestaurantTables { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<ReservationDetails> ReservationDetails { get; set; }
        public DbSet<EmployeeDetails> EmployeeDetails { get; set; }

        protected override void ConfigureConventions(ModelConfigurationBuilder modelBuilder)
        {
            modelBuilder.Properties<string>().HaveColumnType("nvarchar (100)");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured) return;
            optionsBuilder.UseSqlServer(
                    "Server=(localdb)\\mssqllocaldb;Database=RestaurantReservationCore;Trusted_Connection=True;"
                ).LogTo(Console.WriteLine,
                    [DbLoggerCategory.Database.Command.Name],
                    LogLevel.Information)
                .EnableSensitiveDataLogging();
            ;
        }
        
        public static decimal CalculateTotalRevenue(int restaurantId) 
            => throw new NotSupportedException();
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             var baseDate = new DateTime(2025, 10, 20);
             // For views
             modelBuilder.Entity<EmployeeDetails>(eb =>
             {
                 eb.HasNoKey();
                 eb.ToView("EmployeeDetails");
             });
            
             modelBuilder.Entity<ReservationDetails>(eb =>
             {
                 eb.HasNoKey(); 
                 eb.ToView("ReservationDetails");
             });
             // For Func
             modelBuilder.HasDbFunction(typeof(RestaurantReservationDbContext)
                     .GetMethod(nameof(CalculateTotalRevenue), [typeof(int)]) ?? throw new InvalidOperationException())
                 .HasName("fn_CalculateTotalRevenue");
             
            // Seed Customers
            modelBuilder.Entity<Customer>().HasData(
                new Customer { CustomerId = 1, FirstName = "John", LastName = "Doe", Email = "john.doe@example.com", PhoneNumber = "111-222-3333" },
                new Customer { CustomerId = 2, FirstName = "Jane", LastName = "Smith", Email = "jane.smith@example.com", PhoneNumber = "222-333-4444" },
                new Customer { CustomerId = 3, FirstName = "Peter", LastName = "Jones", Email = "peter.jones@example.com", PhoneNumber = "333-444-5555" },
                new Customer { CustomerId = 4, FirstName = "Mary", LastName = "Williams", Email = "mary.williams@example.com", PhoneNumber = "444-555-6666" },
                new Customer { CustomerId = 5, FirstName = "David", LastName = "Brown", Email = "david.brown@example.com", PhoneNumber = "555-666-7777" }
            );

            // Seed Restaurants
            modelBuilder.Entity<Restaurant>().HasData(
                new Restaurant { RestaurantId = 1, Name = "The Golden Spoon", Address = "123 Main St", PhoneNumber = "123-456-7890", OpeningHours = "9 AM - 10 PM" },
                new Restaurant { RestaurantId = 2, Name = "The Silver Platter", Address = "456 Oak Ave", PhoneNumber = "234-567-8901", OpeningHours = "10 AM - 11 PM" },
                new Restaurant { RestaurantId = 3, Name = "The Bronze Fork", Address = "789 Pine Ln", PhoneNumber = "345-678-9012", OpeningHours = "8 AM - 9 PM" },
                new Restaurant { RestaurantId = 4, Name = "The Copper Knife", Address = "101 Maple Dr", PhoneNumber = "456-789-0123", OpeningHours = "11 AM - 12 AM" },
                new Restaurant { RestaurantId = 5, Name = "The Iron Skillet", Address = "202 Birch Rd", PhoneNumber = "567-890-1234", OpeningHours = "7 AM - 8 PM" }
            );

            // Seed Employees
            modelBuilder.Entity<Employee>().HasData(
                new Employee { EmployeeId = 1, RestaurantId = 1, FirstName = "Alice", LastName = "Johnson", Position = "Manager" },
                new Employee { EmployeeId = 2, RestaurantId = 1, FirstName = "Bob", LastName = "Miller", Position = "Chef" },
                new Employee { EmployeeId = 3, RestaurantId = 2, FirstName = "Charlie", LastName = "Davis", Position = "Manager" },
                new Employee { EmployeeId = 4, RestaurantId = 2, FirstName = "Diana", LastName = "Garcia", Position = "Waiter" },
                new Employee { EmployeeId = 5, RestaurantId = 3, FirstName = "Ethan", LastName = "Rodriguez", Position = "Manager" }
            );

            // Seed RestaurantTables
            modelBuilder.Entity<RestaurantTable>().HasData(
                new RestaurantTable { TableId = 1, RestaurantId = 1, Capacity = 4 },
                new RestaurantTable { TableId = 2, RestaurantId = 1, Capacity = 2 },
                new RestaurantTable { TableId = 3, RestaurantId = 2, Capacity = 6 },
                new RestaurantTable { TableId = 4, RestaurantId = 2, Capacity = 4 },
                new RestaurantTable { TableId = 5, RestaurantId = 3, Capacity = 8 }
            );

            // Seed MenuItems
            modelBuilder.Entity<MenuItem>().HasData(
                new MenuItem { ItemId = 1, RestaurantId = 1, Name = "Steak", Description = "Grilled to perfection", Price = 25.50m },
                new MenuItem { ItemId = 2, RestaurantId = 1, Name = "Salad", Description = "Fresh greens", Price = 12.00m },
                new MenuItem { ItemId = 3, RestaurantId = 2, Name = "Pasta", Description = "Classic Italian", Price = 18.75m },
                new MenuItem { ItemId = 4, RestaurantId = 2, Name = "Pizza", Description = "Wood-fired", Price = 20.00m },
                new MenuItem { ItemId = 5, RestaurantId = 3, Name = "Soup", Description = "Hearty and warm", Price = 9.50m }
            );

            // Seed Reservations
            modelBuilder.Entity<Reservation>().HasData(
                new Reservation { ReservationId = 1, CustomerId = 1, RestaurantId = 1, TableId = 1, ReservationDate = baseDate.AddDays(1), PartySize = 4 },
                new Reservation { ReservationId = 2, CustomerId = 2, RestaurantId = 1, TableId = 2, ReservationDate = baseDate.AddDays(2), PartySize = 2 },
                new Reservation { ReservationId = 3, CustomerId = 3, RestaurantId = 2, TableId = 3, ReservationDate = baseDate.AddDays(3), PartySize = 5 },
                new Reservation { ReservationId = 4, CustomerId = 4, RestaurantId = 2, TableId = 4, ReservationDate = baseDate.AddDays(4), PartySize = 3 },
                new Reservation { ReservationId = 5, CustomerId = 5, RestaurantId = 3, TableId = 5, ReservationDate = baseDate.AddDays(5), PartySize = 7 }
            );

            // Seed Orders
            modelBuilder.Entity<Order>().HasData(
                new Order { OrderId = 1, ReservationId = 1, EmployeeId = 2, OrderDate = baseDate.AddDays(1), TotalAmount = 50.00m },
                new Order { OrderId = 2, ReservationId = 2, EmployeeId = 2, OrderDate = baseDate.AddDays(2), TotalAmount = 25.00m },
                new Order { OrderId = 3, ReservationId = 3, EmployeeId = 4, OrderDate = baseDate.AddDays(3), TotalAmount = 75.00m },
                new Order { OrderId = 4, ReservationId = 4, EmployeeId = 4, OrderDate = baseDate.AddDays(4), TotalAmount = 40.00m },
                new Order { OrderId = 5, ReservationId = 5, EmployeeId = 5, OrderDate = baseDate.AddDays(5), TotalAmount = 100.00m }
            );

            // Seed OrderItems
            modelBuilder.Entity<OrderItem>().HasData(
                new OrderItem { OrderItemId = 1, OrderId = 1, ItemId = 1, Quantity = 2 },
                new OrderItem { OrderItemId = 2, OrderId = 2, ItemId = 2, Quantity = 1 },
                new OrderItem { OrderItemId = 3, OrderId = 3, ItemId = 3, Quantity = 3 },
                new OrderItem { OrderItemId = 4, OrderId = 4, ItemId = 4, Quantity = 2 },
                new OrderItem { OrderItemId = 5, OrderId = 5, ItemId = 5, Quantity = 4 }
            );
        }
    }
}