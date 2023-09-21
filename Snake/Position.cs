namespace Snake
{
    public class Position
    {
        public int Row { get; }
        public int Colm { get; }

        public Position(int row, int col)
        {
            Row = row;
            Colm = col;
        }

        public Position Translate(Direction dir)
        {
            return new Position(Row + dir.RowOffset, Colm + dir.ColOffset);
        }
    }
}
