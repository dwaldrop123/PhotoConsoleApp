using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoConsoleLibrary.Screen
{
    public class InteractiveSelect
    {
        public int PrintSelect()
        {
            return AnsiConsole.Prompt(
                new SelectionPrompt<int>()
                .Title("[green]Select which album you wish to view...[/]")
                .PageSize(10)
                .MoreChoicesText("[grey](Move up and down to reveal more albums)[/]")
                .AddChoices(new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}));
       }
    }
}
