using Spectre.Console;
using TreeApp.Enums;
using TreeApp.Interfaces;
using TreeApp.Models;
using TreeApp.Service;

namespace TreeApp.MainMenu
{
    public sealed class MainMenu
    {
        BaseService bs = new();
        private readonly IUserInput userInput = new UserInput();
        private readonly ITreeTypesFactory typesFactory = new TreeTypesFactory();
        private readonly ISortsObjects sortsObjects = new GetSortsObjects();

        /// <summary>
        /// Displaying the main menu for users.
        /// </summary>
        public void ShowMenu()
        {
            List<IBaseTree> ls = new();
            userInput.FarmArea = AnsiConsole.Ask<int>("Please enter [green]capacity[/]: ");

            if (userInput.FarmArea == 0)
            {
                Console.WriteLine("Please enter valid area in digits!");
                Console.WriteLine("Please hit enter to continue: ");
                Console.ReadLine();
                Console.Clear();
                ShowMenu();
            }

            if (userInput.FarmArea < 0)
            {
                Console.WriteLine("The area should be positive number!");
                ShowMenu();
            }

            userInput.treeTypes = AnsiConsole.Prompt(new MultiSelectionPrompt<TreeTypes>()
                                                                       .PageSize(10)
                                                                       .Title("Please choose the [green]trees you want to add[/]?")
                                                                       .MoreChoicesText("[grey](Move up and down to reveal more trees)[/]")
                                                                       .InstructionsText("[grey](Press [blue][/] to toggle a fruit, [green][/] to accept)[/]")
                                                                       .AddChoiceGroup(TreeTypes.Apple | TreeTypes.Cherry, new[]
                                                                           {
                                                                               TreeTypes.Apple, TreeTypes.Cherry
                                                                           })
            );
            userInput.sorts = AnsiConsole.Prompt(new MultiSelectionPrompt<TreeSorts>()
                                                                       .PageSize(10)
                                                                       .Title("Please choose the [green]trees you want to add[/]?")
                                                                       .MoreChoicesText("[grey](Move up and down to reveal more trees)[/]")
                                                                       .InstructionsText("[grey](Press [blue][/] to toggle a fruit, [green][/] to accept)[/]")
                                                                       .AddChoiceGroup(TreeSorts.Oakland, typesFactory.GetTreeSorts(userInput)
                ));
            sortsObjects.AddSorts(ls, userInput);

            Console.WriteLine($"Capacity: {bs.isEnoughCap(ls, userInput.FarmArea)} MaxHeight: {bs.AverageMaxHeight(ls)}, Fruitelness: {bs.Fruitfulness(ls)}");
            Console.ReadLine();
        }
      }
  }


