using System;
using System.Windows;

namespace WpfAppDependencyInyection.UI.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string _userName;
        private string _password;
        private Visibility _hasUser;
        private Visibility _hasPass;

        public string UserName
        { get => _userName; set { SetProperty(ref _userName, value); HasUser = String.IsNullOrEmpty(_userName) ? Visibility.Visible : Visibility.Hidden; } }
        public string Password
        { get => _password; set { SetProperty(ref _password, value); HasPass = String.IsNullOrEmpty(_password) ? Visibility.Visible : Visibility.Hidden; } }
        public Visibility HasUser { get => _hasUser; set => SetProperty(ref _hasUser, value); }
        public Visibility HasPass { get => _hasPass; set => SetProperty(ref _hasPass, value); }
        

        public LoginViewModel()
        {
            _userName = "";
            _password = "";
            _hasUser = Visibility.Visible;
            _hasPass = Visibility.Visible;
            Width = 250;
            Heigth = 450;
        }

        private Visibility showLogin;

        public Visibility ShowLogin { get => showLogin; set => SetProperty(ref showLogin, value); }


    }
}