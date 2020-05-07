using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13Blockbuster
{
    abstract class Movie
    {
        public string Title { get; set; }

        public string Category { get; set; }

        public int RunTime { get; set; }

        public List<string> Scenes { get; set; }

        public Movie(string title, string category, int runtime, List<string> scenes)
        {
            Title = title;
            Category = category;
            RunTime = runtime;
            Scenes = scenes;
        }

        public abstract void Play();

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"RunTime: {RunTime}");
        }

        public void PrintScenes()
        {
            int i = 0;
            foreach(string scene in Scenes)
            {
                Console.WriteLine($"{i} : {scene}");
                i++;
            }
        }
    }
}
