﻿using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concerte.InMemory;
using Entities.Concerte;
namespace Business.Concerte
{
    public class CarManager:ICarService
    {
        private readonly ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }
        public List<Car> GetById(int id)
        {
            return _carDal.GetById(id);
        }
        public void Add(Car car)
        {
             _carDal.Add(car);
        }
        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }
        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}