using TreeApp.Enums;
using TreeApp.Interfaces;

namespace TreeApp.Models
{
    public sealed class UserInput: IUserInput
    {
        /// <summary>
        /// User input model which tracks the data.
        /// </summary>
        public int FarmArea { get; set; }

        /// <summary>
        /// Gets or sets the number of trees by user input.
        /// </summary>
        public int NumberOfTrees { get; set; }

        /// <summary>
        /// Gets or sets the tree types for trees objects.
        /// </summary>
        public List<TreeTypes> treeTypes { get ; set; }

        /// <summary>
        /// Gets or sets the list of sorts.
        /// </summary>
        public List<TreeSorts> sorts { get ; set ; }

        /// <summary>
        /// Gets or sets the list of trees.
        /// </summary>
        public List<IBaseTree> treeList { get ; set; } = new List<IBaseTree>();
    }
}
