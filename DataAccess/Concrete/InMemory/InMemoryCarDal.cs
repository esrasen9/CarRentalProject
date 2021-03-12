using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car(){CarId=1,ColorId=10,BrandId=1,ModelYear=2014,DailyPrice=20000,Description="Son Model" },
                new Car(){CarId=2,ColorId=10,BrandId=2,ModelYear=2015,DailyPrice=25000,Description="Hasarli" },
                new Car(){CarId=3,ColorId=12,BrandId=1,ModelYear=2019,DailyPrice=29000,Description="Son Model" },
                new Car(){CarId=4,ColorId=14,BrandId=4,ModelYear=2018,DailyPrice=30000,Description="Sifir" }
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            var carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
        }


        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            var carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            car.BrandId = carToUpdate.BrandId;
            car.ColorId = carToUpdate.ColorId;
            car.ModelYear = carToUpdate.ModelYear;
            car.DailyPrice = carToUpdate.DailyPrice;
            car.Description = carToUpdate.Description;
        }
    }
}
