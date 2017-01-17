using System.Globalization;
using MvvmCross.Platform.UI;
using MvvmCross.Plugins.Color;

namespace List.Converters
{
    public class PriorityToColorValueConverter : MvxColorValueConverter
    {
        private readonly MvxColor LowColor = new MvxColor(121, 196, 69);
        private readonly MvxColor MediumColor = new MvxColor(247, 148, 22);
        private readonly MvxColor TopColor = new MvxColor(255, 0, 0);
        private readonly MvxColor WhiteColor = new MvxColor(255, 255, 255);

        protected override MvxColor Convert(object value, object parameter, CultureInfo culture)
        {
            var priority = (Priority) value;
            switch (priority)
            {
                case Priority.Low:
                    return LowColor;
                case Priority.Medium:
                    return MediumColor;
                case Priority.Top:
                    return TopColor;
                default:
                    return WhiteColor;
            }
        }
    }
}