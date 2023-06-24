using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.DailyPrice > 0 && car.Description.Length >= 2)
                _carDal.Add(car);

            else
            {
                Console.WriteLine("Ürün eklemesi başarısız {0}",car.Description);
            } }

        public void Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {

            Console.WriteLine("TUM ARACLAR LİSTELENİYOR ....");
            return _carDal.GetAll();
        }

        public Car GetById(int id)
        {
            Console.WriteLine("ISTEGINIZE GORE ARAC GETİRİLDİ.");
            return _carDal.Get(c => c.Id == id);

        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
