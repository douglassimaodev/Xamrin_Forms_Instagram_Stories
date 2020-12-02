using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace InstagramStories
{
    public class ItemIndexCalculator : BindableObject, IValueConverter
    {
        public IEnumerable<object> ItemsSource
        {
            get { return (IEnumerable<object>)GetValue(ItemsSourceProperty); }
            set
            {
                SetValue(ItemsSourceProperty, value);
            }
        }

        public static readonly BindableProperty ItemsSourceProperty = BindableProperty.Create(nameof(ItemsSource), typeof(IEnumerable<object>), typeof(ItemIndexCalculator), null, BindingMode.Default);


        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (ItemsSource != null && value != null)
            {
                var index = ItemsSource.Select((itemValue, itemIndex) => new { itemValue, itemIndex }).First(item => item.itemValue == value).itemIndex;
                return index + 1;
            }

            return 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
