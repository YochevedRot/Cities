using city.Core.Entities;
using city.Core.Services;
using city.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace city.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ICityService _cityService;
        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }

        [HttpGet]
        public IEnumerable<City> Get()
        {
            return _cityService.GetAll();
        }

        // GET api/<CustomerController>/5
        [HttpGet("{name}")]
        public IEnumerable<City> Get(string name)
        {
            return _cityService.GetMatch(name);
        }

        // POST api/<CustomerController>
        [HttpPost ("{name}")]
        public City Post( string name)
        {
            City c = new City();
            c.name = name;
            return _cityService.AddCity(c);
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{name}/newName")]
        public void Put( string name, string Newname)
        {
            City c = new City();
            c.name = Newname;
            _cityService.UpdateCity(name, c);
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{name}")]
        public void Delete(string name)
        {
            _cityService.DeleteCity(name);
        }
    }
}
