using System;
using System.Collections.Generic;

namespace _16.SortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var events = new SortedDictionary<DateTime, string>();
            events[new DateTime(1998, 9, 4)] = "Googles birht date";
            events[new DateTime(2013, 11, 5)] = "SoftUnis birth date";
            events[new DateTime(1975, 4, 4)] = "Microsofts birth Date";
            events[new DateTime(2004, 2, 4)] = "FaceBoolk birth date";
            events[new DateTime(2013, 11, 5)] = "SoftIUni was founded";
            events[new DateTime(2000, 12, 20)] = "foundation of Sharans Book ";

            foreach (var entry in events)
            {
                //  Console.WriteLine(entry.Key + " " + entry.Value);  // not sored the key-;
                Console.WriteLine();
                Console.WriteLine("{0:dd-MMM-yyyy }: {1}", entry.Key, entry.Value);
                // here sorted the output by key,  the data is sorted by format :dd :MM:yyyy;
                //assending sorting from lowest-earliest day to the highest, latest day !
            }

        }
    }
}
