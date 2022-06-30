using Core.EntitiyFramework;
using DataAccess.Abstract;
using System;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : EfEntityRepositoryBase<Color , RentaCarContext>, IColorDal
    {
    }
}
