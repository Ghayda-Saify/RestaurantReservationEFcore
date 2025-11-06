namespace RestaurantReservation.Db.Repositories;

public class OrderItemsRepo
{

    public static async Task<OrderItem> CreateOrderItemAsync(OrderItem orderItem)
    {
        await using var context = new RestaurantReservationDbContext();
        await context.OrderItems.AddAsync(orderItem);
        await context.SaveChangesAsync();
        return orderItem;
    }

    public static async Task UpdateOrderItemAsync(OrderItem orderItem)
    {
        await using var context = new RestaurantReservationDbContext();
        context.OrderItems.Update(orderItem);
        await context.SaveChangesAsync();
    }

    public static async Task DeleteOrderItemAsync(int orderItemId)
    {
        await using var context = new RestaurantReservationDbContext();
        var orderItem = await context.OrderItems.FindAsync(orderItemId);
        if (orderItem != null)
        {
            context.OrderItems.Remove(orderItem);
            await context.SaveChangesAsync();
        }
    }
    
}