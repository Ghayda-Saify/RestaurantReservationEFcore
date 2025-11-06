using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantReservation.Db.Migrations
{
    /// <inheritdoc />
    public partial class CreateTotalRevenueFunction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sql = @"
            CREATE FUNCTION fn_CalculateTotalRevenue(@restaurantId INT)
            RETURNS DECIMAL(10,2)
            AS
            BEGIN
                DECLARE @totalRevenue DECIMAL(10,2)

                SELECT @totalRevenue = SUM(o.TotalAmount)
                FROM Orders o
                JOIN Reservations R ON O.reservation_id = R.reservation_id
                WHERE R.restaurant_id = @restaurantId;
                
                IF @totalRevenue IS NULL
                    @totalRevenue = 0;
                RETURN @totalRevenue;
            END";
            migrationBuilder.Sql(sql);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP FUNCTION IF EXISTS fn_CalculateTotalRevenue");
        }
    }
}
