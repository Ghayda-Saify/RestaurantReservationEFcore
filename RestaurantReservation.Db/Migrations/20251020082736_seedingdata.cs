using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantReservation.Db.Migrations
{
    /// <inheritdoc />
    public partial class seedingdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "order_id",
                keyValue: 1,
                column: "order_date",
                value: new DateTime(2025, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "order_id",
                keyValue: 2,
                column: "order_date",
                value: new DateTime(2025, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "order_id",
                keyValue: 3,
                column: "order_date",
                value: new DateTime(2025, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "order_id",
                keyValue: 4,
                column: "order_date",
                value: new DateTime(2025, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "order_id",
                keyValue: 5,
                column: "order_date",
                value: new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "reservation_id",
                keyValue: 1,
                column: "reservation_date",
                value: new DateTime(2025, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "reservation_id",
                keyValue: 2,
                column: "reservation_date",
                value: new DateTime(2025, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "reservation_id",
                keyValue: 3,
                column: "reservation_date",
                value: new DateTime(2025, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "reservation_id",
                keyValue: 4,
                column: "reservation_date",
                value: new DateTime(2025, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "reservation_id",
                keyValue: 5,
                column: "reservation_date",
                value: new DateTime(2025, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "order_id",
                keyValue: 1,
                column: "order_date",
                value: new DateTime(2025, 10, 21, 11, 12, 16, 317, DateTimeKind.Local).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "order_id",
                keyValue: 2,
                column: "order_date",
                value: new DateTime(2025, 10, 22, 11, 12, 16, 317, DateTimeKind.Local).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "order_id",
                keyValue: 3,
                column: "order_date",
                value: new DateTime(2025, 10, 23, 11, 12, 16, 317, DateTimeKind.Local).AddTicks(8934));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "order_id",
                keyValue: 4,
                column: "order_date",
                value: new DateTime(2025, 10, 24, 11, 12, 16, 317, DateTimeKind.Local).AddTicks(8937));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "order_id",
                keyValue: 5,
                column: "order_date",
                value: new DateTime(2025, 10, 25, 11, 12, 16, 317, DateTimeKind.Local).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "reservation_id",
                keyValue: 1,
                column: "reservation_date",
                value: new DateTime(2025, 10, 21, 11, 12, 16, 315, DateTimeKind.Local).AddTicks(1072));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "reservation_id",
                keyValue: 2,
                column: "reservation_date",
                value: new DateTime(2025, 10, 22, 11, 12, 16, 317, DateTimeKind.Local).AddTicks(7594));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "reservation_id",
                keyValue: 3,
                column: "reservation_date",
                value: new DateTime(2025, 10, 23, 11, 12, 16, 317, DateTimeKind.Local).AddTicks(7615));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "reservation_id",
                keyValue: 4,
                column: "reservation_date",
                value: new DateTime(2025, 10, 24, 11, 12, 16, 317, DateTimeKind.Local).AddTicks(7619));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "reservation_id",
                keyValue: 5,
                column: "reservation_date",
                value: new DateTime(2025, 10, 25, 11, 12, 16, 317, DateTimeKind.Local).AddTicks(7622));
        }
    }
}
