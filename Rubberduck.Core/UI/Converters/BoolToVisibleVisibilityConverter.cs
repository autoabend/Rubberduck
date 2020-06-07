﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Rubberduck.UI.Converters
{
    public class BoolToVisibleVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var typedValue = (bool)value;
            return typedValue ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var typedValue = (Visibility)value;
            return typedValue != Visibility.Collapsed;
        }
    }
}
