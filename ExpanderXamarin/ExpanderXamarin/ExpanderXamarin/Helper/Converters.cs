using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace ExpanderXamarin
{
    #region ExpanderIconConverter
    public class ExpanderIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool)value)
                return ImageSource.FromResource("ExpanderXamarin.Images.down.png");
            else
                return ImageSource.FromResource("ExpanderXamarin.Images.up.png");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region SeperatorVisibilityConverter
    public class SeperatorVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if((string)parameter == "Header")
            {
                return (bool)value ? false : true;
            }
            else
                return (bool)value ? true : false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    #endregion
}
