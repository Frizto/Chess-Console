

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
    }
}
