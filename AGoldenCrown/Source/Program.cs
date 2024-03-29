﻿using AGoldenCrown.Source;
using AGoldenCrown.Source.Models;
using System;
using System.Collections.Generic;

namespace AGoldenCrown
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number of Messages to be sent by King Shan: ");

            var noOfMessages = Convert.ToInt32(Console.ReadLine());
            List<String> messages = new List<String>();

            Console.WriteLine("Enter the Kingdom Name and Message to be sent: ");

            for (int i = 0; i < noOfMessages; i++)
                messages.Add(Console.ReadLine());

            var ruler = new RulerAllies(messages, "King Shan");

            MessageResults.PrintMessageResults(ruler);
        }
    }
}