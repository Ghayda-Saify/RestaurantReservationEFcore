namespace RestaurantReservation.Db.Repositories;

public class OrdersRepo
{ 
    
    public static async Task<Order> CreateOrderAsync(Order order)
    {
        await using var context = new RestaurantReservationDbContext();
        await context.Orders.AddAsync(order);
        await context.SaveChangesAsync();
        return order;
    }

    public static async Task UpdateOrderAsync(Order order)
    {
        await using var context = new RestaurantReservationDbContext();
        context.Orders.Update(order);
        await context.SaveChangesAsync();
    }

    public static async Task DeleteOrderAsync(int orderId)
    {
        await using var context = new RestaurantReservationDbContext();
        var order = await context.Orders.FindAsync(orderId);
        if (order != null)
        {
            context.Orders.Remove(order);
            await context.SaveChangesAsync();
        }
    }
}