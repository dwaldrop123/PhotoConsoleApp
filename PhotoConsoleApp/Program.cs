using PhotoConsoleLibrary.Http.Queries;
using PhotoConsoleLibrary.Screen;
using PhotoConsoleLibrary.Screen.Interactions;
using PhotoConsoleLibrary.Screen.Menus;

class Program
{
    static async Task Main(string[] args)
    {
        var screen = new Screen();

        var userInteraction = new UserInteraction();

        var photoView = new PhotoView();

        var interactiveSelect = new InteractiveSelect();

        var query = new PhotoApiQuery();

        bool endProgram = false;

        int start = 0;

        while (!endProgram)
        {
            if(start == 0)
            {
                screen.Print(new StartupMenu());
            }
            start++;

            var userResponse = userInteraction.GetUserInteraction(new MenuInteraction());

            switch (userResponse)
            {
                case PhotoConsoleLibrary.Utilities.MenuOptions.STARTUP_MENU:
                    screen.Print(new StartupMenu());
                    break;
                case PhotoConsoleLibrary.Utilities.MenuOptions.PHOTO_SELECT_MENU:
                    screen.Print(new PhotoSelectMenu());
                    var selected = interactiveSelect.PrintSelect();

                    var response = await query.GetAlbums(selected);

                    photoView.PrintView(response);

                    screen.Print(new PhotoSelectMenu());
                    break;
                case PhotoConsoleLibrary.Utilities.MenuOptions.GO_BACK:
                    screen.Print(new StartupMenu());
                    break;
                case PhotoConsoleLibrary.Utilities.MenuOptions.QUIT:
                    endProgram = true;
                    break;
            }
        }
    }
}