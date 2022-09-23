using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfAppDependencyInyection.UI.Helpers;
using WpfAppDependencyInyection.UI.Models;

namespace WpfAppDependencyInyection.UI.ViewModels
{
    public class MainViewModel : BaseViewModel
    {

        private string title;
        private LoginViewModel _loginContext;
        private AdminViewModel _adminContext;
        private User _user;


        public string Title { get => title; set => SetProperty(ref title, value); }
        public LoginViewModel LoginContext { get => _loginContext; set => SetProperty(ref _loginContext, value); }
        public AdminViewModel AdminContext { get => _adminContext; set => SetProperty(ref _adminContext, value); }

        public MainViewModel(LoginViewModel  loginViewModel, AdminViewModel adminContext)
        {
            VistasHelper.LoadNewSize += VistasHelper_LoadNewSize;
            UserHelper.LoadNewUser += UserHelper_LoadNewUser;
            title = "Desde ViewModel";
            _user = new();
            _loginContext = loginViewModel;
            _adminContext = adminContext;
            _loginContext.ShowIt = Visibility.Visible;
            _adminContext.ShowIt = Visibility.Collapsed;
            
        }

        private void UserHelper_LoadNewUser(User user)
        {
            _user = user;
            LoadUserView();
        }

        private void VistasHelper_LoadNewSize(int width, int height)
        {
            Width = width;
            Heigth = height;
        }

        private void LoadUserView()
        {
            switch (_user.Nivel)
            {
                case Constantes.Nivel.Administrador:
                    _loginContext.ShowIt = Visibility.Collapsed;
                    _adminContext.ShowIt = Visibility.Visible;
                    break;
                case Constantes.Nivel.Usuario:
                    break;
                default:
                    break;
            }
        }
        
    }
}
