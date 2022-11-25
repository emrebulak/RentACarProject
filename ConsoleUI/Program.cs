using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CarManager carManager = new CarManager(new EfCarDal());
Car car = new Car { Id = 3, BrandId = 2, ColorId = 3, DailyPrice = 1500, ModelYear = "2015", Description = "Temiz az yakan kiralık araba" };



carManager.Add(car);

foreach (var c in carManager.GetAll())
{
    Console.WriteLine(c.Description);
}
