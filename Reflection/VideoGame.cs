using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection
{
    class VideoGame
    {
        private int _id = 0;
        public string Name { get; set; }
        private DateTime ReleaseDate { get; set; }
        private List<string> Characters { get; set; }

        public VideoGame()
        {
            _id = 0;
            Name = String.Empty;
        }

        public void DoSomething()
        {
            Console.WriteLine("YO!!!");
        }
    }
}
