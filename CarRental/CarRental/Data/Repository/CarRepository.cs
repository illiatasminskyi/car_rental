using CarRental.Models;

namespace CarRental.Data.Repository
{
    public class CarRepository
    {
        public static void Initialize(CarsContext context)
        {
            //CarsContext content = context.ApplicationServices.GetRequiredService<CarsContext>();
            if (!context.Cars.Any())
            {
                context.Cars.AddRange(
                    new Car
                    {
                        Name = "BMW",
                        
                    },
                    new Car
                    {
                        Name = "Mercedes",
                        
                    },
                    new Car
                    {
                        Name = "Porsche ",
                        
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
