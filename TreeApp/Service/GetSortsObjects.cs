using Spectre.Console;
using TreeApp.Interfaces;
using TreeApp.Models;

namespace TreeApp.Service
{
    public sealed class GetSortsObjects : ISortsObjects
    {
        private readonly ITreeFactory _teeFactory = new TreeSortsFactory();  
        public void AddSorts(List<IBaseTree> baseTrees, IUserInput user)
        {
            foreach (var sort in user.sorts)
            {
                var numOfTrees = AnsiConsole.Ask<int>($"How many {sort}s do you want to plant: ");
                var tree = _teeFactory.GetTreeFactory(sort);
                for (int i = 0; i < numOfTrees; i++) baseTrees.Add(tree);
            }
        }
    }
}
