using Microsoft.EntityFrameworkCore;
using RazorPagesRenterprise.Data;

namespace RazorPagesRenterprise.Models;

public static class SeedDataWorkshop
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new RazorPagesRenterpriseContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<RazorPagesRenterpriseContext>>()))
        {
            
             if (context == null || context.Workshop == null)
            {
                throw new ArgumentNullException("Null RazorPagesRenterpriseContext");
            }

            // Look for any workshop items.
            if (context.Workshop.Any())
            {
                return;   // DB has been seeded
            }

            context.Workshop.AddRange(
                new Workshop
                {
                    Reg = "XU59JDK",
                    Fault = "Replace left wing mirror",
                    CompletionDate = DateTime.Parse("2024-09-16"),
                    Mechanic = "Bill",
                    Status = "Open"
                   
                },
               
                new Workshop
                {
                    Reg = "YT19WDF",
                    Fault = "Dent in front left wheel arch",
                    CompletionDate = DateTime.Parse("2024-10-01"),
                    Mechanic = "Ben",
                    Status = "Open"
                  
                },
                new Workshop
                {
                    Reg = "CS15CSS",
                    Fault = "Dead battery",
                    CompletionDate = DateTime.Parse("2024-09-25"),
                    Mechanic = "Unassigned",
                    Status = "Open"
                  
                },
                new Workshop
                {
                    Reg = "HT13ML5",
                    Fault = "Aircon regas required",
                    CompletionDate = DateTime.Parse("2024-09-20"),
                    Mechanic = "Bob",
                    Status = "Open"
                 
                }                   

                );
            context.SaveChanges();
       }
    }
}