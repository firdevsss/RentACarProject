﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : IColorDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{ Id=1, BrandId = 3, ColorId=4, DailyPrice=1800, Description="Chevrolet İMPALA", ModelYear="1970"},
                new Car{ Id=2, BrandId = 7, ColorId=9, DailyPrice=3000, Description="Mercedes", ModelYear="2022"},
                new Car{ Id=3, BrandId = 5, ColorId=6, DailyPrice=1900, Description="Rolls ROYCE", ModelYear="1980"},
                new Car{ Id=4, BrandId = 1, ColorId=8, DailyPrice=3800, Description="CADİLLAC", ModelYear="2017"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.BrandId ==car.BrandId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllById(int categoryId)
        {
            return _cars.Where(c => c.Id == categoryId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToUpdate);
        }
    }
}