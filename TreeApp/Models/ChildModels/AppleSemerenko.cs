using TreeApp.Enums;
using TreeApp.Interfaces;

namespace TreeApp.Models.ChildModels
{
    public sealed class AppleSemerenko : IBaseTree
    {
        /// <summary>
        /// The max height of the tree
        /// </summary>
        public double MaxHeight => 4.5;

        /// <summary>
        /// The Max Square of the tree
        /// </summary>
        public double MaxSquare => 5.3;

        /// <summary>
        /// In how many years the tree will give fruits
        /// </summary>
        public double MaxFruitliness => 10;

        /// <summary>
        /// Added default sort for particular tree
        /// </summary>
        public TreeSorts SortName => TreeSorts.Semerenko;

        /// <summary>
        /// Adding default type for particalar tree
        /// </summary>
        public TreeTypes TreeTypes => TreeTypes.Apple;
    }
}

