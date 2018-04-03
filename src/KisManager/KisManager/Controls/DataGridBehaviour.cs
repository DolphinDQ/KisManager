using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Interactivity;

namespace KisManager.Controls
{
    public class DataGridBehaviour : Behavior<DataGrid>
    {

        protected override void OnAttached()
        {
            base.OnAttached();
            AssociatedObject.LoadingRow += AssociatedObject_LoadingRow;
        }
        protected override void OnDetaching()
        {
            base.OnDetaching();
            AssociatedObject.LoadingRow -= AssociatedObject_LoadingRow;
        }

        private void AssociatedObject_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = (e.Row.GetIndex() + 1).ToString();
        }
    }
}
