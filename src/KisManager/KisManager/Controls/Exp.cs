using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace KisManager.Controls
{
    /// <summary>
    /// 拓展属性。
    /// </summary>
    public static class Exp
    {
        public static IObservable<object> GetContent(DependencyObject obj)
        {
            return (IObservable<object>)obj.GetValue(ContentProperty);
        }

        public static void SetContent(DependencyObject obj, IObservable<object> value)
        {
            obj.SetValue(ContentProperty, value);
        }

        // Using a DependencyProperty as the backing store for Content.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ContentProperty =
            DependencyProperty.RegisterAttached("Content", typeof(IObservable<object>), typeof(Exp), new PropertyMetadata(0));





    }
}
