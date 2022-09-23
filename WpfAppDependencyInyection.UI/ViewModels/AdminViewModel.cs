using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfAppDependencyInyection.UI.Helpers;
using WpfAppDependencyInyection.UI.ViewModels;

namespace WpfAppDependencyInyection.UI.ViewModels
{
    public class AdminViewModel : BaseComponentVM
    {

        private string _mensage;
        private Visibility _isAdmin;
        private readonly RelayCommand _selectionCommand;

        public string Mensage { get => _mensage; set => SetProperty(ref _mensage, value); }
        public ICommand SelectionCommand => _selectionCommand;
        public Visibility IsAdmin { get => _isAdmin; set => SetProperty(ref _isAdmin, value); }


        public AdminViewModel()
        {
            Width = 950;
            Heigth = 550;
            _mensage = "Administrador";
            _isAdmin = Visibility.Visible;
            _selectionCommand = new RelayCommand(Selection);
        }


        private void Selection(object commandParameter)
        {
            var cad = (String)commandParameter;            
        }


    }
}
