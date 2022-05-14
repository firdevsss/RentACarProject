using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        IColorDal _carDal;

        public CarManager(IColorDal carDal)
        {
            _carDal = carDal;
        }

        public void Add()
        {
            
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarByColorId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public List<CarDetailDto> GetCarDetailsDto()
        {
            return _carDal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }
    }
}
