using TreeApp.Interfaces;

namespace TreeApp.Models
{
    public sealed class AppleGolden : IBaseTree
    {
        /// <summary>
        /// The max height of the tree
        /// </summary>
        public double MaxHeight => 1.5;

        /// <summary>
        /// The Max Square of the tree
        /// </summary>
        public double MaxSquare => 2.3;

        /// <summary>
        /// In how many years the tree will give fruits
        /// </summary>
        public double MaxFruitliness => 6.5;

        public string SortName => nameof(AppleGolden);
    }
}

