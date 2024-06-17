using pokeapirp.Models;
using pokeapirp.Services;
namespace pokeapirp;


public partial class ResumenPokemon : ContentPage
{
    PokemonInfo caracteristicas = new PokemonInfo();
    public ResumenPokemon(string url)
    {
        InitializeComponent();
        CargaPokemon(url);
    }

    public async void CargaPokemon(string url)
    {
        PokemonServices poke_services = new PokemonServices();
        caracteristicas = await poke_services.DevuelveCaracteristicasPokemon(url);
        ImagePokemon.Source = caracteristicas.sprites.front_default;

        string habilidades = "";
        foreach (var ability in caracteristicas.Abilities)
        {

            habilidades += ability.ability.name + " | ";
        }

        Habilidades.Text = habilidades;

    }
}