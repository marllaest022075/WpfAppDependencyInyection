using System;
using System.Windows;
using System.Windows.Input;
using WpfAppDependencyInyection.UI.Helpers;
using WpfAppDependencyInyection.UI.Interfaces;
using WpfAppDependencyInyection.UI.Models;

namespace WpfAppDependencyInyection.UI.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string _userName;
        private string _password;
        private Visibility _hasUser;
        private Visibility _hasPass;
        private Visibility showLogin;

        private User _user;

        private readonly ILogin _login;

        private RelayCommand loginCommand;
        public string UserName
        { get => _userName; set { SetProperty(ref _userName, value); HasUser = String.IsNullOrEmpty(_userName) ? Visibility.Visible : Visibility.Hidden; } }

        public string Password
        { get => _password; set { SetProperty(ref _password, value); HasPass = String.IsNullOrEmpty(_password) ? Visibility.Visible : Visibility.Hidden; } }

        public Visibility HasUser { get => _hasUser; set => SetProperty(ref _hasUser, value); }
        public Visibility HasPass { get => _hasPass; set => SetProperty(ref _hasPass, value); }
        public Visibility ShowLogin
        { get => showLogin; set { SetProperty(ref showLogin, value); VistasHelper.ChangeViewSize(Width, Heigth); } }

        public ICommand LoginCommand => loginCommand;
        public LoginViewModel(ILogin login)
        {
            _userName = "";
            _password = "";
            _hasUser = Visibility.Visible;
            _hasPass = Visibility.Visible;
            Width = 250;
            Heigth = 450;
            _login = login;
            _user = new();
            loginCommand ??= new RelayCommand(Login);
        }


        private void Login(object commandParameter)
        {
            _user = _login.IsLoggedIn(UserName, Password);
            if(_user == null)
            {
                UserName = string.Empty;
                Password = string.Empty;
                return;
            }
            UserHelper.ChangeViewUser(_user);
        }
    }
}