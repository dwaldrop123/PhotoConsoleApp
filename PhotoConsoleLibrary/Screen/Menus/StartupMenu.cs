using Spectre.Console;

namespace PhotoConsoleLibrary.Screen.Menus
{
    public class StartupMenu : Menu
    {
        public void Print()
        {
            var table = new Table();

            table.Border(TableBorder.Square);
            table.Expand();


            table.Title = new TableTitle("Photo-Viewer");

            table.AddColumn("Select");
            table.AddRow("[green]1 Photo Album Selection[/]");
            table.AddRow("[green]4 Quit[/]");

            table.Columns[0].NoWrap();
            AnsiConsole.Write(table);
        }
    }
}
