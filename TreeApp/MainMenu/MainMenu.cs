using Spectre.Console;
using TreeApp.Enums;
using TreeApp.Interfaces;
using TreeApp.Models;
using TreeApp.Models.ChildModels;
using TreeApp.Service;

namespace TreeApp.MainMenu
{
    public sealed class MainMenu
    {
        public int cap;
        BaseService bs = new BaseService();
        public void ShowMenu()
        {
            Dictionary<TreeTypes, string[]> keyValuePairs = new Dictionary<TreeTypes, string[]>()
            {
            };
            List<IBaseTree> ls = new();

            cap = AnsiConsole.Ask<int>("Please enter [green]capacity[/]: ");
            if (cap == 0)
                {
                    Console.WriteLine("Please enter valid area in digits!");
                    Console.WriteLine("Please hit enter to continue: ");
                    Console.ReadLine();
                    Console.Clear();
                    ShowMenu();
                }

            if (cap < 0)
                {
                    Console.WriteLine("The area should be positive number!"); 
                    ShowMenu();
                }
             var favorites = AnsiConsole.Prompt( new MultiSelectionPrompt<string>()
                                                                       .PageSize(10)
                                                                       .Title("Please choose the [green]trees you want to add[/]?")
                                                                       .MoreChoicesText("[grey](Move up and down to reveal more trees)[/]")
                                                                       .InstructionsText("[grey](Press [blue][/] to toggle a fruit, [green][/] to accept)[/]")
                                                                       .AddChoiceGroup("Trees", new[]
                                                                           {
                                                                               $"{TreeTypes.Apple}", $"{TreeTypes.Cherry}"
                                                                           })
                );

            if (favorites.Contains($"{TreeTypes.Apple}"))
                {
                    var apples = AnsiConsole.Prompt(new MultiSelectionPrompt<string>()
                                                                       .PageSize(10)
                                                                       .Title("Please choose the [green]trees you want to add[/]?")
                                                                       .MoreChoicesText("[grey](Move up and down to reveal more fruits)[/]")
                                                                       .InstructionsText("[grey](Press [blue][/] to toggle a fruit, [green][/] to accept)[/]")
                                                                       .AddChoiceGroup($"{TreeTypes.Apple}", new[]
                                                                           {
                                                                               $"{TreeSorts.Golden}", $"{TreeSorts.Semerenko}"
                                                                           }
                ));

            if (apples.Contains("Golden"))
                {
                    var count = AnsiConsole.Ask<int>("Please enter the amount of golden trees :");

                    for (int i = 0; i < count; i++)
                        {
                            AppleGolden golden = new AppleGolden();
                            ls.Add(golden);
                        }
                }

            if (apples.Contains($"{TreeSorts.Semerenko}"))
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
                                                                            }
                ));

                if (cherry.Contains("Frosty"))
                {
                    var count = AnsiConsole.Ask<int>("Please enter the amount of frosty trees: ");

                    for (int i = 0; i < count; i++)
                    {
                        FrostyCherry frosty = new();
                        ls.Add(frosty);
                    }
                }

                if (cherry.Contains("Oakland"))
                {
                    var count = AnsiConsole.Ask<int>("Please enter the amount of oakland trees: ");

                    for (int i = 0; i < count; i++)
                    {
                        OklandCherry okland = new();
                        ls.Add(okland);
                    }
                }
                Console.WriteLine($"Capacity: {bs.isEnoughCap(ls, cap)} MaxHeight: {bs.AverageMaxHeight(ls)}, Fruitelness: {bs.Fruitfulness(ls)}");
                Console.ReadLine();
            }
        }

        private IBaseTree GetData(TreeSorts treeSorts)
        {
            switch (treeSorts)
            {
                case TreeSorts.Golden:
                    return new AppleGolden();
                case TreeSorts.Semerenko:
                    return new AppleSemerenko();
                case TreeSorts.Frosty:
                    return new FrostyCherry();
                case TreeSorts.Oakland:
                    return new OklandCherry();
                default:
                    throw new ArgumentException("Invalid input");
            }
        }

        private void Test(string userInput)
        {
            var str2 = (TreeTypes.Apple | TreeTypes.Cherry);

        }

        private void Result()
        {

        }
    }
}

