using TreeApp.Enums;
using TreeApp.Interfaces;

namespace TreeApp.Models.ChildModels
{
    public sealed class FrostyCherry : IBaseTree
    {
        /// <summary>
        /// The max height of the tree
        /// </summary>
        public double MaxHeight => 14.5;

        /// <summary>
        /// The Max Square of the tree
        /// </summary>
        public double MaxSquare => 33;

        /// <summary>
        /// In how many years the tree will give fruits
        /// </summary>
        public double MaxFruitliness => 19;

        /// <summary>
        /// Added default sort for particular tree
        /// </summary>
        public TreeSorts SortName => TreeSorts.Frosty;

        /// <summary>
        /// Adding default type for particalar tree
        /// </summary>
        public TreeTypes TreeTypes => TreeTypes.Cherry;
    }
}

