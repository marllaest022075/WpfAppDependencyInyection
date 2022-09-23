
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfAppDependencyInyection.UI.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected bool SetProperty<T>(ref T field, T newValue, [CallerMemberName] string propertyName = "")
        {
            if(Equals(field, newValue)) return false;
            field = newValue;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            return true;
        }
        private int _width;

        public int Width
        {
            get { return _width; }
            set { SetProperty(ref _width , value); }
        }
        private int _heigth;

        public int Heigth
        {
            get { return _heigth; }
            set { _heigth = value; }
        }


    }
}
