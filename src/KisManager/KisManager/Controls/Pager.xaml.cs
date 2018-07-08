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

namespace KisManager.Controls
{
    /// <summary>
    /// Pager.xaml 的交互逻辑
    /// </summary>
    [PropertyChanged.AddINotifyPropertyChangedInterface]
    public partial class Pager : UserControl
    {
        public event EventHandler ReloadPage;

        public Pager()
        {
            InitializeComponent();
            Container.DataContext = this;
        }

        public int Page
        {
            get { return (int)GetValue(PageProperty); }
            set { SetValue(PageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Page.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PageProperty =
            DependencyProperty.Register("Page", typeof(int), typeof(Pager), new PropertyMetadata(0, new PropertyChangedCallback(OnPageChanged)));

        private static void OnPageChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Pager pager)
            {
                pager.ReloadPage?.Invoke(pager, System.EventArgs.Empty);
            }
        }

        public int TotalPage
        {
            get { return (int)GetValue(TotalPageProperty); }
            private set { SetValue(TotalPageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TotalPage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TotalPageProperty =
            DependencyProperty.Register("TotalPage", typeof(int), typeof(Pager), new PropertyMetadata(0));



        public int Total
        {
            get { return (int)GetValue(TotalProperty); }
            set { SetValue(TotalProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Total.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TotalProperty =
            DependencyProperty.Register("Total", typeof(int), typeof(Pager), new PropertyMetadata(0, new PropertyChangedCallback(OnTotalChanged)));

        private static void OnTotalChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Pager pager)
            {
                pager.OnTotalChaned();
            }
        }

        private void OnTotalChaned()
        {
            var total = Total;
            var size = Size;
            if (size != 0)
            {
                var pages = (double)total / size;
                int result = (int)pages;
                if (pages > (int)pages)
                {
                    result++;
                }
                TotalPage = result;
            }
        }

        public int Size
        {
            get { return (int)GetValue(SizeProperty); }
            set { SetValue(SizeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Size.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SizeProperty =
            DependencyProperty.Register("Size", typeof(int), typeof(Pager), new PropertyMetadata(0));

        private void ToFirst_Click(object sender, RoutedEventArgs e)
        {
            Page = 0;
        }

        private void Previous_Click(object sender, RoutedEventArgs e)
        {
            if (Page > 0)
            {
                Page--;
            }
        }

        private void Reload_Click(object sender, RoutedEventArgs e)
        {
            ReloadPage?.Invoke(sender, e);
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            if (Page < TotalPage - 1)
            {
                Page++;
            }
        }

        private void ToLast_Click(object sender, RoutedEventArgs e)
        {
            Page = TotalPage - 1;
        }
    }
}
