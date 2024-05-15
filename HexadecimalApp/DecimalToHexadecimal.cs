using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToHexadecimal
{
    public class DecimalToHexadecimalConverter
    {
        public static string Rgb(int r, int g, int b)
        {
            //checks if the argument is out of bounds (0-255) and returns it as whichever its closest to
            int Sanitizer(int any)
            {
                if (any > 255)
                {
                    return 255;
                }
                else if (any < 0)
                {
                    return 0;
                }
                else
                    return any;
            }

            return Sanitizer(r).ToString("X2") + Sanitizer(g).ToString("X2") + Sanitizer(b).ToString("X2");

        }
    }
}
