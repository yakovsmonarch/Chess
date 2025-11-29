using Chess;

namespace ChessEngine;

public class Engine
{
    private readonly ChessBoard _board;
    
    public Engine()
    {
        _board = new ChessBoard();
    }

    public void Move(string move)
    {
        _board.Move(move);
    }

    public void ComputerMove()
    {
        Move[] moves = _board.Moves();
        _board.Move(moves[Random.Shared.Next(moves.Length)]);
    }

    public string DrawBoard()
    {
        return _board.ToAscii();
    }

    public bool IsEndGame => _board.IsEndGame;

    public bool IsValidMove(string move) => _board.IsValidMove(move);
}
