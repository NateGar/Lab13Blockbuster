﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13Blockbuster
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; } = 0;

        public VHS(string title, string category, int runtime, List<string> scenes) : base(title, category, runtime, scenes)
        {

        }

        public override void Play()
        {
            string scene = Scenes[CurrentTime];
            Console.WriteLine(scene);
            CurrentTime++;
        }

        public void Rewind()
        {
            CurrentTime = 0;
        }
    }
}
