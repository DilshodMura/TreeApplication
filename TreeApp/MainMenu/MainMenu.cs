using Spectre.Console;
using TreeApp.Models;
using TreeApp.Models.ChildModels;
using TreeApp.Service;

namespace TreeApp.MainMenu
{
	public class MainMenu
	{
        public int cap;
        BaseService bs = new BaseService();
		public void ShowMenu()
		{
            List<BaseTree> ls = new List<BaseTree>();

			cap = AnsiConsole.Ask<int>("Please enter [green]capacity[/]: ");
            var favorites = AnsiConsole.Prompt(
            new MultiSelectionPrompt<string>()
            .PageSize(10)
            .Title("Please choose the [green]trees you want to add[/]?")
            .MoreChoicesText("[grey](Move up and down to reveal more trees)[/]")
            .InstructionsText("[grey](Press [blue][/] to toggle a fruit, [green][/] to accept)[/]")
            .AddChoiceGroup("Trees", new[]
                {
                    "Apple", "Cherry"
                }));

            if (favorites.Contains("Apple"))
            {
                var apples = AnsiConsole.Prompt(new MultiSelectionPrompt<string>()
                .PageSize(10)
                .Title("Please choose the [green]trees you want to add[/]?")
                .MoreChoicesText("[grey](Move up and down to reveal more fruits)[/]")
                .InstructionsText("[grey](Press [blue][/] to toggle a fruit, [green][/] to accept)[/]")
                .AddChoiceGroup("Apples", new[]
            {
            "Golden", "Semirenko"
            }));

                if (apples.Contains("Golden"))
                {
                    var count = AnsiConsole.Ask<int>("Please enter the amount of golden trees :");
                    for (int i = 0; i < count; i++)
                    {
                        AppleGolden golden = new AppleGolden();
                        ls.Add(golden);
                    }
                }

                if (apples.Contains("Semirenko"))
                {
                    var count = AnsiConsole.Ask<int>("Please enter the amount of semerenko trees: ");

                    for (int i = 0; i < count; i++)
                    {
                        AppleSemerenko semerenko = new AppleSemerenko();
                        ls.Add(semerenko);
                    }
                }
            }

            if (favorites.Contains("Cherry"))
            {
                var cherry = AnsiConsole.Prompt(new MultiSelectionPrompt<string>()
                .PageSize(10)
                .Title("Please choose the [green]trees you want to add[/]?")
                .MoreChoicesText("[grey](Move up and down to reveal more fruits)[/]")
                .InstructionsText("[grey](Press [blue][/] to toggle a fruit, [green][/] to accept)[/]")
                .AddChoiceGroup("Cherry", new[]
                    {
                        "Frosty", "Oakland"
                    }));

                if (cherry.Contains("Frosty"))
                {
                    var count = AnsiConsole.Ask<int>("Please enter the amount of frosty trees: ");

                    for (int i = 0; i < count; i++)
                    {
                        FrostyCherry frosty = new FrostyCherry();
                        ls.Add(frosty);
                    }
                }

                if (cherry.Contains("Oakland"))
                {
                    var count = AnsiConsole.Ask<int>("Please enter the amount of oakland trees: ");

                    for (int i = 0; i < count; i++)
                    {
                        OklandCherry okland = new OklandCherry();
                        ls.Add(okland);
                    }
                }
                Console.WriteLine($"Capacity: {bs.isEnoughCap(ls, cap)} MaxHeight: {bs.AverageMaxHeight(ls, cap)}, Fruitelness: {bs.Fruitfulness(ls)}");
                Console.ReadLine();
            }
        }
	}
}

