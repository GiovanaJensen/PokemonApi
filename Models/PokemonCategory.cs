using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace revisandoApis.Models
{
    public class PokemonCategory
    {
        public int PokemonId { get; set; }
        public int Category { get; set; }
        public Pokemon Pokemon { get; set; }
        public Category Category { get; set; }
    }
}