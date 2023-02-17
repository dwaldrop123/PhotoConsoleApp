using PhotoConsoleLibrary.Utilities;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoConsoleLibrary.Screen.Interactions
{
    public class MenuInteraction : Interaction
    {
        public MenuOptions GetUserSelection()
        {
            var response = AnsiConsole.Ask<int>("Please select an option :");
            switch (response)
            {
                case 1:
                    return MenuOptions.PHOTO_SELECT_MENU;
                case 2:
                    return MenuOptions.STARTUP_MENU;
                case 3:
                    return MenuOptions.GO_BACK;
                case 4:
                    return MenuOptions.QUIT;
                default:
                    return MenuOptions.STARTUP_MENU;
            }
        }
    }
}
