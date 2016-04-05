using System.Collections.Generic;

namespace Minimax_TicToe_
{
    interface IBoard
    {
       Player[,] SquaresPlayers { get; set; }
       Player this[int x, int y] { get; set; }
       bool IsFull { get; }
       List<EmptyFields> OpenMove { get; }
       Player Winner { get; }
       IBoard CloneBoard();
    }
}
