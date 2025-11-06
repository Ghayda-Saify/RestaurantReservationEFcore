using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantReservation.Db.Migrations
{
    /// <inheritdoc />
    public partial class CreateReservationView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sql = @"
            CREATE VIEW ReservationDetails AS
            SELECT 
                R.ReservationId,
                R.ReservationDate,
                R.PartySize,
                C.FirstName AS CustomerFirstName,
                C.LastName AS CustomerLastName,
                C.Email AS CustomerEmail,
                RT.Name AS RestaurantName,
                RT.Address AS RestaurantAddress
            FROM Reservations R
            JOIN Customers C ON R.CustomerId = C.CustomerId
            JOIN Restaurants RT ON R.RestaurantId = RT.RestaurantId";
            migrationBuilder.DropColumn(
                name: "opening_hours",
                table: "Restaurants");
            migrationBuilder.Sql(sql);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP VIEW ReservationDetails");
        }
    }
}
