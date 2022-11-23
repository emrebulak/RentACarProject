using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear="2019",DailPrice=700000,Description="Very good"},
                new Car{Id=2,BrandId=1,ColorId=4,ModelYear="2021",DailPrice=900000,Description="Very good"},
                new Car{Id=3,BrandId=2,ColorId=3,ModelYear="2005",DailPrice=100000,Description="Very good"},
                new Car{Id=4,BrandId=2,ColorId=2,ModelYear="2020",DailPrice=800000,Description="Very good"},
                new Car{Id=5,BrandId=3,ColorId=5,ModelYear="2022",DailPrice=1000000,Description="Very good"},
                new Car{Id=6,BrandId=3,ColorId=5,ModelYear="2011",DailPrice=750000,Description="Very good"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);

        }

        public Car Get(Car car)
        {
            return _cars.FirstOrDefault(c => c.Id == car.Id);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailPrice = car.DailPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
