
using System.ComponentModel.DataAnnotations;
namespace RazorPagesRenterprise.Models;

public class Rental
{
    public int Id { get; set; }
    public required string Reg {get; set;}        
    public required string Customer { get; set; }
    public required string OutLoc { get; set; }
    public required string RetLoc { get; set; }
        [DataType(DataType.Date)]
    public required DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
    public DateTime ReturnDate { get; set; }
    

} 



// reservation url: https://media.istockphoto.com/id/1278801008/vector/calendar-and-check-mark-vector-icon.jpg?s=612x612&w=0&k=20&c=mb3TThoC0BJiFFB3JcwMPkTZULhSn5osrHK3o3gDUxg=