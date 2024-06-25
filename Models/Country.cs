using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace revisandoApis.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<PokemonOwner> PokemonOwners { get; set; }
    }
}