using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignments_OOP
{
    public static class DeliveryUtilities
    {
        public static void PrintSeparator()
        {
            Console.WriteLine(
                "=========================================="
            );
        }

        public static void PrintSystemTitle()
        {
            PrintSeparator();

            Console.WriteLine(
                "Smart Delivery Management System"
            );

            PrintSeparator();
        }
    }
}
