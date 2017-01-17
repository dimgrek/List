using System;
using System.Globalization;
using MvvmCross.Platform.Converters;
using MvvmCross.Platform.UI;

namespace List.Converters
{
    public class BoolToVisibilityConverter : MvxValueConverter<bool, MvxVisibility>
    {
        protected override MvxVisibility Convert(bool value, Type targetType, object parameter, CultureInfo culture)
        {
            return !value ? MvxVisibility.Visible : MvxVisibility.Collapsed;
        }
    }
}