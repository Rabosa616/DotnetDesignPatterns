using System;

namespace Template.TemplateMethod;

public abstract class Game
{
    public void Run()
    {
        Start();
        while (!HaveWinner)
        {
            TakeTurn();
        }

        Console.WriteLine($"Player {WinningPlayer} wins.");
    }

    protected int currentPlayer;
    protected readonly int numberOfPlayers;

    protected abstract void Start();

    protected abstract void TakeTurn();

    protected abstract bool HaveWinner { get; }
    protected abstract int WinningPlayer { get; }

    public Game(int numberOfPlayers)
    {
        this.numberOfPlayers = numberOfPlayers;
    }
}