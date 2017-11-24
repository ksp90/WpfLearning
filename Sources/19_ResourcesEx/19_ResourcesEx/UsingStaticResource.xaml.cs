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
using System.Windows.Shapes;

namespace _19_ResourcesEx
{
    /// <summary>
    /// Interaction logic for UsingStaticResource.xaml
    /// </summary>
    public partial class UsingStaticResource : Window
    {
        public UsingStaticResource()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["BackgroundColor"] = new SolidColorBrush(Colors.Red);
        }
    }
}
