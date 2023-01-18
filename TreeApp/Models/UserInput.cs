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
        public int NumberOfTrees { get; set; }
        public List<TreeTypes> treeTypes { get ; set; }
        public List<TreeSorts> sorts { get ; set ; }
    }
}
