﻿using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace DemoApp.Shared
{
    public class Framework
    {
        public Framework(string name, string version, int year)
        {
            Name = name;
            Version = version;
            Year = year;
        }

        public string Name { get; }

        public string Version { get; }

        public int Year { get; }
    }

    public class BooleanToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is bool b) return b ? Visibility.Visible : Visibility.Collapsed;
            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return default;
        }
    }
}