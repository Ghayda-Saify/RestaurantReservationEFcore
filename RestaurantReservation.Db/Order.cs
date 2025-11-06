using System.ComponentModel.DataAnnotations;

namespace RestaurantReservation.Db;

public class Order
{
    [Key]
    public int OrderId{get;set;}
    public int ReservationId{get;set;}
    public int EmployeeId{get;set;}
    public DateTime OrderDate{get;set;}
    public decimal TotalAmount{get;set;}
    public List<OrderItem?> OrderItem { get; set; } = [];
    public Restaurant? Restaurant{get;set;}
    public Employee? Employee {get;set;}
}