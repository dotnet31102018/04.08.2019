using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace FlightCenter3107
{
    public class VacancyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null || value as string == "")
                return "--";

            int vacancy = (int)value;

            if (vacancy == 0)
            {
                return "FULL";
            }
            if (vacancy <= 30)
            {
                return "ALMOST FULL";
            }

            return "VACANCY";
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}