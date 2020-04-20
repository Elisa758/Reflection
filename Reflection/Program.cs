using System;
using System.Collections.Generic;
using System.Reflection;

namespace Reflection
{

    class Program
    {
        static void Main(string[] args)
        {
            var game = new VideoGame();
            Reflection.GetAllProperties(game);
            Reflection.GetAllMethods(game);
            Reflection.GetAllFields(game);

        }
    }
}
