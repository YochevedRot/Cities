using city.Core.Entities;
using city.Core.Repositories;
using city.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace city.Service
{
    public class CityService: ICityService
    {
        private readonly ICityRepository _cityRepository;
        public CityService(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }
        public IEnumerable<City> GetAll()
        {
            return _cityRepository.GetAll();
        }
        public City GetCity(string name)
        {
            return _cityRepository.GetCity(name);
        }

        public IEnumerable<City> GetMatch(string name)
        {
            return _cityRepository.GetCities(name);
        }

        public void DeleteCity(string name)
        {
            _cityRepository.DeleteCity(name);
        }

        public City UpdateCity(string name, City newName)
        {
            return _cityRepository.UpdateCity(name, newName);
        }
        public City AddCity(City name)
        {
            return _cityRepository.AddCity(name);
        }
    }
}
