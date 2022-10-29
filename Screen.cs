using tabletop;
using System;

namespace Chess_Console
{
    class Screen
    {
        public static void printTabletop(Tabletop tab)
        {
            for (int i = 0; i < tab.linhas; i++)
            {
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (tab.piece(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.piece(i, j) + " ");
                    }

                }

                Console.WriteLine();
            }
        }
    }
}
