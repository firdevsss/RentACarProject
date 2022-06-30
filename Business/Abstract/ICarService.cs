﻿using Core.Utilities.Results;
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
        IDataResult<List<Car>> GetCarById(int carId);
        IDataResult<List<CarDetailDto>> GetCarDetailsDto();
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
    }
}
