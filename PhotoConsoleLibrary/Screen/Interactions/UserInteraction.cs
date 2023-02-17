
using PhotoConsoleLibrary.Utilities;

namespace PhotoConsoleLibrary.Screen.Interactions
{
    public class UserInteraction
    {
        public MenuOptions GetUserInteraction(Interaction interaction)
        {
            return interaction.GetUserSelection();
        }
    }
}
