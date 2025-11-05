using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.Views;

namespace RestaurantReservation.Db.Repositories;

public class EmployeesRepo
{

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
    
    /// <summary>
    /// Query the EmployeeDetails view
    /// </summary>
    public static async Task<List<EmployeeDetails>> GetEmployeeDetailsAsync()
    {
        await using var context = new RestaurantReservationDbContext();
        return await context.EmployeeDetails.ToListAsync();
    }

    
}