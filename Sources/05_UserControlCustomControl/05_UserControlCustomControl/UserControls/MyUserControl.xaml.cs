﻿using System;
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

namespace _05_UserControlCustomControl
{
    /// <summary>
    /// Interaction logic for MyUserControl.xaml
    /// </summary>
    public partial class MyUserControl : UserControl
    {
        int count = 0;
        public MyUserControl()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            count++;
            txtBox.Text = $"You have just clicked the button {count} times";
        }
    }
}
