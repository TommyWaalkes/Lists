﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<int> numbers = new List<int>();
            //numbers[0] = 3;
            numbers.Add(5);
            numbers[0] = 8;
            numbers.Add(6);
            numbers.Add(100);

            Console.WriteLine("For loop example");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("For Each Loop Example");
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            Console.WriteLine("Lists with a for loop Example");

            List<string> bandMembers = new List<string>() { "Notorious T Wizzle", "Billy", "Papa P W", "MC Chicken Nuggets", "Joe C Money", "Billy" };
            //Billy and Mc Chicken Nuggets both need to be booted from the group, 
            //Billy for unspeakable crimes against humanity and Mc Chicken Nuggets for, 
            //Copy right infringement. 
            //How would we remove them from the band?
            for (int i = 0; i<bandMembers.Count; i++)
            {
                //Note that assigning and grabbing from a list looks exactly like an array.
                Console.WriteLine(bandMembers[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Let's kick out Billy");
           
           // bandMembers.RemoveAll(billy);
            //bandMembers.Remove("Billy");
            //bandMembers.Clear();
           

            for (int i = 0; i < bandMembers.Count; i++)
            {
                //Note that assigning and grabbing from a list looks exactly like an array.
                Console.WriteLine(bandMembers[i]);
            }

            if (bandMembers.Contains("Billy"))
            {
                Console.WriteLine("Oh man how did Billy get in here? Oh man run, he's acting cray!");
               Console.WriteLine("Looks like Billy broke up the band");
                bandMembers.RemoveRange(0, bandMembers.Count);
                string isAnyoneLeft = bandMembers[0];
                Console.WriteLine(isAnyoneLeft);
            }

        }
    }
}
