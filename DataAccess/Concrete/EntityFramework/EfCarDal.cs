using Core.EntitiyFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentaCarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentaCarContext context = new RentaCarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.ColorId equals b.Id
                             select new CarDetailDto
                             {
                                  
                                 CarId = c.Id,
                                 ColorId = c.ColorId,
                                 BrandName = b.BrandName,
                                 BrandId = b.Id,
                                 Description = c.Description,
                                 DailyPrice = c.DailyPrice,
                                 ModelYear = c.ModelYear,
                                 CarName = c.CarName
                             };
                return result.ToList();

            }
        }
    }
}
