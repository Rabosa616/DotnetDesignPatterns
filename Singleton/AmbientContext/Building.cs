using System.Collections.Generic;

namespace Singleton.AmbientContext;

public class Building
{
    public List<Wall> Walls { get; set; } = new List<Wall>();
}