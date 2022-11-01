

namespace tabletop
{
    class Tabletop
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Piece[,] pieces;

        public Tabletop(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;

            pieces = new Piece[linhas, colunas];
        }

        public Piece piece(int linha, int coluna)
        {
            return pieces[linha, coluna];
        }

        public Piece piece(Position pos)
        {
            return pieces[pos.linha, pos.coluna];
        }

        public bool pieceExist(Position pos)
        {
            validPosition(pos);
            return piece(pos) != null;
        }

        public void setPiece(Piece p, Position pos)
        {
            if (pieceExist(pos))
            {
                throw new TabletopException("Piece already exists on this position!");
            }
            pieces[pos.linha, pos.coluna] = p;
            p.pos = pos;
        }

        public bool validPosition(Position pos)
        {
            if (pos.linha < 0 || pos.linha >= linhas || pos.coluna < 0 || pos.coluna >= colunas)
            {
                return false;
            } return true;
        }

        public void validatePos(Position pos)
        {
            if (!validPosition(pos))
            {
                throw new TabletopException("Invalid Position");
            }
        }
    }
}
