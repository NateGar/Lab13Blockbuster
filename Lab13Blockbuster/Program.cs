using System;
using System.Collections.Generic;

namespace Lab13Blockbuster
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("\tWelcome to Blockbuster how can we help you?");
                Blockbuster.Checkout();
                //I lost it somewhere around here and had to give up because I'm out of time.

                Console.WriteLine("would you like to watch another movie? y/n");
                string answer = Console.ReadLine();

                if(answer == "y")
                {
                    loop = true;
                }
                else
                {
                    loop = false;
                }
            }
            
        }
    }
}
