using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13Blockbuster
{
    class DVD : Movie
    {
        public DVD(string title, string category, int runtime, List<string> scenes) : base(title, category, runtime, scenes)
        {

        }
        public override void Play()
        {
            PrintScenes();
            Console.WriteLine("using the index please select the scene you would like to watch");
            string input = Console.ReadLine();
            int pick = int.Parse(input);

            string scene = Scenes[pick];
            Console.WriteLine(scene);
        }
    }
}
