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
using System.Windows.Shapes;

namespace _17_ListViewExtended
{
    /// <summary>
    /// Interaction logic for SortingEx.xaml
    /// </summary>
    public partial class SortingEx : Window
    {
        public SortingEx()
        {
            InitializeComponent();

            List<User1> items = new List<User1>();
            items.Add(new User1() { Name = "John Doe", Age = 42 });
            items.Add(new User1() { Name = "Jane Doe", Age = 39 });
            items.Add(new User1() { Name = "Sammy Doe", Age = 13 });
            items.Add(new User1() { Name = "Donna Doe", Age = 13 });
            lvUsers.ItemsSource = items;

            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lvUsers.ItemsSource);
            view.SortDescriptions.Add(new SortDescription("Age", ListSortDirection.Ascending));
            //view.SortDescriptions.Add(new SortDescription("Name", ListSortDirection.Ascending));
        }
    }

    public class User1
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }
}
