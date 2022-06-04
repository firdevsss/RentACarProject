using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsByBrandId(int id );
        IDataResult<List<Car>> GetCarByColorId(int id);
        IDataResult<List<CarDetailDto>> GetCarDetailsDto();
        IDataResult<Car> GetById(int carId);
        IResult Add(Car car);
    }
}
