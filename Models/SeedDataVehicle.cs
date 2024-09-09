using Microsoft.EntityFrameworkCore;
using RazorPagesRenterprise.Data;

namespace RazorPagesRenterprise.Models;

public static class SeedDataVehicle
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new RazorPagesRenterpriseContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<RazorPagesRenterpriseContext>>()))
        {
            if (context == null || context.Vehicle == null)
            {
                throw new ArgumentNullException("Null RazorPagesRenterpriseContext");
            }

            // Look for any vehicles.
            if (context.Vehicle.Any())
            {
                return;   // DB has been seeded
            }

            context.Vehicle.AddRange(
                new Vehicle
                {
                    Reg = "XU59JDK",
                    Make = "Toyota",
                    Model = "Corolla",
                    Color = "Red",
                    ImgUrl = "https://static.vecteezy.com/system/resources/previews/008/895/343/non_2x/outline-side-view-car-icon-isolated-on-white-background-free-vector.jpg"
                },

                new Vehicle
                { 
                    Reg = "PL19DTH",
                    Make = "Ford",
                    Model = "Fiesta",
                    Color = "Blue",
                    ImgUrl = "https://static.vecteezy.com/system/resources/previews/008/895/343/non_2x/outline-side-view-car-icon-isolated-on-white-background-free-vector.jpg"

                },

                new Vehicle
                { 
                    Reg = "ZX43MBY",
                    Make = "Honda",
                    Model = "Civic",
                    Color = "Red",
                    ImgUrl = "https://static.vecteezy.com/system/resources/previews/008/895/343/non_2x/outline-side-view-car-icon-isolated-on-white-background-free-vector.jpg"

                },
                 new Vehicle
                { 
                    Reg = "HY31TSK",
                    Make = "BMW",
                    Model = "X5",
                    Color = "Black",
                    ImgUrl = "https://static.vecteezy.com/system/resources/previews/008/895/343/non_2x/outline-side-view-car-icon-isolated-on-white-background-free-vector.jpg"

                },

                 new Vehicle
                { 
                    Reg = "GH86ZXY",
                    Make = "Audi",
                    Model = "A3",
                    Color = "White",
                    ImgUrl = "https://static.vecteezy.com/system/resources/previews/008/895/343/non_2x/outline-side-view-car-icon-isolated-on-white-background-free-vector.jpg"

                },
                 new Vehicle
                { 
                    Reg = " BV67LNM",
                    Make = "Ford",
                    Model = "Transit",
                    Color = "White",
                    ImgUrl = "https://www.shutterstock.com/image-vector/van-icon-cargo-minibus-black-260nw-2135123575.jpg"

                },
                 new Vehicle
                { 
                    Reg = "YT19WDF",
                    Make = "Mercedes-Benz",
                    Model = "Sprinter",
                    Color = "Silver",
                    ImgUrl = "https://www.shutterstock.com/image-vector/van-icon-cargo-minibus-black-260nw-2135123575.jpg"

                }
            );
            context.SaveChanges();


        }
    }
}