using System;

namespace Leaf
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (LeafGame game = new LeafGame())
            {
                game.Run();
            }
        }
    }
#endif
}

