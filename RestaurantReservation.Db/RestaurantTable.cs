using System.ComponentModel.DataAnnotations;

namespace RestaurantReservation.Db;

public class RestaurantTable
{
    [Key]
    public int TableId { get; set; }
    public int RestaurantId { get; set; }
    public int Capacity { get; set; }
    
    
}