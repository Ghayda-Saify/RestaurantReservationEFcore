using System.ComponentModel.DataAnnotations;

namespace RestaurantReservation.Db;

public class Employee
{
    [Key]
    public int EmployeeId{get;set;}
    public int RestaurantId{get;set;}
    public required string FirstName{get;set;}
    public required string LastName{get;set;}
    public required string Position{get;set;}
    
    public virtual Restaurant? Restaurant { get; set; }
    
    public static async Task<Employee> CreateEmployeeAsync(Employee employee)
    {
        await using var context = new RestaurantReservationDbContext();
        await context.Employees.AddAsync(employee);
        await context.SaveChangesAsync();
        return employee;
    }

    public static async Task UpdateEmployeeAsync(Employee employee)
    {
        await using var context = new RestaurantReservationDbContext();
        context.Employees.Update(employee);
        await context.SaveChangesAsync();
    }

    public static async Task DeleteEmployeeAsync(int employeeId)
    {
        await using var context = new RestaurantReservationDbContext();
        var employee = await context.Employees.FindAsync(employeeId);
        if (employee != null)
        {
            context.Employees.Remove(employee);
            await context.SaveChangesAsync();
        }
    }
}