using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db;
// using RestaurantReservation.Db.Models;
using System.Threading.Tasks;

namespace RestaurantReservation
{

    public class Program
    {
        public static async Task Main(string[] args)
        {

            var result =await ListManagersAsync();
            foreach (var manager in result)
            {
                Console.WriteLine(manager.FirstName + " " + manager.LastName);
            }

        }

        private static async Task<List<Employee>> ListManagersAsync()
        {
            await using var context = new RestaurantReservationDbContext();
            var result =  await context.Employees.Where(e=>e.Position=="Manager").ToListAsync();
            return result;
        }

        private static async Task<List<Reservation>> GetReservationsByCustomer(int customerId)
        {
            await using var context = new RestaurantReservationDbContext();
            var result = context.Reservations.Where(e => e.CustomerId == customerId).ToList();
            return result;
        }

        private static async Task<List<Order>> ListOrdersAndMenuItems(int reservationId)
        {
            await using var context = new RestaurantReservationDbContext();
            var result = await context.Orders
                    .Where(o => o.ReservationId == reservationId)
                    // for all orders with this rev id, include orderItems
                    .Include(o => o.OrderItem)
                    // Then for all orderItems, include menuItems
                    .ThenInclude(oi=>oi!.MenuItem)
                    .ToListAsync();
            return result;
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

        private static async Task<decimal> CalculateAverageOrderAmount(int employeeId)
        {
            await using var context = new RestaurantReservationDbContext();
            var employeeOrders = context.Orders.Where(o => o.EmployeeId == employeeId).ToList();
            if (employeeOrders.Count == 0)
            {
                return 0;
            }
            
            var result = employeeOrders.Average(o => o.TotalAmount);
            
            return result;
        }
    }
}
