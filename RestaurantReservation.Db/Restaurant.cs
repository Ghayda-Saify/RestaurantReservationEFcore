using System.ComponentModel.DataAnnotations;

namespace RestaurantReservation.Db;

public class Restaurant
{
    [Key]
    public int RestaurantId{get;set;}
    public required string Name{get;set;}
    public required string Address{get;set;}
    public required string PhoneNumber{get;set;}
    public required string OpeningHours{get;set;}
    public virtual List<Employee> Employees { get; set; } = [];
    
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
}