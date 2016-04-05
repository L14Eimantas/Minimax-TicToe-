using System;
using System.Collections.Generic;

namespace Minimax_TicToe_
{
    internal class TicToeBoard:IBoard
    {
        public Player[,] SquaresPlayers { get; set; }

        public TicToeBoard()
        {
            SquaresPlayers = new Player[,] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
        }
        public Player this[int x, int y]
        {
            get { return SquaresPlayers[x, y]; }
            set { SquaresPlayers[x, y] = value; }
        }

        public bool IsFull => OpenMove.Count == 0;

        public List<EmptyFields> OpenMove
        {
            get
            {
                var openSquares = new List<EmptyFields>();
                for (var x = 0; x < 3; x++)
                {
                    for (var y = 0; y < 3; y++)
                    {
                        if (SquaresPlayers[x, y] == Player.Open)
                        {
                            openSquares.Add(new EmptyFields(x,y));
                        }
                    }
                }
                return openSquares;
            }
        }

        public Player Winner => WhoWin(SquaresPlayers);

        private Player WhoWin(Player[,] sP)
        {
            // rows
            if (Math.Abs((int)sP[0, 0] + (int)sP[0, 1] + (int)sP[0, 2]) == 3)
                return HeWin((int)sP[0, 0] + (int)sP[0, 1] + (int)sP[0, 2]);
            if (Math.Abs((int)sP[1, 0] + (int)sP[1, 1] + (int)sP[1, 2]) == 3)
                return HeWin((int)sP[1, 0] + (int)sP[1, 1] + (int)sP[1, 2]);
            if (Math.Abs((int)sP[2, 0] + (int)sP[2, 1] + (int)sP[2, 2]) == 3)
                return HeWin((int)sP[2, 0] + (int)sP[2, 1] + (int)sP[2, 2]);
            // columns
            if (Math.Abs((int)sP[0, 0] + (int)sP[1, 0] + (int)sP[2, 0]) == 3)
                return HeWin((int)sP[0, 0] + (int)sP[1, 0] + (int)sP[2, 0]);
            if (Math.Abs((int)sP[0, 1] + (int)sP[1, 1] + (int)sP[2, 1]) == 3)
                return HeWin((int)sP[0, 1] + (int)sP[1, 1] + (int)sP[2, 1]);
            if (Math.Abs((int)sP[0, 2] + (int)sP[1, 2] + (int)sP[2, 2]) == 3)
                return HeWin((int)sP[0, 2] + (int)sP[1, 2] + (int)sP[2, 2]);
            //diagonals
            if (Math.Abs((int)sP[0, 0] + (int)sP[1, 1] + (int)sP[2, 2]) == 3)
                return HeWin((int)sP[0, 0] + (int)sP[1, 1] + (int)sP[2, 2]);
            if (Math.Abs((int)sP[0, 2] + (int)sP[1, 1] + (int)sP[2, 0]) == 3)
                return HeWin((int)sP[0, 2] + (int)sP[1, 1] + (int)sP[2, 0]);
            return Player.Open;

        }

        private Player HeWin(int count)
        {
            if (count==3)
                return  Player.X;
            if (count == -3)
                return Player.O;
            throw  new ArgumentNullException(nameof(count));
        }

        public IBoard CloneBoard()
        {
            var b = new TicToeBoard {SquaresPlayers = (Player[,]) SquaresPlayers.Clone()};
            return b;

        }
    }
}
