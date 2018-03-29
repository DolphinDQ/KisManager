using PropertyChanged;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// DataGridMultiColumnsHeader.xaml 的交互逻辑
    /// </summary>
    [AddINotifyPropertyChangedInterface]
    public partial class DataGridMultiColumnsHeader : DataGridColumnHeader
    {
        public DataGridMultiColumnsHeader()
        {
            InitializeComponent();
            DataContext = this;
            SubTitles.CollectionChanged -= SubTitles_CollectionChanged;
            SubTitles.CollectionChanged += SubTitles_CollectionChanged;
        }

        private void SubTitles_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            Colunms = SubTitles.Count;
            SubTitleGrid.Children.Clear();
            foreach (var item in SubTitles)
            {
                SubTitleGrid.Children.Add((UIElement)item);
            }
        }

        public object HeaderTitle { get; set; }

        public ObservableCollection<object> SubTitles { get; set; } = new ObservableCollection<object>();

        public int Colunms { get; set; }

    }
}
