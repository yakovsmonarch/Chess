using ChessEngine;

namespace ConsoleInterfaceChessEngine.Menu;

public class MenuGame
{
    private readonly Engine _engine;

    public MenuGame(Engine engine)
    {
        _engine = engine;
    }

    public void Run()
    {
        Console.Write("Выберите цвет (0 - белые, 1 - черные): ");

        if(int.TryParse(Console.ReadLine(), out int color) == false) return;

        if(color == 1)
        {
            _engine.ComputerMove();
        }

        Console.WriteLine();

        while (_engine.IsEndGame == false)
        {
            Console.Clear();
            Console.WriteLine(_engine.DrawBoard());
            Console.Write("Введите ход: ");
            string move = Console.ReadLine();

            if(_engine.IsValidMove(move) == false) continue;

            if(_engine.IsEndGame) continue;

            _engine.Move(move);

            _engine.ComputerMove();
        }

        Console.WriteLine("Игра закончена. Для выхода намите 'Enter'.");
        Console.ReadLine();
    }
}
