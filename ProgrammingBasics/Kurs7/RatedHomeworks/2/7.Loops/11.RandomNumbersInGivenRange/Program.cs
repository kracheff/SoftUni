﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class RandomNumbersInGivenRange
    {
        static void Main(string[] args)
        {
        int n = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());
        
        


            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                int randomNumber = random.Next(min, max + 1);
                Console.Write("{0} ", randomNumber);
            }
            Console.WriteLine();
        }
    }
    
