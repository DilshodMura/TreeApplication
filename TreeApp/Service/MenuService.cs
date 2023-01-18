using Spectre.Console;
using TreeApp.Enums;
using TreeApp.Interfaces;
using TreeApp.Models;

namespace TreeApp.Service
{
    public sealed class MenuService
    {
        BaseService baseService = new();
        private readonly IUserInput userInput = new UserInput();
        private readonly ITreeTypesFactory typesFactory = new TreeTypesFactory();
        private readonly ISortsObjects sortsObjects = new GetSortsObjects();

        /// <summary>
        /// Displays the capacity and total count of trees
        /// </summary>
        public void GeneralInfo()
        {
            var table = new Table();

            table.AddColumn("Farm Capacity: ");
            table.AddColumn(new TableColumn("Total count of trees: ")).Centered();
            foreach (var item in userInput.treeList.DistinctBy(x => x.SortName))
            {
                table.AddRow(item.SortName.ToString(), userInput.treeList.Count(x => x.SortName.Equals(item.SortName)).ToString());
            }

            AnsiConsole.Write(table);
            ShowMenu();
        }

        /// <summary>
        /// Entering the capacity.
        /// </summary>
        public void MaintainCap(IUserInput user)
        {
            userInput.FarmArea = AnsiConsole.Ask<int>("Please enter [green]capacity[/]: ");
            if (userInput.FarmArea > 0)
            {
                Console.WriteLine("Succesfully added!");
                ShowMenu();
            }
            else
            {
                do
                {
                    Console.WriteLine("Invalid input! Please try again!");
                    userInput.FarmArea = AnsiConsole.Ask<int>("Enter area of your plot: ");
                }
                while (userInput.FarmArea <= 0);
            }
            ShowMenu();
        }

        /// <summary>
        /// Adding trees.
        /// </summary>
        public void AddTrees()
        {
            if (userInput.FarmArea == 0)
            {
                Console.WriteLine("Please enter capacity first!");
                ShowMenu();
            }
            else
            {
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
                                                                           .AddChoiceGroup(TreeSorts.Oakland | TreeSorts.Golden | TreeSorts.Semerenko | TreeSorts.Frosty, typesFactory.GetTreeSorts(userInput)
                    ));
                sortsObjects.AddSorts(userInput);
                Console.WriteLine("Please go to calculate field to continue...\n");
            }
            ShowMenu();
        }

        /// <summary>
        /// Displaying the main menu for users.
        /// </summary>
        public void ShowMenu()
        {
            var menu = AnsiConsole.Prompt(new SelectionPrompt<Menu>().Title("Please use UP and DOWN arrows to choose...")
                .PageSize(10)
                .MoreChoicesText("Please use UP and DOWN arrows to choose...")
                .AddChoices(new[]
                    {
                        Menu.MaintainCapacity,
                        Menu.GenrealInfo,
                        Menu.AddTrees,
                        Menu.Calculate,
                        Menu.Exit
                    }));

            switch (menu)
            {
                case Menu.MaintainCapacity:
                    MaintainCap(userInput);
                    break;
                case Menu.GenrealInfo:
                    GeneralInfo();
                    break;
                case Menu.AddTrees:
                    AddTrees();
                    break;
                case Menu.Calculate:
                    Calculate(userInput);
                    break;
                case Menu.Exit:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }

        /// <summary>
        /// Calculates the average max height, capacity, and fruitfulness.
        /// </summary>
        public void Calculate(IUserInput user)
        {
            var table = new Table();

            table.AddColumn("Farm Capacity left: ");
            table.AddColumn(new TableColumn("Average max height: ")).Centered();
            table.AddColumn(new TableColumn("Fruitfulness: ")).Centered();
            table.AddRow(baseService.isEnoughCap(user).ToString(), baseService.AverageMaxHeight(user).ToString(),baseService.Fruitfulness(user).ToString());

            AnsiConsole.Write(table);
            ShowMenu();
        }
    }
}
