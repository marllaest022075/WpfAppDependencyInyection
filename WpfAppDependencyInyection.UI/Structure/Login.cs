using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppDependencyInyection.UI.Constantes;
using WpfAppDependencyInyection.UI.Interfaces;
using WpfAppDependencyInyection.UI.Models;

namespace WpfAppDependencyInyection.UI.Structure
{
    public class Login : ILogin
    {
        private List<User> _users;

        public Login()
        {
            _users = new();
            _users.Add(new() { Id = 1, Username = "Martin", Password = "123", Nivel = Nivel.Administrador });
            _users.Add(new() { Id = 2, Username = "Amanda", Password = "456", Nivel = Nivel.Usuario });
            _users.Add(new() { Id = 1, Username = "Adan", Password = "789", Nivel = Nivel.Usuario });
        }
        public User IsLoggedIn(string userName, string password)
        {
            var res = _users.FirstOrDefault(x=> x.Username.Equals(userName) && x.Password.Equals(password));
            return res;
        }
    }
}
