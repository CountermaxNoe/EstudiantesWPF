using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace EstudiantesWPF.ViewModels
{
    public class NavigationViewModel : INotifyPropertyChanged
    {
        public static UserControl? View {  get; set; }
        public static void Navegate(string nombre)
        {
            var view=(UserControl)Application.Current.Resources.FindName(nombre);
            View=view;
            Actualizar(nameof(view));
        }
        public static void Actualizar(string? nombre = null)
        {
            PropertyChanged?.Invoke(this, new(nombre));
        }
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
