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

namespace _05_UserControlCustomControl
{
    /// <summary>
    /// Interaction logic for UsingCustomControl.xaml
    /// </summary>
    public partial class UsingCustomControl : Window
    {
        int count = 0;
        public UsingCustomControl()
        {
            InitializeComponent();
        }

        private void customControl_Click(object sender, RoutedEventArgs e)
        {
            txtBlock.Text = $"You have just click your custom control {++count} times";
        }
    }
}