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

        public string SortName => nameof(FrostyCherry);
    }
}

