using System;
using System.Collections.Generic;

namespace _17.DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        // Problem -> count the real numbers, in an input of console .
        {
            // numbers 12 1 -3 105 224  12 -1 ; -> take numbers, and take numberOccurences ; key->value pair
            // 5 15 16 25 105 49 // sortedDictionary automaticaaly sorts by key 
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');

            var dict = new SortedDictionary<double, int>();  //We create a dictionary with pair -> double, and int
            // int is the number of occurences!

            foreach (string number in numbers)
            {
                double num = double.Parse(number);
                if (!dict.ContainsKey(num))   //if the key is not existing into the array then create it !
                {
                    dict[num] = 0;
                }
                dict[num] += 1;
            }
            foreach (KeyValuePair<double, int> pair in dict)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value + " times");
            }

        }
    }
}
