using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEFrelatiesDonderdag
{
    public class RiverEF
    {
        public int Id { get; set; }
        public string? source { get; set; }
        public List<CountryEF> Countries { get; set; }
        public List<CountryRiverEF> CountryRivers { get; set; }
    }
}
