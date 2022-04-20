using System;
using System.Collections.Generic;

namespace Mediator.ChatRoom;

public class Person
{
    public string Name { get; set; }
    public ChatRoom Room { get; set; }
    public List<string> ChatLog { get; set; } = new List<string>();

    public Person(string name)
    {
        Name = name;
    }

    public void Say(string message)
    {
        Room.Broadcast(Name, message);
    }

    public void PrivateMessage(string who, string message)
    {
        Room.Message(Name, who, message);
    }

    public void Receive(string sender, string message)
    {
        string s = $"{sender}: '{message}'";
        ChatLog.Add(s);
        Console.WriteLine($"[{Name}´s chat session] {s}");
    }
}