using TreeApp.Enums;
using TreeApp.Interfaces;
using TreeApp.Models.ChildModels;
using TreeApp.Models;

namespace TreeApp.Service
{
    public sealed class TreeSortsFactory : ITreeFactory
    {
        public IBaseTree GetTreeFactory(TreeSorts treeSort)
        {
            switch (treeSort)
            {
                case TreeSorts.Golden:
                    return new AppleGolden();
                case TreeSorts.Oakland:
                    return new OklandCherry();
                case TreeSorts.Frosty:
                    return new FrostyCherry();
                case TreeSorts.Semerenko:
                    return new AppleSemerenko();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
