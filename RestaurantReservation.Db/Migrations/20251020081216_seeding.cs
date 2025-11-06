using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestaurantReservation.Db.Migrations
{
    /// <inheritdoc />
    public partial class seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "customer_id", "email", "first_name", "last_name", "phone_number" },
                values: new object[,]
                {
                    { 1, "john.doe@example.com", "John", "Doe", "111-222-3333" },
                    { 2, "jane.smith@example.com", "Jane", "Smith", "222-333-4444" },
                    { 3, "peter.jones@example.com", "Peter", "Jones", "333-444-5555" },
                    { 4, "mary.williams@example.com", "Mary", "Williams", "444-555-6666" },
                    { 5, "david.brown@example.com", "David", "Brown", "555-666-7777" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "employee_id", "first_name", "last_name", "position", "restaurant_id" },
                values: new object[,]
                {
                    { 1, "Alice", "Johnson", "Manager", 1 },
                    { 2, "Bob", "Miller", "Chef", 1 },
                    { 3, "Charlie", "Davis", "Manager", 2 },
                    { 4, "Diana", "Garcia", "Waiter", 2 },
                    { 5, "Ethan", "Rodriguez", "Manager", 3 }
                });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "item_id", "description", "name", "price", "restaurant_id" },
                values: new object[,]
                {
                    { 1, "Grilled to perfection", "Steak", 25.50m, 1 },
                    { 2, "Fresh greens", "Salad", 12.00m, 1 },
                    { 3, "Classic Italian", "Pasta", 18.75m, 2 },
                    { 4, "Wood-fired", "Pizza", 20.00m, 2 },
                    { 5, "Hearty and warm", "Soup", 9.50m, 3 }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "order_item_id", "item_id", "order_id", "quantity" },
                values: new object[,]
                {
                    { 1, 1, 1, 2 },
                    { 2, 2, 2, 1 },
                    { 3, 3, 3, 3 },
                    { 4, 4, 4, 2 },
                    { 5, 5, 5, 4 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "order_id", "employee_id", "order_date", "reservation_id", "total_amount" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2025, 10, 21, 11, 12, 16, 317, DateTimeKind.Local).AddTicks(8620), 1, 50.00m },
                    { 2, 2, new DateTime(2025, 10, 22, 11, 12, 16, 317, DateTimeKind.Local).AddTicks(8930), 2, 25.00m },
                    { 3, 4, new DateTime(2025, 10, 23, 11, 12, 16, 317, DateTimeKind.Local).AddTicks(8934), 3, 75.00m },
                    { 4, 4, new DateTime(2025, 10, 24, 11, 12, 16, 317, DateTimeKind.Local).AddTicks(8937), 4, 40.00m },
                    { 5, 5, new DateTime(2025, 10, 25, 11, 12, 16, 317, DateTimeKind.Local).AddTicks(8939), 5, 100.00m }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "reservation_id", "customer_id", "party_size", "reservation_date", "restaurant_id", "table_id" },
                values: new object[,]
                {
                    { 1, 1, 4, new DateTime(2025, 10, 21, 11, 12, 16, 315, DateTimeKind.Local).AddTicks(1072), 1, 1 },
                    { 2, 2, 2, new DateTime(2025, 10, 22, 11, 12, 16, 317, DateTimeKind.Local).AddTicks(7594), 1, 2 },
                    { 3, 3, 5, new DateTime(2025, 10, 23, 11, 12, 16, 317, DateTimeKind.Local).AddTicks(7615), 2, 3 },
                    { 4, 4, 3, new DateTime(2025, 10, 24, 11, 12, 16, 317, DateTimeKind.Local).AddTicks(7619), 2, 4 },
                    { 5, 5, 7, new DateTime(2025, 10, 25, 11, 12, 16, 317, DateTimeKind.Local).AddTicks(7622), 3, 5 }
                });

            migrationBuilder.InsertData(
                table: "RestaurantTables",
                columns: new[] { "table_id", "capacity", "restaurant_id" },
                values: new object[,]
                {
                    { 1, 4, 1 },
                    { 2, 2, 1 },
                    { 3, 6, 2 },
                    { 4, 4, 2 },
                    { 5, 8, 3 }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "restaurant_id", "address", "name", "opening_hours", "phone_number" },
                values: new object[,]
                {
                    { 1, "123 Main St", "The Golden Spoon", "9 AM - 10 PM", "123-456-7890" },
                    { 2, "456 Oak Ave", "The Silver Platter", "10 AM - 11 PM", "234-567-8901" },
                    { 3, "789 Pine Ln", "The Bronze Fork", "8 AM - 9 PM", "345-678-9012" },
                    { 4, "101 Maple Dr", "The Copper Knife", "11 AM - 12 AM", "456-789-0123" },
                    { 5, "202 Birch Rd", "The Iron Skillet", "7 AM - 8 PM", "567-890-1234" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "employee_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "employee_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "employee_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "employee_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "employee_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "item_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "item_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "item_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "item_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "item_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "order_item_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "order_item_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "order_item_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "order_item_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "order_item_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "order_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "order_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "order_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "order_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "order_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "reservation_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "reservation_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "reservation_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "reservation_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "reservation_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "table_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "table_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "table_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "table_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RestaurantTables",
                keyColumn: "table_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "restaurant_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "restaurant_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "restaurant_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "restaurant_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "restaurant_id",
                keyValue: 5);
        }
    }
}
