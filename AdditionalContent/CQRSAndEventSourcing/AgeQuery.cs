namespace AdditionalContent.CQRSAndEventSourcing;

public class AgeQuery : Query
{
    public Person Target { get; set; }
}