using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppDependencyInyection.UI.Models;

namespace WpfAppDependencyInyection.UI.Helpers
{
    public class UserHelper
    {
        public delegate void UserChange(User user);

        public static event UserChange? LoadNewUser;

        public static void ChangeViewUser(User user)
        {
            LoadNewUser?.Invoke(user);

        }
    }
}
