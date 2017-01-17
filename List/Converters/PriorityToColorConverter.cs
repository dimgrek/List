using System.Globalization;
using MvvmCross.Platform.UI;
using MvvmCross.Plugins.Color;

namespace List.Converters
{
    public class PriorityToColorValueConverter : MvxColorValueConverter
    {
        protected override MvxColor Convert(object value, object parameter, CultureInfo culture)
        {
            var priority = (Priority) value;
            switch (priority)
            {
                case Priority.Low:
                    return new MvxColor(121, 196, 69);
                case Priority.Medium:
                    return new MvxColor(247, 148, 22);
                case Priority.Top:
                    return new MvxColor(255, 0, 0);
                default:
                    return new MvxColor(255, 255, 255);
                    ;
            }
        }
    }
}