using Chess;

namespace ChessEngine;

public class Engine
{
    private readonly ChessBoard _board;
    
    public Engine()
    {
        _board = new ChessBoard();
    }
}
