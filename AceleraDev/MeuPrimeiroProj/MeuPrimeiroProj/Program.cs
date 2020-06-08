using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace MeuPrimeiroProj
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = new List<int>();

            int number = 0, controller = 1;
            sequence.Add(0);

            while (number <= 350)
            {
                number = number + controller;
                sequence.Add(number);
                controller = number - controller;
            }
            foreach(int i in sequence)
            {
                Console.WriteLine(i);
            }
        }

    }
}
