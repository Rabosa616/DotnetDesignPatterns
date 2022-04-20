using System.Collections.Generic;

namespace Adapter.AdapterDependencyInjection;

public class Editor
{
    private readonly IEnumerable<Button> buttons;

    public Editor(IEnumerable<Button> buttons)
    {
        this.buttons = buttons;
    }

    public void ClickAll()
    {
        foreach (var button in buttons)
        {
            button.Click();
        }
    }
}