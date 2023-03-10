using Spectre.Console;
using TreeApp.Interfaces;

namespace TreeApp.Service
{
    public sealed class GetSortsObjects : ISortsObjects
    {
        private readonly ITreeFactory _teeFactory = new TreeSortsFactory();

        /// <summary>
        /// Generation the objects for all types of trees.
        /// </summary>
        public void AddSorts(IUserInput user)
        {
            foreach (var sort in user.sorts)
            {
                var numOfTrees = AnsiConsole.Ask<int>($"How many {sort}s do you want to plant: ");
                var tree = _teeFactory.GetTreeFactory(sort);
                for (int index = 0; index < numOfTrees; index++)
                {
                    user.treeList.Add(tree);
                }
            }
        }
    }
}
