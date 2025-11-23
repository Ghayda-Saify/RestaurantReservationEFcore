using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantReservation.Db.Migrations
{
    /// <inheritdoc />
    public partial class CreateFindCustomersByPartySizeProc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sql = @"
            CREATE PROCEDURE sp_FindCustomersByPartySize @minPartySize INT 
            AS
            BEGIN
                SELECT DISTINCT C.*
                FROM Customers AS C
                JOIN Reservations AS R ON C.Id = R.CustomerId
                Where R.PartySize > @minPartySize
            END";
            migrationBuilder.Sql(sql);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP PROCEDURE IF EXISTS sp_FindCustomersByPartySize");
        }
    }
}
