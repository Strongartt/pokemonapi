<<<<<<< HEAD
﻿using pokeapirp.Models;
using pokeapirp.Services;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace pokeapirp
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        private List<PokemosItem> _listado_pokemones;

        public List<PokemosItem> listado_pokemones
        {
            get { return _listado_pokemones; }
            set
            {
                _listado_pokemones = value;
                OnPropertyChanged();
            }
        }
=======
﻿namespace pokeapirp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
>>>>>>> c3c03b5ca879b47539badb6ae365c12694b07382

        public MainPage()
        {
            InitializeComponent();
<<<<<<< HEAD
            BindingContext = this;
            CargarData();
        }

        public async void CargarData()
        {
            PokemonServices poke_services = new PokemonServices();
            listado_pokemones = await poke_services.DevuelveListadoPokemones();

            Debug.WriteLine("");
            Debug.WriteLine(JsonConvert.SerializeObject(listado_pokemones));
        }

        public void VerInfoPokemon(object sender, SelectedItemChangedEventArgs e)
        {
            PokemosItem poke_info = (PokemosItem)e.SelectedItem;
            Navigation.PushAsync(new ResumenPokemon(poke_info.url));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
=======
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

>>>>>>> c3c03b5ca879b47539badb6ae365c12694b07382
}
