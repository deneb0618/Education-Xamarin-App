﻿using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;
using EducationApp.Models;

namespace EducationApp.WinPhone.Converters
{
    public sealed class SearchStatusSearchingVisibileConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var status = value as SearchStatus? ?? SearchStatus.Inactive;
            return status == SearchStatus.Searching ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}