using CommunityToolkit.Mvvm.ComponentModel;
using Superheroes.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommunityToolkit.Mvvm.ComponentModel;
using Superheroes.Services;
using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;
using Superheroes.Services;
using System.Collections.ObjectModel;

namespace Superheroes
{
    public class MainWindowViewModel : ObservableObject
    {
        public ObservableCollection<Superheroe> Superheroes { get; }

        private Superheroe _superheroeActual;
        public Superheroe SuperheroeActual
        {
            get => _superheroeActual;
            set => SetProperty(ref _superheroeActual, value);
        }

        private int _indiceActual = 0;

        public MainWindowViewModel()
        {
            var lista = DataService.GetSamples();
            Superheroes = new ObservableCollection<Superheroe>(lista);

            if (Superheroes.Count > 0)
                SuperheroeActual = Superheroes[0];
        }

        public void Siguiente()
        {
            if (Superheroes.Count == 0) return;
            _indiceActual = (_indiceActual + 1) % Superheroes.Count;
            SuperheroeActual = Superheroes[_indiceActual];
        }

        public void Anterior()
        {
            if (Superheroes.Count == 0) return;
            _indiceActual = (_indiceActual - 1 + Superheroes.Count) % Superheroes.Count;
            SuperheroeActual = Superheroes[_indiceActual];
        }
    }
}

