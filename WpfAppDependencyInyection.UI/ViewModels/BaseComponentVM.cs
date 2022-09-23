using System.Windows;
using WpfAppDependencyInyection.UI.Helpers;

namespace WpfAppDependencyInyection.UI.ViewModels
{
    public class BaseComponentVM : BaseViewModel
    {
        private Visibility showIt;

        public Visibility ShowIt
        {
            get => showIt;
            set
            {
                SetProperty(ref showIt, value);
                if (showIt == Visibility.Visible)
                    VistasHelper.ChangeViewSize(Width, Heigth);
            }
        }
    }
}