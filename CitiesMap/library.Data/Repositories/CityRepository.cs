using city.Core.Entities;
using city.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace city.Data.Repositories
{
    public class CityRepository: ICityRepository
    {
        private readonly DataContext _context;

        public CityRepository (DataContext context)
        {
            _context = context;
        }

        
        public IEnumerable<City> GetAll()
        {
            return _context.CitiesList.ToList();
        }
        public City GetCity(string name)
        {
            return _context.CitiesList.Find(name);
        }

        public IEnumerable<City> GetCities(string name)
        {
            return _context.CitiesList.Where(c => c.name.Contains(name)).ToList();
        }

        public void DeleteCity(string name)
        {
            var city = GetCity(name);
            _context.Remove(city);
            _context.SaveChanges();
        }

        public City UpdateCity(string name,City newName)
        {

            DeleteCity(name);
            AddCity(newName);
            _context.SaveChanges();
            return newName;
        }

        public City AddCity(City name)
        {
            var city = GetCity(name.name);
            if (city != null)
                return null;
            _context.Add(name);
            _context.SaveChanges();
            return city;

        }

    }
}
