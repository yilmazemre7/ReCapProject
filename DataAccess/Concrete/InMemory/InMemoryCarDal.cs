using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> { new Car { Id = 1, BrandId = 1, DailyPrice = 2, ColorId = 5, Description = "Audi", ModelYear = 1998 } };
        }

        public void Add(Car entity)
        {
            _cars.Add(entity);
        }

        public void Delete(Car entity)
        {
            var deletedCar = _cars.SingleOrDefault(c => c.Id == entity.Id);
            _cars.Remove(deletedCar);

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

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(c=>c.Id==id);
        }

        public void Update(Car entity)
        {
            var updatedEntity = _cars.SingleOrDefault(c => c.Id == entity.Id);
            updatedEntity.Id = entity.Id;
            updatedEntity.BrandId = entity.BrandId;
            updatedEntity.ColorId = entity.ColorId;
            updatedEntity.DailyPrice = entity.DailyPrice;
            updatedEntity.Description = entity.Description;
        }
    }
}
