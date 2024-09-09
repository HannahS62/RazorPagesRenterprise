
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
