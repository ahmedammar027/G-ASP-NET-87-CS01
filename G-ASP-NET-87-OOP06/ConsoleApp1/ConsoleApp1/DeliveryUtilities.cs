using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal static class DeliveryUtilities
    {
        public static void PrintSeparator()
        {
            Console.WriteLine("========================================");
        }

        // دالة لطباعة عنوان النظام
        public static void PrintSystemTitle()
        {
            PrintSeparator();
            Console.WriteLine("        SHIPPING & DELIVERY SYSTEM      ");
            PrintSeparator();
        }
    }
}
