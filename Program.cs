using System;
using tabletop;
using chess;

namespace Chess_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ChessPosition pos = new ChessPosition('c', 7);

            Console.WriteLine(pos);
            Console.WriteLine(pos.toPosition());

            Console.ReadLine();
        }
    }
}
