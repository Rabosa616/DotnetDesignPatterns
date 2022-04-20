namespace Decorator.MultipleInheritanceWithDefaultInterfaceMembers;

public class Dragon : IBird, ILizard
{
    public int Age { get; set; }
}