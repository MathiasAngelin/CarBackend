using CarProgram.Context;
using CarProgram.Models.Repository;

namespace CarProgram.Models.DataManager
{
    public class CarManager : IDataRepository<Car>
    {
        readonly CarContext _carContext;

        public CarManager(CarContext carContext)
        {
            _carContext = carContext;
        }

        public void Add(Car entity)
        {
           _carContext.Cars.Add(entity);
           _carContext.SaveChanges();
        }

        public void Delete(Car entity)
        {
           _carContext.Remove(entity);
           _carContext.SaveChanges();
        }

        public IEnumerable<Car> GetAll()
        {
            return _carContext.Cars.ToList();
        }

        public Car GetById(int id)
        {
            return _carContext.Cars.FirstOrDefault(c => c.VIN == id);
        }

        public void Update(Car car, CarModel entity)
        {
           car.LicesePlateNumber = entity.LicesePlateNumber;
           car.Model = entity.Model;
            _carContext.SaveChanges();
           
        }
    }
}
