using System;

namespace AdditionalContent.CQRSAndEventSourcing;

public class Command : EventArgs
{
    public bool Register { get; set; } = true;
}