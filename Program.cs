using System;
using tabletop;

namespace Chess_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Tabletop tab = new Tabletop(8, 8);

                tab.setPiece(new Tower(tab, Color.Black), new Position(0, 0));
                tab.setPiece(new Tower(tab, Color.Black), new Position(1, 3));
                tab.setPiece(new King(tab, Color.Black), new Position(0, 2));

                Screen.printTabletop(tab);
            }
            catch (TabletopException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
