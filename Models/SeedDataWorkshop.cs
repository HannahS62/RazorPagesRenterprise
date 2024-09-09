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
                    Fault = "Wing mirror needs replacing",
                    CompletionDate = DateTime.Parse("2024-09-16"),
                    Mechanic = "Bill"
                },
               
                new Workshop
                {
                    Reg = "YT19WDF",
                    Fault = "Dent in front left wheel arch, paint touch-up also required",
                    CompletionDate = DateTime.Parse("2024-10-01"),
                    Mechanic = "Ben"
                },
                new Workshop
                {
                    Reg = "CS15CSS",
                    Fault = "Dead battery",
                    CompletionDate = DateTime.Parse("2024-09-25"),
                    Mechanic = "Unassigned"
                }                

                );
            context.SaveChanges();
       }
    }
}