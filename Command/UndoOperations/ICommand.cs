namespace Command.UndoOperations;

public interface ICommand
{
    void Call();

    void Undo();
}