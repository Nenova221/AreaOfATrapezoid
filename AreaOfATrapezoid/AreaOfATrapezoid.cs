using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfATrapezoid
{
    public class AreaOfATrapezoid
    {
        public static int CalculateArea(int a, int b, int h)
        {
            int area = (a + b) / 2 * h;
            return area;
        }
    }
}
