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

namespace _17_ListViewExtended
{
    /// <summary>
    /// Interaction logic for ColumnSorting.xaml
    /// </summary>
    public partial class ColumnSorting : Window
    {
        private GridViewColumnHeader listViewSortCol = null;
        //private SortAdorner listViewSortAdorner = null;

        public ColumnSorting()
        {
            InitializeComponent();
        }
    }
}
