using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppDependencyInyection.UI.Models;

namespace WpfAppDependencyInyection.UI.Interfaces
{
    public interface ILogin
    {
        User IsLoggedIn(string userName, string password);
    }
}
