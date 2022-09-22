using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppDependencyInyection.UI.ViewModels
{
    public class MainViewModel : BaseViewModel
    {

        private string title;

        public string Title { get => title; set => SetProperty(ref title, value); }

        public MainViewModel()
        {
            title = "Desde ViewModel";
        }

    }
}
