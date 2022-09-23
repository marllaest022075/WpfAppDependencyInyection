using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppDependencyInyection.UI.Components
{
    /// <summary>
    /// Interaction logic for PassBox.xaml
    /// </summary>
    public partial class PassBox : UserControl
    {

        private bool change;
        public string Pass
        {
            get { return (string)GetValue(PassProperty); }
            set { SetValue(PassProperty, value); }
        }


        // Using a DependencyProperty as the backing store for Pass.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PassProperty =
            DependencyProperty.Register("Pass", typeof(string), typeof(PassBox), new PropertyMetadata(String.Empty, PassPropertyChanged));

        public static void  PassPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs args) 
        { 
            if( d is PassBox passBox)
            {
                passBox.UpdatePass();
            }
        }

        private void UpdatePass()
        {
            if(!change)
            Password.Password = Pass;
        }

        public PassBox()
        {
            InitializeComponent();
        }

        private void Password_PasswordChanged(object sender, RoutedEventArgs e)
        {
            change = true;
            Pass = Password.Password;
            change = false;
        }
    }
}
