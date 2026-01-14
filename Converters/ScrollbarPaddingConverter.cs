using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace YureteruWPF.Converters
{
    public class ScrollbarPaddingConverter : IValueConverter
    {
        // value: System.Windows.Visibility (ComputedVerticalScrollBarVisibility)
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Visibility vis && vis == Visibility.Visible)
            {
                // 右にスクロールバー幅を確保
                return new Thickness(0, 0, SystemParameters.VerticalScrollBarWidth, 0);
            }
            return new Thickness(0);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            => throw new NotSupportedException();
    }
}