using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

//CarManager carManager = new CarManager(new EfCarDal());
//Car car = new Car { Id = 3, BrandId = 2, ColorId = 3, DailyPrice = 1500, ModelYear = "2015", Description = "Temiz az yakan kiralık araba" };


//ColorManager colorManager = new ColorManager(new EfColorDal());
//var colors = colorManager.GetAll();

//foreach (var color in colors)
//{
//    Console.WriteLine(color.Name);
//}

CarManager carManager = new CarManager(new EfCarDal());
var carDetails = carManager.GetCarDetails();

foreach (var carDto in carDetails)
{
    Console.WriteLine("{0} - {1} - {2} - {3}", carDto.CarName, carDto.BrandName, carDto.ColorName, carDto.DailyPrice);
}



//carManager.Add(car);

//foreach (var c in carManager.GetAll())
//{
//    Console.WriteLine(c.Description);
//}
