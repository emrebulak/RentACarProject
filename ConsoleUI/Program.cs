using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CarManager carManager = new CarManager(new EfCarDal());

Car car = new Car { Id = 5, BrandId = 3, ColorId = 2, DailyPrice = 1500, Description = "Araba gibi araba", ModelYear = "2020" };

carManager.Add(car);


foreach (var carDetail in carManager.GetCarDetails().Data)
{
    Console.WriteLine("{0} / {1}", carDetail.CarName, carDetail.BrandName);
}

