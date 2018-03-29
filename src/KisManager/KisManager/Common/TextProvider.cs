using KisManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace KisManager.Common
{
    class TextProvider : FrameworkElement, ITextProvider
    {
        public string GetText(string key)
        {
            return (string)FindResource(key);
        }
    }
}
