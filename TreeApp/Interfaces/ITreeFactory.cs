
using TreeApp.Enums;

namespace TreeApp.Interfaces
{
    public interface ITreeFactory
    {
        public IBaseTree GetTreeFactory(TreeSorts treeSort);
    }
}
