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
        private User _user;


        public string Title { get => title; set => SetProperty(ref title, value); }
        public LoginViewModel LoginContext { get => _loginContext; set => SetProperty(ref _loginContext, value); }

        public MainViewModel(LoginViewModel  loginViewModel)
        {
            VistasHelper.LoadNewSize += VistasHelper_LoadNewSize;
            UserHelper.LoadNewUser += UserHelper_LoadNewUser;
            title = "Desde ViewModel";
            _user = new();
            _loginContext = loginViewModel;
            _loginContext.ShowLogin = Visibility.Visible;
            
        }

        private void UserHelper_LoadNewUser(User user)
        {
            _user = user;
        }

        private void VistasHelper_LoadNewSize(int width, int height)
        {
            Width = width;
            Heigth = height;
        }
        
    }
}
