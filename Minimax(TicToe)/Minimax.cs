namespace Minimax_TicToe_
{
    internal class Minimax:IAiLogic
    {
        public EmptyFields Move(IBoard gmBoard, Player player)
        {
            EmptyFields bestMove = null;
            var openFields = gmBoard.OpenMove;

            foreach (var t in openFields)
            {
                var newBoard = gmBoard.CloneBoard();
                var newField = t;

                newBoard[newField.X, newField.O] = player;

                if (newBoard.Winner == Player.Open && newBoard.OpenMove.Count > 0)
                {
                    var whichPlayer = ((int) player == 1) ? Player.O : Player.X;//a little hacky, inverts the current player
                    var tempMove = Move(newBoard, whichPlayer);  
                    newField.Rank = tempMove.Rank;
                }
                else
                {
                    switch (newBoard.Winner)
                    {
                        case Player.Open:
                            newField.Rank = 0;
                            break;
                        case Player.X:
                            newField.Rank = -1;
                            break;
                        case Player.O:
                            newField.Rank = 1;
                            break;
                    }
                }

                //If the new move is better than our previous move, take it
                if (bestMove == null ||
                    (player == Player.X && newField.Rank < bestMove.Rank) ||
                    (player == Player.O && newField.Rank > bestMove.Rank))
                {
                    bestMove = newField;
                }
            }

            return bestMove;
        }
    }
}
