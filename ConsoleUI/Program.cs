using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;


//ICarDal carDal = new EFCarDal();
//Car car = new Car { BrandId = 10, ColorId = 10, CarName = "BMW", DailyPrice = 500, ModelYear = 2003, Description = "Manuel" };
//carDal.Add(car);

//EFColorDal colorDal = new EFColorDal();
//Color color = new Color { ColorId = 10, ColorName = "Beyaz" };
//colorDal.Add(color);


//EFBrandDal brandDal = new EFBrandDal();
//Brand brand = new Brand { BrandId = 11, BrandName = "Mercedes" };
//brandDal.Add(brand);



//Console.WriteLine(colorManager.GetColor(3).Name);

//foreach (var car in carManager.GetAll())
//{
//    Console.WriteLine(car.CarName);
//}
//foreach (var car in carManager.GetCarsByColorId(20))
//{
//    Console.WriteLine(car.CarName);
//}
//foreach (var car in carManager.GetCarsByBrandId(20))
//{
//    Console.WriteLine(car.CarName);

//}



//CarManager carManager = new CarManager(new EFCarDal());
//foreach (var car in carManager.GetAll())
//{
//    Console.WriteLine(car.CarName);
//}

CarManager carManager = new CarManager(new EFCarDal());

foreach (var car in carManager.GetCarDetails())
{
    Console.WriteLine(car.CarName + "/" + car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice);
}

