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
                new Rental
                {
                    Reg = "XU59JDK",
                    Customer = "Mr Peters",
                    OutLoc = "Norwich",
                    RetLoc = "Peterborough",
                    StartDate = DateTime.Parse("2024-08-28"),
                    ReturnDate = DateTime.Parse("2024-09-28"),
                    Status = "Open",
                    DayRate = 16.50,
                                     
        



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
                    DayRate = 16.50,
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
                    DayRate = 16.50,
                },
                new Rental
                {
                    Reg = "ZX43MBY",
                    Customer = "Mrs King",
                    OutLoc = "Norwich",
                    RetLoc = "Thetford",
                    StartDate = DateTime.Parse("2024-09-04"),
                    ReturnDate = DateTime.Parse("2024-09-22"),
                    Status = "Open",DayRate = 16.50,
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
                    DayRate = 16.50,
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
                    DayRate = 16.50,
                }
                );
            context.SaveChanges();
       }
    }
}