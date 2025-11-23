using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantReservation.Db.Migrations
{
    /// <inheritdoc />
    public partial class CreateReservationDetailsView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
            
            migrationBuilder.DropColumn(
                name: "phone_number",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "first_name",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "last_name",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "first_name",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "last_name",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "phone_number",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "capacity",
                table: "RestaurantTables",
                newName: "Capacity");

            migrationBuilder.RenameColumn(
                name: "restaurant_id",
                table: "RestaurantTables",
                newName: "RestaurantId");

            migrationBuilder.RenameColumn(
                name: "table_id",
                table: "RestaurantTables",
                newName: "TableId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Restaurants",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "Restaurants",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "restaurant_id",
                table: "Restaurants",
                newName: "RestaurantId");

            migrationBuilder.RenameColumn(
                name: "table_id",
                table: "Reservations",
                newName: "TableId");

            migrationBuilder.RenameColumn(
                name: "restaurant_id",
                table: "Reservations",
                newName: "RestaurantId");

            migrationBuilder.RenameColumn(
                name: "reservation_date",
                table: "Reservations",
                newName: "ReservationDate");

            migrationBuilder.RenameColumn(
                name: "party_size",
                table: "Reservations",
                newName: "PartySize");

            migrationBuilder.RenameColumn(
                name: "customer_id",
                table: "Reservations",
                newName: "CustomerId");

            migrationBuilder.RenameColumn(
                name: "reservation_id",
                table: "Reservations",
                newName: "ReservationId");

            migrationBuilder.RenameColumn(
                name: "total_amount",
                table: "Orders",
                newName: "TotalAmount");

            migrationBuilder.RenameColumn(
                name: "reservation_id",
                table: "Orders",
                newName: "ReservationId");

            migrationBuilder.RenameColumn(
                name: "order_date",
                table: "Orders",
                newName: "OrderDate");

            migrationBuilder.RenameColumn(
                name: "employee_id",
                table: "Orders",
                newName: "EmployeeId");

            migrationBuilder.RenameColumn(
                name: "order_id",
                table: "Orders",
                newName: "OrderId");

            migrationBuilder.RenameColumn(
                name: "quantity",
                table: "OrderItems",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "order_id",
                table: "OrderItems",
                newName: "OrderId");

            migrationBuilder.RenameColumn(
                name: "item_id",
                table: "OrderItems",
                newName: "ItemId");

            migrationBuilder.RenameColumn(
                name: "order_item_id",
                table: "OrderItems",
                newName: "OrderItemId");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "MenuItems",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "MenuItems",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "MenuItems",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "restaurant_id",
                table: "MenuItems",
                newName: "RestaurantId");

            migrationBuilder.RenameColumn(
                name: "item_id",
                table: "MenuItems",
                newName: "ItemId");

            migrationBuilder.RenameColumn(
                name: "position",
                table: "Employees",
                newName: "Position");

            migrationBuilder.RenameColumn(
                name: "restaurant_id",
                table: "Employees",
                newName: "RestaurantId");

            migrationBuilder.RenameColumn(
                name: "employee_id",
                table: "Employees",
                newName: "EmployeeId");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Customers",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "customer_id",
                table: "Customers",
                newName: "CustomerId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Restaurants",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Restaurants",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "OpeningHours",
                table: "Restaurants",
                type: "nvarchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Restaurants",
                type: "nvarchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "RestaurantId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MenuItemItemId",
                table: "OrderItems",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "MenuItems",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "MenuItems",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Position",
                table: "Employees",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Employees",
                type: "nvarchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Employees",
                type: "nvarchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Customers",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Customers",
                type: "nvarchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "John", "Doe", "111-222-3333" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Jane", "Smith", "222-333-4444" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3,
                columns: new[] { "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Peter", "Jones", "333-444-5555" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4,
                columns: new[] { "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "Mary", "Williams", "444-555-6666" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5,
                columns: new[] { "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { "David", "Brown", "555-666-7777" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Alice", "Johnson" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Bob", "Miller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Charlie", "Davis" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Diana", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Ethan", "Rodriguez" });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 1,
                column: "MenuItemItemId",
                value: null);

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 2,
                column: "MenuItemItemId",
                value: null);

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 3,
                column: "MenuItemItemId",
                value: null);

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 4,
                column: "MenuItemItemId",
                value: null);

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "OrderItemId",
                keyValue: 5,
                column: "MenuItemItemId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "RestaurantId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "RestaurantId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "RestaurantId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4,
                column: "RestaurantId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5,
                column: "RestaurantId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 1,
                columns: new[] { "OpeningHours", "PhoneNumber" },
                values: new object[] { "9 AM - 10 PM", "123-456-7890" });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 2,
                columns: new[] { "OpeningHours", "PhoneNumber" },
                values: new object[] { "10 AM - 11 PM", "234-567-8901" });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 3,
                columns: new[] { "OpeningHours", "PhoneNumber" },
                values: new object[] { "8 AM - 9 PM", "345-678-9012" });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 4,
                columns: new[] { "OpeningHours", "PhoneNumber" },
                values: new object[] { "11 AM - 12 AM", "456-789-0123" });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 5,
                columns: new[] { "OpeningHours", "PhoneNumber" },
                values: new object[] { "7 AM - 8 PM", "567-890-1234" });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_EmployeeId",
                table: "Orders",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_RestaurantId",
                table: "Orders",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_MenuItemItemId",
                table: "OrderItems",
                column: "MenuItemItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_RestaurantId",
                table: "Employees",
                column: "RestaurantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Restaurants_RestaurantId",
                table: "Employees",
                column: "RestaurantId",
                principalTable: "Restaurants",
                principalColumn: "RestaurantId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_MenuItems_MenuItemItemId",
                table: "OrderItems",
                column: "MenuItemItemId",
                principalTable: "MenuItems",
                principalColumn: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Employees_EmployeeId",
                table: "Orders",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Restaurants_RestaurantId",
                table: "Orders",
                column: "RestaurantId",
                principalTable: "Restaurants",
                principalColumn: "RestaurantId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Restaurants_RestaurantId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_MenuItems_MenuItemItemId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Employees_EmployeeId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Restaurants_RestaurantId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_EmployeeId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_RestaurantId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_MenuItemItemId",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_Employees_RestaurantId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "OpeningHours",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "RestaurantId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "MenuItemItemId",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "Capacity",
                table: "RestaurantTables",
                newName: "capacity");

            migrationBuilder.RenameColumn(
                name: "RestaurantId",
                table: "RestaurantTables",
                newName: "restaurant_id");

            migrationBuilder.RenameColumn(
                name: "TableId",
                table: "RestaurantTables",
                newName: "table_id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Restaurants",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Restaurants",
                newName: "address");

            migrationBuilder.RenameColumn(
                name: "RestaurantId",
                table: "Restaurants",
                newName: "restaurant_id");

            migrationBuilder.RenameColumn(
                name: "TableId",
                table: "Reservations",
                newName: "table_id");

            migrationBuilder.RenameColumn(
                name: "RestaurantId",
                table: "Reservations",
                newName: "restaurant_id");

            migrationBuilder.RenameColumn(
                name: "ReservationDate",
                table: "Reservations",
                newName: "reservation_date");

            migrationBuilder.RenameColumn(
                name: "PartySize",
                table: "Reservations",
                newName: "party_size");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Reservations",
                newName: "customer_id");

            migrationBuilder.RenameColumn(
                name: "ReservationId",
                table: "Reservations",
                newName: "reservation_id");

            migrationBuilder.RenameColumn(
                name: "TotalAmount",
                table: "Orders",
                newName: "total_amount");

            migrationBuilder.RenameColumn(
                name: "ReservationId",
                table: "Orders",
                newName: "reservation_id");

            migrationBuilder.RenameColumn(
                name: "OrderDate",
                table: "Orders",
                newName: "order_date");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Orders",
                newName: "employee_id");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "Orders",
                newName: "order_id");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "OrderItems",
                newName: "quantity");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "OrderItems",
                newName: "order_id");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "OrderItems",
                newName: "item_id");

            migrationBuilder.RenameColumn(
                name: "OrderItemId",
                table: "OrderItems",
                newName: "order_item_id");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "MenuItems",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "MenuItems",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "MenuItems",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "RestaurantId",
                table: "MenuItems",
                newName: "restaurant_id");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "MenuItems",
                newName: "item_id");

            migrationBuilder.RenameColumn(
                name: "Position",
                table: "Employees",
                newName: "position");

            migrationBuilder.RenameColumn(
                name: "RestaurantId",
                table: "Employees",
                newName: "restaurant_id");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Employees",
                newName: "employee_id");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Customers",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Customers",
                newName: "customer_id");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "address",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

            migrationBuilder.AddColumn<string>(
                name: "opening_hours",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "phone_number",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "MenuItems",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "MenuItems",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "position",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

            migrationBuilder.AddColumn<string>(
                name: "first_name",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "last_name",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

            migrationBuilder.AddColumn<string>(
                name: "first_name",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "last_name",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "phone_number",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 1,
                columns: new[] { "first_name", "last_name", "phone_number" },
                values: new object[] { "John", "Doe", "111-222-3333" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 2,
                columns: new[] { "first_name", "last_name", "phone_number" },
                values: new object[] { "Jane", "Smith", "222-333-4444" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 3,
                columns: new[] { "first_name", "last_name", "phone_number" },
                values: new object[] { "Peter", "Jones", "333-444-5555" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 4,
                columns: new[] { "first_name", "last_name", "phone_number" },
                values: new object[] { "Mary", "Williams", "444-555-6666" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "customer_id",
                keyValue: 5,
                columns: new[] { "first_name", "last_name", "phone_number" },
                values: new object[] { "David", "Brown", "555-666-7777" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "employee_id",
                keyValue: 1,
                columns: new[] { "first_name", "last_name" },
                values: new object[] { "Alice", "Johnson" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "employee_id",
                keyValue: 2,
                columns: new[] { "first_name", "last_name" },
                values: new object[] { "Bob", "Miller" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "employee_id",
                keyValue: 3,
                columns: new[] { "first_name", "last_name" },
                values: new object[] { "Charlie", "Davis" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "employee_id",
                keyValue: 4,
                columns: new[] { "first_name", "last_name" },
                values: new object[] { "Diana", "Garcia" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "employee_id",
                keyValue: 5,
                columns: new[] { "first_name", "last_name" },
                values: new object[] { "Ethan", "Rodriguez" });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "restaurant_id",
                keyValue: 1,
                columns: new[] { "opening_hours", "phone_number" },
                values: new object[] { "9 AM - 10 PM", "123-456-7890" });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "restaurant_id",
                keyValue: 2,
                columns: new[] { "opening_hours", "phone_number" },
                values: new object[] { "10 AM - 11 PM", "234-567-8901" });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "restaurant_id",
                keyValue: 3,
                columns: new[] { "opening_hours", "phone_number" },
                values: new object[] { "8 AM - 9 PM", "345-678-9012" });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "restaurant_id",
                keyValue: 4,
                columns: new[] { "opening_hours", "phone_number" },
                values: new object[] { "11 AM - 12 AM", "456-789-0123" });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "restaurant_id",
                keyValue: 5,
                columns: new[] { "opening_hours", "phone_number" },
                values: new object[] { "7 AM - 8 PM", "567-890-1234" });
        }
    }
}
