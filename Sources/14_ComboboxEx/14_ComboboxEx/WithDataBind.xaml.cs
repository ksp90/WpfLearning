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

namespace _14_ComboboxEx
{
    /// <summary>
    /// Interaction logic for WithDataBind.xaml
    /// </summary>
    public partial class WithDataBind : Window
    {
        public WithDataBind()
        {
            InitializeComponent();

            cmbColors.ItemsSource = typeof(Colors).GetProperties();
        }
    }
}
