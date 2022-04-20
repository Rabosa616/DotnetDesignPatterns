using System;

namespace Factory.InnerFactory;

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

    private static readonly Point point = new(0, 0);
    public static Point Origin = point;

    // Since the constructor is private, we need to create the Factory as an inner class
    // If the constructor will be called by a different assembly, you can keep the factory in a different class
    // and instead private, you can update the constructor as "Internal"
    public static class Factory
    {
        public static Point NewCartesianPoint(double x, double y)
        {
            return new Point(x, y);
        }

        public static Point NewPolarPoint(double rho, double theta)
        {
            return new Point(rho * Math.Cos(theta), rho * Math.Sin(theta));
        }
    }
}