
namespace RazorPagesRenterprise.Models;

public class Vehicle
{
    public int Id { get; set; }
    public required string Reg {get; set;}        
    public required string Make { get; set; }
    public required string Model { get; set; }
    public string? Color { get; set; }

}   

