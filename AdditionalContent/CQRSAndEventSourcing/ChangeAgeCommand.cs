namespace AdditionalContent.CQRSAndEventSourcing;

public class ChangeAgeCommand : Command
{
    public Person Target { get; set; }

    public int Age { get; set; }

    public ChangeAgeCommand(Person target, int age)
    {
        Target = target;
        Age = age;
    }
}