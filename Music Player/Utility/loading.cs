using System;
using System.Threading;

namespace Music_Player.Utility
{
    internal static class loading
    {
        public static void Loading()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("loading ");
            for (float i = 0; i < 12; i++)
            {

                Console.Write(".");
                Thread.Sleep(300);

            }
            Console.ResetColor();
        }
    }
}
