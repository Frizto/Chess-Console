

namespace tabletop
{
    class Piece
    {
        public Position pos { get; set; }
        public Color color { get; protected set; }
        public int movQtd { get; protected set; }
        public Tabletop tab { get; protected set; }

        public Piece(Tabletop tab, Color color)
        {
            this.pos = null;
            this.tab = tab;
            this.color = color;
            this.movQtd = 0;
        }
    }
}
