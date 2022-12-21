using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

Customer customer = new Customer { Id = 2, UserId = 3, CompanyName = "EmreBLK" };

CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

customerManager.Add(customer);

foreach (var customerDto in customerManager.GetAll().Data)
{
    Console.WriteLine(customerDto.CompanyName);
}

