using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClazyDesktop.Themes.Attached
{
    public static class CornerRadiusHelper
    {
        public static readonly DependencyProperty ValueProperty = DependencyProperty.RegisterAttached("Value", typeof(CornerRadius), typeof(CornerRadiusHelper), new PropertyMetadata(new CornerRadius(0)));

        public static void SetValue(DependencyObject element, CornerRadius value) => element.SetValue(ValueProperty, value);

        public static CornerRadius GetValue(DependencyObject element) => (CornerRadius)element.GetValue(ValueProperty);
    }
}
