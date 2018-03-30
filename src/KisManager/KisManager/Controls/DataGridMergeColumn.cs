using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace KisManager.Controls
{
    class DataGridMergeColumn : DataGridTextColumn
    {
        public DataGridMergeColumn()
        {
            IsReadOnly = true;
            CanUserReorder = false;
            CanUserResize = false;
            //Columns.CollectionChanged += Columns_CollectionChanged;
        }

        //private void Columns_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        //{
        //    LoadHeader();
        //}

        protected override FrameworkElement GenerateElement(DataGridCell cell, object dataItem)
        {
            var ui = base.GenerateElement(cell, dataItem); ;
            if (Columns.Any())
            {
                var panel = new StackPanel();
                panel.Margin = new Thickness(0);
                panel.Orientation = Orientation.Horizontal;
                panel.HorizontalAlignment = HorizontalAlignment.Center;
                foreach (var item in Columns)
                {
                    var i = (DataGridMergeColumn)item;
                    panel.Children.Add(new ContentControl()
                    {
                        Width = i.Width.DisplayValue,
                        Content = i.GenerateElement(cell, dataItem)
                    });
                }
                ui = panel;
            }
            else
            {
                ui = new Label()
                {
                    Content = ui,
                    Background = Background,
                    Padding = new Thickness(0),
                    Margin = new Thickness(0),
                    VerticalContentAlignment = VerticalAlignment.Center,
                    Height = 20,
                    HorizontalContentAlignment= HorizontalAlignment.Right,
                    Visibility=Show
                };
            }
            return ui;
        }

        public object ExHeader
        {
            get { return (object)GetValue(ExHearderProperty); }
            set { SetValue(ExHearderProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ExHearder.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ExHearderProperty =
            DependencyProperty.Register("ExHeader", typeof(object), typeof(DataGridMergeColumn), new PropertyMetadata(null, new PropertyChangedCallback(OnExHanderChanged)));

        private static void OnExHanderChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DataGridMergeColumn col)
            {
                col.LoadHeader();
            }
        }

        public Brush Background
        {
            get { return (Brush)GetValue(BackgroundProperty); }
            set { SetValue(BackgroundProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Background.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BackgroundProperty =
            DependencyProperty.Register("Background", typeof(Brush), typeof(DataGridMergeColumn), new PropertyMetadata(Brushes.Transparent));


        public Visibility Show
        {
            get { return (Visibility)GetValue(ShowProperty); }
            set { SetValue(ShowProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Show.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ShowProperty =
            DependencyProperty.Register("Show", typeof(Visibility), typeof(DataGridMergeColumn), new PropertyMetadata(Visibility.Visible));


        public ObservableCollection<DataGridTextColumn> Columns { get; set; }
            = new ObservableCollection<DataGridTextColumn>();

        private void LoadHeader()
        {
            //var header = (StackPanel)Header;
            //if (header == null)
            //{
            //    header = new StackPanel();
            //}
            //header.Children.Clear();
            //header.Children.Add(CreateElement(ExHeader));
            //var children = new StackPanel();
            //children.Orientation = Orientation.Horizontal;
            //foreach (var item in Columns)
            //{
            //    children.Children.Add(CreateElement(item.Header));
            //}
            //header.Children.Add(children);
            //Header = header;
            Header = this;
        }

        //private UIElement CreateElement(object content)
        //{
        //    return new Label()
        //    {
        //        Content = content,
        //        HorizontalAlignment = HorizontalAlignment.Center,
        //        HorizontalContentAlignment = HorizontalAlignment.Center,
        //        BorderBrush = Brushes.Gray,
        //        BorderThickness = new Thickness(1)
        //    };
        //}
    }
}
