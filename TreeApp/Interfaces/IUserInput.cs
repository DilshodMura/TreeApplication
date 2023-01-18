using TreeApp.Enums;

namespace TreeApp.Interfaces
{
    public interface IUserInput
    {
        /// <summary>
        /// Gets or sets the capacity for the given area.
        /// </summary>
        public int FarmArea { get; set; }

        /// <summary>
        /// Gets or sets the number of trees.
        /// </summary>
        public int NumberOfTrees { get; set; }

        /// <summary>
        /// Gets or sets the tree types choosen by users.
        /// </summary>
        public List<TreeTypes> treeTypes { get; set; }

        /// <summary>
        /// Gets or sets the tree sorts choosen by users.
        /// </summary>
        public List<TreeSorts> sorts { get; set; }

        /// <summary>
        /// Gets or sets the tree's list for collecting the data.
        /// </summary>
        public List<IBaseTree> treeList { get; set; }
    }
}
