using Microsoft.EntityFrameworkCore;

namespace RestaurantReservation.Db.Repositories;

public class RestaurantsRepo
{
    public static async Task<Restaurant> CreateRestaurantAsync(Restaurant restaurant)
    {
        await using var context = new RestaurantReservationDbContext();
        await context.Restaurants.AddAsync(restaurant);
        await context.SaveChangesAsync();
        return restaurant;
    }

    public static async Task UpdateRestaurantAsync(Restaurant restaurant)
    {
        await using var context = new RestaurantReservationDbContext();
        context.Restaurants.Update(restaurant);
        await context.SaveChangesAsync();
    }

    public static async Task DeleteRestaurantAsync(int restaurantId)
    {
        await using var context = new RestaurantReservationDbContext();
        var restaurant = await context.Restaurants.FindAsync(restaurantId);
        if (restaurant != null)
        {
            context.Restaurants.Remove(restaurant);
            await context.SaveChangesAsync();
        }
    }
    
    /// <summary>
    /// Calculates the total revenue for a specific restaurant by calling the 'fn_CalculateTotalRevenue' database function.
    /// </summary>
    /// <param name="restaurantId"></param>
    /// <returns></returns>
    public static async Task<decimal> CalculateTotalRevenue(int restaurantId)
    {
        await using var context = new RestaurantReservationDbContext();
        var result =await context.Restaurants
            .Where(r => r.RestaurantId == restaurantId)
            .Select(r => RestaurantReservationDbContext.CalculateTotalRevenue(r.RestaurantId))
            .FirstOrDefaultAsync();
        
        return result;
    }
}