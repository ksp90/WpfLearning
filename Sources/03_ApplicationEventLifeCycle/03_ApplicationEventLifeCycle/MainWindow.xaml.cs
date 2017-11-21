using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace _03_ApplicationEventLifeCycle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DebugUtilityLog.Log();
            InitializeComponent();
        }

        protected override void OnInitialized(EventArgs e)
        {
            DebugUtilityLog.Log();
            base.OnInitialized(e);
        }

        protected override void OnSourceInitialized(EventArgs e)
        {
            DebugUtilityLog.Log();
            base.OnSourceInitialized(e);
        }

        protected override void OnActivated(EventArgs e)
        {
            DebugUtilityLog.Log();
            base.OnActivated(e);
        }

        protected override void OnContentRendered(EventArgs e)
        {
            DebugUtilityLog.Log();
            base.OnContentRendered(e);
        }

        protected override void OnDeactivated(EventArgs e)
        {
            DebugUtilityLog.Log();
            base.OnDeactivated(e);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            DebugUtilityLog.Log();
            base.OnClosing(e);
        }

        protected override void OnClosed(EventArgs e)
        {
            DebugUtilityLog.Log();
            base.OnClosed(e);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DebugUtilityLog.Log();
            throw new ApplicationException("This is a custom generated exception");
        }
    }
}
