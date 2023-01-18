using TreeApp.Enums;
using TreeApp.Interfaces;
using TreeApp.Models;

namespace TreeApp.Service
{
    internal class TreeTypesFactory : ITreeTypesFactory
    {
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
