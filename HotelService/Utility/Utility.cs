using System;
using System.Collections.Generic;

namespace HotelService.Utility
{
    public static class Utility
    {
        public static void PrintListValues(List<string> itemListValues)
        {
            int increment = 0;
            foreach (string item in itemListValues)
            {
                increment++;
                Console.WriteLine($"{increment}.{item}");
            }

        }
    }
}
