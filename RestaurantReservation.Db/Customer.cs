using System.ComponentModel.DataAnnotations;

namespace RestaurantReservation.Db;

public class Customer
{
    [Key]
    public int CustomerId{get;set;}
    public required string FirstName{get;set;}
    public required string LastName{get;set;}
    public required string Email{get;set;}
    public required string PhoneNumber{get;set;}
    
    public static async Task<Customer> CreateCustomerAsync(Customer customer)
    {
        await using var context = new RestaurantReservationDbContext();
        await context.Customers.AddAsync(customer);
        context.ChangeTracker.DetectChanges();
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
}