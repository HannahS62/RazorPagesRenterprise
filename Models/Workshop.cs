
using System.ComponentModel.DataAnnotations;
namespace RazorPagesRenterprise.Models;

public class Workshop
{
    public int Id { get; set; }
    public required string Reg {get; set;}        
    public required string Fault { get; set; }
        [DataType(DataType.Date)]
    public DateTime CompletionDate { get; set; }

}   
