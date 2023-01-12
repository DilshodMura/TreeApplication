using System;
namespace TreeApp.Models
{
	public sealed class AppleGolden:AppleTree
	{
        /// <summary>
        /// The max height of the tree
        /// </summary>
        public override double MaxHeight { get; set; } = 1.5;

        /// <summary>
        /// The Max Square of the tree
        /// </summary>
        public override double MaxSquare { get; set; } = 2.3;

        /// <summary>
        /// In how many years the tree will give fruits
        /// </summary>
        public override double MaxFruitliness { get; set; } = 6.5;

    }
}

