using System;
using System.Collections.Generic;
using System.Text;
using tabletop;

namespace chess
{
    class ChessPosition
    {
        public char coluna { get; set; }
        public int linha { get; set; }

        public ChessPosition(char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        }

        public Position toPosition()
        {
            return new Position(8 - linha, coluna - 'a');
        }
        public override string ToString()
        {
            return "" + coluna + linha;
        }
    }
}
