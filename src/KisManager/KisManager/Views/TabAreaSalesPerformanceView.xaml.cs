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

namespace KisManager.Views
{
    /// <summary>
    /// Interaction logic for TabAreaSalesPerformanceView.xaml
    /// </summary>
    public partial class TabAreaSalesPerformanceView : UserControl
    {
        public TabAreaSalesPerformanceView()
        {
            InitializeComponent();
        }

        private void C1_Checked(object sender, RoutedEventArgs e)
        {
            G.Items.Refresh();
        }
    }
}
