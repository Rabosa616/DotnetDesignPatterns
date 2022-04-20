using System;

namespace SOLID.InterfaceSegregation;

// Building interfaces should be seggregated (nobody needs to implement functions that don´t need)
public class Document
{
}

public interface IMachine
{
    void Print(Document d);

    void Scan(Document d);

    void Fax(Document d);
}

// If you need all methods, its fine
public class MultiFunctionPrinter : IMachine
{
    public void Fax(Document d)
    {
        //
    }

    public void Print(Document d)
    {
        //
    }

    public void Scan(Document d)
    {
        //
    }
}

// But here you only need to have the Print method
public class OldFashionedPrinter : IMachine
{
    // You only needs Print
    public void Print(Document d)
    {
        //
    }

    public void Fax(Document d)
    {
        throw new NotImplementedException();
    }

    public void Scan(Document d)
    {
        throw new NotImplementedException();
    }
}

// The Idea is to have different interfaces with different features
public interface IPrinter
{
    void Print(Document d);
}

public interface IScanner
{
    void Scan(Document d);
}

public interface IFax
{
    void Fax(Document d);
}

// You can implement those interfaces
public class MultiFunctionMachine : IPrinter, IScanner
{
    public void Print(Document d)
    {
        //
    }

    public void Scan(Document d)
    {
        //
    }
}

// Or you can delegate it
public class AnotherMultiFunctionMachine
{
    private readonly IPrinter printer;
    private readonly IScanner scanner;

    public AnotherMultiFunctionMachine(IPrinter printer, IScanner scanner)
    {
        this.printer = printer ?? throw new ArgumentNullException(paramName: nameof(printer));
        this.scanner = scanner ?? throw new ArgumentNullException(paramName: nameof(scanner));
    }
}