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
    public class EfCarDal : EfEntitiyRepositoryBase<Car, RentaCarContext>, IColorDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentaCarContext context = new RentaCarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.Id equals b.BrandId
                             select new CarDetailDto
                             {
                                  
                                 CarId = c.Id,
                                 BrandName = b.BrandName,
                                 Description = c.Description,
                                 DailyPrice = c.DailyPrice,
                                 CarName = c.CarName,
                             };
                return result.ToList();

            }
        }
    }
}
