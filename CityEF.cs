using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEFrelatiesDonderdag
{
    public class CityEF
    {
        public int Id { get; set; }
        public int? Population {  get; set; }
        public bool IsCapital { get; set; }
        List<CityNameEF> Names { get; set; }
        //public int? CountryCityId { get; set; }
        //public CountryEF CountryCity { get; set; }
        //public int? CapitalCityId { get; set; }
        //public CountryEF CapitalCity { get;set; }

    }
}
