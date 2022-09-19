using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

ICarService carManager = new CarManager(new EFCarDal());



foreach (var car in carManager.GetAll())
{
    Console.WriteLine(car.Description);
}
foreach (var car in carManager.GetCarsByColorId(20))
{
    Console.WriteLine(car.CarName);
}
foreach (var car in carManager.GetCarsByBrandId(20))
{
    Console.WriteLine(car.CarName);

}
carManager.Add(new Car { BrandId = 18, ColorId = 4, DailyPrice = 600, ModelYear = 2003, Description = "spor araba" });

