using System.Security.Policy;
using Microsoft.EntityFrameworkCore;
using RazorPagesRenterprise.Data;

namespace RazorPagesRenterprise.Models;

public static class SeedDataRental
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new RazorPagesRenterpriseContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<RazorPagesRenterpriseContext>>()))
        {
            
             if (context == null || context.Rental == null)
            {
                throw new ArgumentNullException("Null RazorPagesRenterpriseContext");
            }

            // Look for any vehicles.
            if (context.Rental.Any())
            {
                return;   // DB has been seeded
            }

            context.Rental.AddRange(
                // all reservations
                new Rental
                {
                    Reg = "XU21JDK",
                    Customer = "Mr Peters",
                    OutLoc = "Norwich",
                    RetLoc = "Peterborough",
                    StartDate = DateTime.Parse("2024-08-28"),
                    ReturnDate = DateTime.Parse("2024-09-28"),
                    Status = "Open",
                    DayRate = 27.50,                                 
    
                },

                new Rental
                {
                    Reg = "GH86ZXY",
                    Customer = "Mr Truffle",
                    OutLoc = "Norwich",
                    RetLoc = "Norwich",
                    StartDate = DateTime.Parse("2024-05-14"),
                    ReturnDate = DateTime.Parse("2024-10-28"),
                    Status = "Open",
                    DayRate = 29.50,
                },
                new Rental
                {
                    Reg = "HY31TSK",
                    Customer = "Mrs Rose",
                    OutLoc = "Norwich",
                    RetLoc = "Norwich",
                    StartDate = DateTime.Parse("2024-09-04"),
                    ReturnDate = DateTime.Parse("2024-09-10"),
                    Status = "Open",
                    DayRate = 35.50,
                },
                new Rental
                {
                    Reg = "ZX43MBY",
                    Customer = "Mrs King",
                    OutLoc = "Norwich",
                    RetLoc = "Thetford",
                    StartDate = DateTime.Parse("2024-09-04"),
                    ReturnDate = DateTime.Parse("2024-09-22"),
                    Status = "Open",DayRate = 32.50,
                },
                new Rental
                {
                    Reg = "YT19WDF",
                    Customer = "Mr Kefford",
                    OutLoc = "Norwich",
                    RetLoc = "Norwich",
                    StartDate = DateTime.Parse("2024-02-04"),
                    ReturnDate = DateTime.Parse("2024-09-12"),
                    Status = "Open",
                    DayRate = 46.50,
                },
                new Rental
                {
                    Reg = "XU59JDK",
                    Customer = "Miss Smiley",
                    OutLoc = "Norwich",
                    RetLoc = "Norwich",
                    StartDate = DateTime.Parse("2024-08-04"),
                    ReturnDate = DateTime.Parse("2024-09-17"),
                    Status = "Open",
                    DayRate = 34.50,
                },
                // Out reservations
                new Rental
                {
                    Reg = "AU55HIY",
                    Customer = "Mrs Smith",
                    OutLoc = "Norwich",
                    RetLoc = "Norwich",
                    StartDate = DateTime.Today,
                    ReturnDate = DateTime.Parse("2024-10-17"),
                    Status = "Open",
                    DayRate = 37.50,
                },
                new Rental
                {
                    Reg = "PU18LSV",
                    Customer = "Mr Bacon",
                    OutLoc = "Norwich",
                    RetLoc = "Thetford",
                    StartDate = DateTime.Today,
                    ReturnDate = DateTime.Parse("2024-09-28"),
                    Status = "Open",
                    DayRate = 37.50,                                 
    
                },

                new Rental
                {
                    Reg = "TY16ZXY",
                    Customer = "Mr Ocean",
                    OutLoc = "Norwich",
                    RetLoc = "Norwich",
                    StartDate = DateTime.Today,
                    ReturnDate = DateTime.Parse("2024-10-28"),
                    Status = "Open",
                    DayRate = 37.00,
                },
                new Rental
                {
                    Reg = "RF67MMH",
                    Customer = "Mrs Lily",
                    OutLoc = "Norwich",
                    RetLoc = "Norwich",
                    StartDate = DateTime.Today,
                    ReturnDate = DateTime.Parse("2024-10-10"),
                    Status = "Open",
                    DayRate = 42.15,
                },
                new Rental 
                {
                    Reg= "JI17OOY",
                    Customer = "Mr Duff",
                    OutLoc = "Norwich",
                    RetLoc = "Liverpool",
                    StartDate = DateTime.Today,
                    ReturnDate = DateTime.Parse("2024-09-25"),
                    Status = "Open",
                    DayRate = 28.75,
                },
                // in reservations
                new Rental
                {
                    Reg = "BU19APO",
                    Customer = "Mr Potter",
                    OutLoc = "Norwich",
                    RetLoc = "Norwich",
                    StartDate = DateTime.Parse("2024-08-03"),
                    ReturnDate = DateTime.Today,
                    Status = "Open",
                    DayRate = 37.00,
                },
                new Rental
                {
                    Reg = "LK22DFX",
                    Customer = "Mrs Granger",
                    OutLoc = "Norwich",
                    RetLoc = "Norwich",
                    StartDate = DateTime.Parse("2024-07-28"),
                    ReturnDate = DateTime.Today,
                    Status = "Open",
                    DayRate = 42.15,
                },
                new Rental 
                {
                    Reg= "AU18PSA",
                    Customer = "Mr Holmes",
                    OutLoc = "Thetford",
                    RetLoc = "Norwich",
                    StartDate = DateTime.Parse("2024-09-15"),
                    ReturnDate = DateTime.Today,
                    Status = "Open",
                    DayRate = 28.75,
                }

                );
            context.SaveChanges();
       }
    }
}