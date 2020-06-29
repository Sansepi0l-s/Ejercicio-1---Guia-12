using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Leer
    {
        public static short DatoShort()
        {
            try
            {
                return Int16.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                return Int16.MinValue;
            }
        }
        public static int DatoInt()
        {
            try
            {
                return Int32.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                return Int32.MinValue;
            }
        }
        public static long DatoLong()
        {
            try
            {
                return Int64.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                return Int64.MinValue;
            }
        }
        public static float DatoFloat()
        {
            try
            {
                return Single.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                return Single.NaN;
            }
        }
        public static double DatoDouble()
        {
            try
            {
                return Double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                return Double.NaN;
            }
        }
    }
}
