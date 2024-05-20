using EstudiantesWPF.Models;
using EstudiantesWPF.Repositories;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EstudiantesWPF.ViewModels
{
    public class EstudiantesViewModel : INotifyPropertyChanged
    {

        public ObservableCollection<Alumnos> Alumnos { get; set; } = new();
        private AlumnosRepositorie repositorie = new();
        public Alumnos? Alumno { get; set; }
        public ICommand AgregarCommand { get; set; }
        public ICommand MostrarAgregarCommand { get; set; }
        public ICommand CancelarCommand { get; set; }
        EstudiantesViewModel()
        {
            MostrarDatos();
            CancelarCommand = new RelayCommand(Cancelar);
            AgregarCommand = new RelayCommand(Agregar);
            MostrarAgregarCommand= new RelayCommand(MostrarAgregar);
        }

        private void MostrarAgregar()
        {
            throw new NotImplementedException();
        }

        private void Agregar()
        {
            throw new NotImplementedException();
        }

        private void Cancelar()
        {
            throw new NotImplementedException();
        }

        public void MostrarDatos()
        {
            var datos = repositorie.GetAll();
            foreach (var item in datos)
            {
                Alumnos.Add(item);
            }
        }
        public void Actualizar(string? nombre=null)
        {
            PropertyChanged?.Invoke(this, new(nombre));
        }
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
