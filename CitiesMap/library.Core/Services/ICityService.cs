using city.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace city.Core.Services
{
    public interface ICityService
    {
        IEnumerable<City> GetAll();
        City GetCity(string name);
        IEnumerable<City> GetMatch(string name);
        void DeleteCity(string name);
        City UpdateCity(string name, City newName);
        City AddCity(City name);
    }

}
