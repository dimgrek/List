using System;
using MvvmCross.Platform.Converters;

namespace List
{
	public class InvertedBooleanConverter : MvxValueConverter<bool, bool>
	{
		protected override bool Convert(bool value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			return !value;
		}

	}
}
