using System;
using System.Collections.Generic;
using System.Text;
using tabletop;

namespace Chess_Console
{
    class Tower : Piece
    {
        public Tower(Tabletop tab, Color color) : base(tab, color) { }
        public override string ToString()
        {
            return "T";
        }
    }
}
