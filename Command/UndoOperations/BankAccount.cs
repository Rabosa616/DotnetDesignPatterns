using System;

namespace Command.UndoOperations;

public class BankAccount
{
    private int balance;
    private readonly int overdraftLimit = -500;

    public void Deposit(int amount)
    {
        balance += amount;
        Console.WriteLine($"Deposited {amount}, balance is now {balance}");
    }

    public bool Withdraw(int amount)
    {
        if (balance - amount >= overdraftLimit)
        {
            balance -= amount;
            Console.WriteLine($"Withdraw {amount}, balance is now {balance}");
            return true;
        }

        return false;
    }

    public override string ToString()
    {
        return $"Balance -- {balance}";
    }
}