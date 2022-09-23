using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppDependencyInyection.UI.Constantes;

namespace WpfAppDependencyInyection.UI.Models
{
    public class User : BaseModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Nivel Nivel { get; set; }
    }
}
