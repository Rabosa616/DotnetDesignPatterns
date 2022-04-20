namespace ChainOfResponsibility.BrokerChain;

public class Query
{
    public string CreatureName { get; set; }
    public int Value { get; set; }

    public enum Argument
    {
        Attack, Defense
    }

    public Argument WhatToQuery;

    public Query(string creatureName, int value, Argument whatToQuery)
    {
        CreatureName = creatureName;
        Value = value;
        WhatToQuery = whatToQuery;
    }
}