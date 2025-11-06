using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.Views;

namespace RestaurantReservation.Db.Repositories;

public class ReservationsRepo
{

    public static async Task<Reservation> CreateReservationAsync(Reservation reservation)
    {
        await using var context = new RestaurantReservationDbContext();
        await context.Reservations.AddAsync(reservation);
        await context.SaveChangesAsync();
        return reservation;
    }

    public static async Task UpdateReservationAsync(Reservation reservation)
    {
        await using var context = new RestaurantReservationDbContext();
        context.Reservations.Update(reservation);
        await context.SaveChangesAsync();
    }

    public static async Task DeleteReservationAsync(int reservationId)
    {
        await using var context = new RestaurantReservationDbContext();
        var reservation = await context.Reservations.FindAsync(reservationId);
        if (reservation != null)
        {
            context.Reservations.Remove(reservation);
            await context.SaveChangesAsync();
        }
    }
    
    public static async Task<List<Reservation>> GetReservationsByCustomer(int customerId)
    {
        await using var context = new RestaurantReservationDbContext();
        var result = context.Reservations.Where(e => e.CustomerId == customerId).ToList();
        return result;
    }

    /// <summary>
    /// Query the ReservationDetails view
    /// </summary>
    public static async Task<List<ReservationDetails>> GetReservationDetailsAsync()
    {
        await using var context = new RestaurantReservationDbContext();
        return await context.ReservationDetails.ToListAsync();
    }
}