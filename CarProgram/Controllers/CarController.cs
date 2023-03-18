using CarProgram.Models;
using CarProgram.Models.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarProgram.Controllers
{
    [Route("api/cars")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly IDataRepository<Car> _dataRepository;

        public CarController(IDataRepository<Car> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            IEnumerable<Car> carModels = _dataRepository.GetAll();
            return Ok(carModels);
        }

        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            Car car = _dataRepository.GetById(id);
            if (car == null)
            {
                return NotFound("Car does not exist");
            }
            return Ok(car);
        }

        [HttpPost]
        public IActionResult Post([FromBody] CarModel car)
        {
            if (car == null)
            {
                return BadRequest("Car is null");
            }
            _dataRepository.Add(new Car
            {
             Model = car.Model,
             LicesePlateNumber = car.LicesePlateNumber,
            });
            return Ok("Created");
        }

        [HttpPut("id")]
        public IActionResult Put(int id, [FromBody] CarModel carModel) 
        { 
            if (carModel == null)
            {
                return BadRequest("Car is null");
            }

            Car carToUpdate = _dataRepository.GetById(id);
            if(carToUpdate == null)
            {
                return BadRequest("The Car couldn't be found");
            }
            carToUpdate.Model = carModel.Model;
            carToUpdate.LicesePlateNumber = carModel.LicesePlateNumber;
            _dataRepository.Update(carToUpdate, carModel);
            return Ok("Car updated");
        }

        [HttpDelete("id")]
        public IActionResult Delete(int id)
        {
            Car car = _dataRepository.GetById(id);
            if( car == null )
            {
                return NotFound("The car couldn't be found");
            }
            _dataRepository.Delete(car);
            return Ok("Car deleted");
        }

    }
}
