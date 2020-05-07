using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13Blockbuster
{
    class Blockbuster
    {

        public static void PrintMovies()
        {
            List<string> sandScenes = new List<string>();
            sandScenes.Add("YOU'RE KILLING ME SMALLS!");
            sandScenes.Add("You play ball like a GIRL!");
            sandScenes.Add("Kissing Wendy Peffercorn");
            sandScenes.Add("The Beast");
            

            VHS theSandlot = new VHS("The Sandlot", Enum.GetName(typeof(Genre), 1), 90, sandScenes);


            List<string> speedScenes = new List<string>();
            speedScenes.Add("The bus scene");
            speedScenes.Add("The other bus scene");
            speedScenes.Add("The other other bus scene");

            VHS speed = new VHS("Speed", Enum.GetName(typeof(Genre), 0), 90, speedScenes);


            List<string> ninjaScenes = new List<string>();
            ninjaScenes.Add("A wise man say, never pay full price for a late pizza!");
            ninjaScenes.Add("GO NINJA GO NINJA GO");
            ninjaScenes.Add("Cowabunga Dude!");

            VHS teenageMutantNinjaTurtles = new VHS("Teenage Mutant Ninja Turtles", Enum.GetName(typeof(Genre), 1), 100, ninjaScenes);


            List<string> dumbScenes = new List<string>();
            dumbScenes.Add("Pretty Bird");
            dumbScenes.Add("Most anoying sound in the world");
            dumbScenes.Add("It's a cardigan but thanks for asking!");

            DVD dumbAndDumber = new DVD("Dumb and Dumber", Enum.GetName(typeof(Genre), 1), 80, dumbScenes);

            

            List<string> goneScenes = new List<string>();
            goneScenes.Add("Lowrider");
            goneScenes.Add("The Cadillac scene");
            goneScenes.Add("Elenore");

            DVD goneInSixtySeconds = new DVD("Gone in 60 seconds", Enum.GetName(typeof(Genre), 4), 120, goneScenes);

            

            List<string> hackScenes = new List<string>();
            hackScenes.Add("Zero Cool: Mess with the best die like the rest!");
            hackScenes.Add("TV network battle");
            hackScenes.Add("Crash and Burn");

            DVD hackers = new DVD("Hackers", Enum.GetName(typeof(Genre), 0), 80, hackScenes);

        
            List<Movie> movies = new List<Movie>();
            movies.Add(theSandlot);
            movies.Add(speed);
            movies.Add(teenageMutantNinjaTurtles);
            movies.Add(dumbAndDumber);
            movies.Add(goneInSixtySeconds);
            movies.Add(hackers);
            int i = 1;
            foreach (Movie film in movies)
            {
                Console.WriteLine($"{i}\t{film}");
                i++;
            }
            
        }

        public static void Checkout()
        {
            Console.WriteLine("Please Select a Movie from the list below:");
            PrintMovies();
            int input = int.Parse(Console.ReadLine());
            //pull movie from list using input-1 then thatMovie.printInfo
            Console.WriteLine("would you like to watch this movie? y/n");
            string answer = Console.ReadLine().Trim().ToLower();

            if (answer == "y")
            {
                //thatMovie.PrintScenes();
            }
        }
        
    }
}
