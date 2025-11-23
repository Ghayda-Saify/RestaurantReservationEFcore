using System.ComponentModel.DataAnnotations;

namespace RestaurantReservation.Db;

public class MenuItem
{
    [Key]
    public int ItemId{get;set;}
    public int RestaurantId{get;set;}
    public required string Name{get;set;}
    public required string Description{get;set;}
    public decimal Price{get;set;}
}