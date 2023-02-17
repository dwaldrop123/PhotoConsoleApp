using Spectre.Console;

namespace PhotoConsoleLibrary.Screen.Menus
{
    public class PhotoSelectMenu : Menu
    {
        public void Print()
        {
            var table = new Table();

            table.Border(TableBorder.Square);
            table.Expand();


            table.Title = new TableTitle("Photo-Viewer");

            table.AddColumn("Select");
            table.AddRow("[green]3 Go Back[/]");
            table.AddRow("[green]4 Quit[/]");

            table.Columns[0].NoWrap();
            AnsiConsole.Write(table);

        }
    }
}
