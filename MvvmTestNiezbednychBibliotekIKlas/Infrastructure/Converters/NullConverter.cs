﻿using System;
using System.Windows.Data;

namespace WarsztatWpf.Infrastructure.Converters
{
    public class NullConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {

            if (value != null && value.ToString() == string.Empty)
            {
                return null;
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }
}
