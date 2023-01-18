using TreeApp.Enums;
using TreeApp.Interfaces;

namespace TreeApp.Models.ChildModels
{
    public sealed class OklandCherry : IBaseTree
    {
        /// <summary>
        /// The max height of the tree
        /// </summary>
        public double MaxHeight => 3.1;

        /// <summary>
        /// The Max Square of the tree
        /// </summary>
        public double MaxSquare => 4.5;

        /// <summary>
        /// In how many years the tree will give fruits
        /// </summary>
        public double MaxFruitliness => 13;

        public TreeSorts SortName => TreeSorts.Oakland;

        public TreeTypes TreeTypes => TreeTypes.Cherry; 
    }
}

