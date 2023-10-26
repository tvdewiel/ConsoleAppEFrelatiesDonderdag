using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEFrelatiesDonderdag
{
    public class CountryEF
    {
        public int Id { get; set; }
        public int Population { get; set; }
        public int Surface { get; set; }
        //public List<ContinentEF> Continents { get; set; } = new List<ContinentEF>();
        public List<CountryNameEF> Names { get; set; }
        public List<CityEF> Cities { get; set; }
        //public List<CityEF> Capitals { get; set; }
        public List<CapitalEF> Capitals { get; set; }
        public List<RiverEF> Rivers { get; set; }
    }
}
