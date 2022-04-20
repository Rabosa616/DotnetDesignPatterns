using System;
using System.Collections.Generic;
using System.Linq;

namespace Builder.FunctionalBuilder;

public sealed class PersonBuilder : FunctionalBuilder<Person, PersonBuilder>
{
    public PersonBuilder Called(string name) => Do(p => p.Name = name);
}