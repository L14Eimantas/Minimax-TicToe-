namespace Minimax_TicToe_
{
    internal class EmptyFields
    {
        public int X { get; }
        public int O { get; }
        private int _rank;

        public EmptyFields(int x, int y)
        {
            X = x;
            O = y;
            _rank = 0;
        }

        public int Rank
        {
            get { return _rank; }
            set { _rank = value; }
        }
    }
}
