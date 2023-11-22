using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDICALCLINIC.Services.Utils
{
    public static class ConverterExtentions
    {
        public static int ToInt(this string str)
        {
            return int.Parse(str);
        }
        public static Decimal ToDecimal(this string str)
        {
            return Decimal.Parse(str);
        }
        public static Double ToDouble(this string str)
        {
            return Double.Parse(str);
        }
    }
}
