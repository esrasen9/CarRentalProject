using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, MyDbContext>, IRentalDal
    {
        public List<CarRentalDetailDto> GetRentalDetails()
        {
            using (MyDbContext context = new MyDbContext())
            {
                var result = from rental in context.Rentals
                             join car in context.Cars on rental.CarId equals car.CarId
                             join brand in context.Brands on car.BrandId equals brand.BrandId
                             select new CarRentalDetailDto()
                             {
                                 CarId = car.CarId,
                                 DailyPrice = car.DailyPrice,
                                 CarName = car.CarName,
                                 BrandName = brand.BrandName,
                                 RentDate = rental.RentDate,
                                 ReturnDate = rental.ReturnDate
                             };
                return result.ToList();
            }
        }

        public void UpdateReturnDate(Rental rental)
        {
            throw new NotImplementedException();
        }
    }
}
