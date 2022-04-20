using System;

namespace Command.CompositeCommand;

public class BankAccountCommand : ICommand
{
    private readonly BankAccount account;
    private readonly Action action;
    private readonly int amount;

    public enum Action
    {
        Deposit, Withdraw
    }

    public BankAccountCommand(BankAccount account, Action action, int amount)
    {
        this.account = account;
        this.action = action;
        this.amount = amount;
    }

    public void Call()
    {
        switch (action)
        {
            case Action.Deposit:
                account.Deposit(amount);
                Success = true;
                break;

            case Action.Withdraw:
                Success = account.Withdraw(amount);
                break;

            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    public void Undo()
    {
        if (!Success)
        {
            return;
        }

        switch (action)
        {
            case Action.Deposit:
                account.Withdraw(amount);
                break;

            case Action.Withdraw:
                account.Deposit(amount);
                break;

            default:
                throw new ArgumentNullException();
        }
    }

    public bool Success { get; set; }
}