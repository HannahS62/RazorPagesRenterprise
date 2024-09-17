
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

    public required string Status {get; set;}


    public int DaysOnRent
    {
        get
        {
            return (ReturnDate - StartDate).Days;
        }
    }
    
    //DayRate - display format being used to convert double to string with a fixed value of 2 decimal places

        [DisplayFormat(DataFormatString = "{0:F2}", ApplyFormatInEditMode = true)]
    public required double DayRate { get; set;}
     


        [DisplayFormat(DataFormatString = "{0:F2}", ApplyFormatInEditMode = true)]
    public double RentalPrice
    {
        get 
        {
            return DayRate * DaysOnRent;
        }
    }
     


} 



