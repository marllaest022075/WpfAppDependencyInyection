using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfAppDependencyInyection.UI.Helpers;

namespace WpfAppDependencyInyection.UI.ViewModels
{
    public class MainViewModel : BaseViewModel
    {

        private string title;
        private LoginViewModel _loginContext;


        public string Title { get => title; set => SetProperty(ref title, value); }
        public LoginViewModel LoginContext { get => _loginContext; set => SetProperty(ref _loginContext, value); }

        public MainViewModel(LoginViewModel  loginViewModel)
        {
            title = "Desde ViewModel";
            _loginContext = loginViewModel;
            VistasHelper.LoadNewSize += VistasHelper_LoadNewSize;
            _loginContext.ShowLogin = Visibility.Visible;
            
        }

        private void VistasHelper_LoadNewSize(int width, int height)
        {
            Width = width;
            Heigth = height;
        }
    }
}
