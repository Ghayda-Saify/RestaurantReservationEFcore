using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantReservation.Db.Migrations
{
    /// <inheritdoc />
    public partial class CreateEmployeeRestaurantView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sql = @"
            CREATE VIEW EmployeeDetails AS
            SELECT 
                E.EmployeeId,
                E.FirstName,
                E.LastName,
                E.Position,
                R.Name AS RestaurantName,
                R.Address AS RestaurantAddress
            FROM Employees E
            JOIN Restaurants R ON E.RestaurantId = R.RestaurantId";
    
            migrationBuilder.Sql(sql);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP VIEW EmployeeDetails");
        }
    }
}