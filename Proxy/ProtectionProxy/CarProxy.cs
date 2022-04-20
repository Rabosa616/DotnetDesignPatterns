using System;

namespace Proxy.ProtectionProxy;

public class CarProxy : ICar
{
    private readonly Driver driver;
    private readonly Car car = new();

    public CarProxy(Driver driver)
    {
        this.driver = driver;
    }

    public void Drive()
    {
        if (driver.Age >= 16)
        {
            car.Drive();
        }
        else
        {
            Console.WriteLine("too young");
        }
    }
}