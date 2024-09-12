
using System.ComponentModel.DataAnnotations;
namespace RazorPagesRenterprise.Models;

public class Workshop
{
    public int Id { get; set; }
    public required string Reg {get; set;}        
    public required string Fault { get; set; }
        [DataType(DataType.Date)]
    public DateTime CompletionDate { get; set; }

    public string? Mechanic {get; set;}

    public required string Status {get; set;}
 

}   


//workshop image url: https://static.vecteezy.com/system/resources/thumbnails/025/902/580/small/maintenance-and-support-icon-concept-vector.jpg