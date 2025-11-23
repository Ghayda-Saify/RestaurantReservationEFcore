using Microsoft.EntityFrameworkCore;

namespace RestaurantReservation.Db.Repositories;

public class MenuItemsRepo
{
            
    public static async Task<MenuItem> CreateMenuItemAsync(MenuItem menuItem)
    {
        await using var context = new RestaurantReservationDbContext();
        await context.MenuItems.AddAsync(menuItem);
        await context.SaveChangesAsync();
        return menuItem;
    }

    public static async Task UpdateMenuItemAsync(MenuItem menuItem)
    {
        await using var context = new RestaurantReservationDbContext();
        context.MenuItems.Update(menuItem);
        await context.SaveChangesAsync();
    }

    public static async Task DeleteMenuItemAsync(int menuItemId)
    {
        await using var context = new RestaurantReservationDbContext();
        var menuItem = await context.MenuItems.FindAsync(menuItemId);
        if (menuItem != null)
        {
            context.MenuItems.Remove(menuItem);
            await context.SaveChangesAsync();
        }
    }
    private static async Task<List<MenuItem?>> ListOrderedMenuItems(int reservationId)
    {
        await using var context = new RestaurantReservationDbContext();
        var result = await context.Orders
            .Where(o => o.ReservationId == reservationId) 
            .SelectMany(o => o.OrderItem)
            .Select(oi => oi!.MenuItem)
            .ToListAsync();
            
        return result;
            
            
    }

}