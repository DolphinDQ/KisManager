using KisManager.Interfaces;
using MahApps.Metro.Controls;
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

namespace KisManager
{
    /// <summary>
    /// Interaction logic for ShellView.xaml
    /// </summary>
    public partial class ShellView : MetroWindow, IDialogProvider
    {
        public ShellView()
        {
            Tag = this;
            InitializeComponent();
        }

        public Task<object> ShowDialog(IDialogContent content)
        {
            return null;
        }
    }
}
