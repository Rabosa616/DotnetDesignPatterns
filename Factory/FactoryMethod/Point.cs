using System;

namespace Factory.FactoryMethod;

public class Point
{
    private readonly double x;
    private readonly double y;

    // The constructor changes to private
    private Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    // Factory method
    // The name of the method is not attached to the constructor
    public static Point NewCartesianPoint(double x, double y)
    {
        return new Point(x, y);
    }

    // Second factory method
    public static Point NewPolarPoint(double rho, double theta)
    {
        return new Point(rho * Math.Cos(theta), rho * Math.Sin(theta));
    }
}