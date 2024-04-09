using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace city.Core.Entities
{

    public class City
    {
        [Key]
        public string name { get; set; }
    }
}
