using TreeApp.Enums;
using TreeApp.Interfaces;

namespace TreeApp.Service
{
    public sealed class TreeTypesFactory : ITreeTypesFactory
    {
        /// <summary>
        /// Setting up the tree sorts for choosen tree types.
        /// </summary>
        public List<TreeSorts> GetTreeSorts(IUserInput userInput)
        {
            var treeSorts = new List<TreeSorts>();
            if (userInput.treeTypes.Contains(TreeTypes.Apple))
            {
                treeSorts.Add(TreeSorts.Golden);
                treeSorts.Add(TreeSorts.Semerenko);

            }
            if (userInput.treeTypes.Contains(TreeTypes.Cherry))
            {
                treeSorts.Add(TreeSorts.Oakland);
                treeSorts.Add(TreeSorts.Frosty);
            }
            return treeSorts;
        }
    }
}
