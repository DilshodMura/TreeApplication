
using TreeApp.Enums;

namespace TreeApp.Interfaces
{
    public interface ITreeFactory
    {
        /// <summary>
        /// Interface helper for generating the objects for trees.
        /// </summary>
        public IBaseTree GetTreeFactory(TreeSorts treeSort);
    }
}
