using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Globalization;
namespace Week5
{
    class CreditsToPercentageConverter : IMultiValueConverter
    {
        //current/max -> a%
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            int currentCredits = (int)values[0];
            int maxCredits = (int)values[1];

            float percent = (float)( (currentCredits * 1.0) / maxCredits);

            return $"{percent: 0.00} %"; // decimal 
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
