using System;

namespace Decorator.DecoratorDependencyInjection;

// Decorator
public class ReportingServiceWithLogging : IReportingService
{
    private readonly IReportingService decorated;

    public ReportingServiceWithLogging(IReportingService decorated)
    {
        this.decorated = decorated;
    }

    public void Report()
    {
        Console.WriteLine("Starting log...");
        decorated.Report();
        Console.WriteLine("Ending log...");
    }
}