using System.Reflection;
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
        public double MaxSquare => 12.3;

        /// <summary>
        /// In how many years the tree will give fruits
        /// </summary>
        public double MaxFruitliness => 10;

        public string SortName => nameof(AppleSemerenko);
    }
}

