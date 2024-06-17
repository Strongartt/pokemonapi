using System.Security.Cryptography.X509Certificates;

namespace pokeapirp.Models
{
    public class ListaPokemons()
    {

        public int count { get; set; }
        public string next { get; set; }

        public string previuos { get; set; }
        public List<PokemosItem> results { get; set; }


    }
}
