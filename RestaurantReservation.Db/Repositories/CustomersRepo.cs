using Microsoft.EntityFrameworkCore;

namespace RestaurantReservation.Db.Repositories;

public class CustomersRepo
{
    
    public static async Task<Customer> CreateCustomerAsync(Customer customer)
    {
        await using var context = new RestaurantReservationDbContext();
        await context.Customers.AddAsync(customer);
        context.ChangeTracker.DetectChanges();
        
        // To track the object status when calling this function
        var state = context.ChangeTracker.DebugView.ShortView;
        return customer;
    }

    public static async Task UpdateCustomerAsync(Customer customer)
    {
        await using var context = new RestaurantReservationDbContext();
        context.Customers.Update(customer);
        context.ChangeTracker.DetectChanges();
        var state = context.ChangeTracker.DebugView.ShortView;
            
    }

    public static async Task DeleteCustomerAsync(int customerId)
    {
        await using var context = new RestaurantReservationDbContext();
        var customer = await context.Customers.FindAsync(customerId);
        if (customer != null)
        {
            context.Customers.Remove(customer);
            await context.SaveChangesAsync();
        }
    }

    /// <summary>
    /// Finds customers who made reservations with a party size greater than a
    /// specified value by executing the 'sp_FindCustomersByPartySize' stored procedure.
    /// </summary>
    /// <param name="minPartySize"></param>
    /// <returns></returns>
    public static async Task<List<Customer>> FindCustomersByPartySize(int minPartySize)
    {
        await using var context = new RestaurantReservationDbContext();
        var result = context.Customers.FromSqlInterpolated($"EXEC sp_FindCustomersByPartySize {minPartySize}");
        
        return await result.ToListAsync();
    }
}