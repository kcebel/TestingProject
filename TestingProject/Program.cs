﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Trying to git this
            string[] words = { "hello", "wonderful", "LINQ", "beautiful", "world" };
            //Get only short words
            var shortWords = from word in words
                             where word.Length <= 5
                             select word;

            //Print each word out
            foreach (var word in shortWords)
            {
                Console.WriteLine(word);
            }         
        }
    }
}
