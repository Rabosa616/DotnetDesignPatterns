using System;

namespace Decorator.DecoratorDependencyInjection;

public class ReportingService : IReportingService
{
    public void Report()
    {
        Console.WriteLine("Here is your report");
    }
}