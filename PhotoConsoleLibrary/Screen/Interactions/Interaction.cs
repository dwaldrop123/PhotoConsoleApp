using PhotoConsoleLibrary.Utilities;
using Spectre.Console;

namespace PhotoConsoleLibrary.Screen.Interactions
{
    public interface Interaction
    {
        MenuOptions GetUserSelection();
    }
}
