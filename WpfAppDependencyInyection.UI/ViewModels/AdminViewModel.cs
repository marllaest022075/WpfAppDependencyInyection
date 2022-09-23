using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfAppDependencyInyection.UI.Helpers;

namespace WpfAppDependencyInyection.UI.ViewModels
{
    public class AdminViewModel : BaseComponentVM
    {

        private string _mensage;

        public string Mensage { get => _mensage; set => SetProperty(ref _mensage, value); }

        public AdminViewModel()
        {
            Width = 950;
            Heigth = 550;
            _mensage = "Administrador";
            ShowIt = Visibility.Visible;
        }

    }
}
