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

namespace _09_InputEvent
{
    /// <summary>
    /// Interaction logic for RoutedCommandEx.xaml
    /// </summary>
    public partial class RoutedCommandEx : Window
    {
        public RoutedCommandEx()
        {
            InitializeComponent();
        }

        private void NewExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("You want to create new file.");
        }

        private void CanNew(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void OpenExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("You want to open existing file.");
        }

        private void CanOpen(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void SaveExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("You want to save a file.");
        }
        private void CanSave(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
    }
}