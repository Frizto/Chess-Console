using System;
using System.Collections.Generic;
using System.Text;
using tabletop;

namespace Chess_Console
{
    class King : Piece
    {
        public King(Tabletop tab, Color color) : base(tab, color) { }
        public override string ToString()
        {
            return "R";
        }
    }
}
