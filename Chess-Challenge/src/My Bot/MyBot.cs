using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using ChessChallenge.API;
using Microsoft.CodeAnalysis.FlowAnalysis;

public class MyBot : IChessBot
{
    public Move Think(Board board, Timer timer)
    {
        Move[] 
        moves = board.GetLegalMoves();
        foreach (Move move in moves)
        {
            if (move.IsCapture)
            {
                return move;
            }
        }
        return moves[0];


        void checkForLossOfPiece(Board board)
        {
            foreach (Move move in board.GetLegalMoves())
            {
                if (move.IsCapture)
                {
                    return;
                }
            }
        }
    }
}