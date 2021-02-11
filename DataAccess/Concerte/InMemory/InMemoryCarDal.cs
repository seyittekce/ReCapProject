using System.Collections.Generic;
using System.Linq;
using DataAccess.Abstract;
using Entities.Concerte;
namespace DataAccess.Concerte.InMemory
{
    public class InMemoryCarDal:ICarDal
    {
        private readonly List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars =new List<Car>
            {
                new Car {Id=1,BrandId=1, ColorId="45",DailyPrice=150,Description="Ford Focus",ModelYear="2012"},
                new Car {Id=2,BrandId=2, ColorId="46",DailyPrice=200,Description="Renault Megan",ModelYear="2011"},
                new Car {Id=3,BrandId=3, ColorId="47",DailyPrice=250,Description="Renault Twingo",ModelYear="1999"},
                new Car {Id=4,BrandId=4, ColorId="48",DailyPrice=300,Description="Bmw i320",ModelYear="2005"},
                new Car {Id=5,BrandId=5, ColorId="49",DailyPrice=350,Description="Audi Q3",ModelYear="2020"}
            };
        }
        public List<Car> GetAll()
        {
            return _cars;
        }
        public List<Car> GetById(int id)
        {
            return _cars.Where(x => x.Id == id).ToList();
        }
        public void Add(Car car)
        {
           _cars.Add(car);
        }
        public void Delete(Car car)
        {
            _cars.Remove(car);
        }
        public void Update(Car car)
        {
            Car carToUpdate = _cars.FirstOrDefault(p => p.Id == car.Id);
            if (carToUpdate != null)
            {
                carToUpdate.BrandId = car.BrandId;
                carToUpdate.ColorId = car.ColorId;
                carToUpdate.DailyPrice = car.DailyPrice;
                carToUpdate.Description = car.Description;
                carToUpdate.ModelYear = car.ModelYear;
            }
        }
    }
}