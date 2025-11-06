namespace RestaurantReservation.Db.Repositories;

public class RestaurantTablesRepo
{

    public static async Task<RestaurantTable> CreateRestaurantTableAsync(RestaurantTable table)
    {
        await using var context = new RestaurantReservationDbContext();
        await context.RestaurantTables.AddAsync(table);
        await context.SaveChangesAsync();
        return table;
    }

    public static async Task UpdateRestaurantTableAsync(RestaurantTable table)
    {
        await using var context = new RestaurantReservationDbContext();
        context.RestaurantTables.Update(table);
        await context.SaveChangesAsync();
    }

    public static async Task DeleteRestaurantTableAsync(int tableId)
    {
        await using var context = new RestaurantReservationDbContext();
        var table = await context.RestaurantTables.FindAsync(tableId);
        if (table != null)
        {
            context.RestaurantTables.Remove(table);
            await context.SaveChangesAsync();
        }
    }
    
}