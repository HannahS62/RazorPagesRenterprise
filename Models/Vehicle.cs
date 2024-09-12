
namespace RazorPagesRenterprise.Models;

public class Vehicle
{
    public int Id { get; set; }
    public required string Reg {get; set;}        
    public required string Make { get; set; }
    public required string Model { get; set; }
    public required string Color { get; set; }

    public required string ImgUrl {get; set;}

}   

