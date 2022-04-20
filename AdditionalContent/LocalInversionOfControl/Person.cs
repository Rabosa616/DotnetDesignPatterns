using System.Collections.Generic;

namespace AdditionalContent.LocalInversionOfControl;

public class Person
{
    public List<string> Names = new();
    public List<Person> Children = new();
}