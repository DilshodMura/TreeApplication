using System;
namespace TreeApp.Models.ChildModels
{
	public sealed class AppleSemerenko:AppleTree
	{
        /// <summary>
        /// The max height of the tree
        /// </summary>
        public override double MaxHeight { get; set; } = 9.5;

        /// <summary>
        /// The Max Square of the tree
        /// </summary>
        public override double MaxSquare { get; set; } = 5.3;

        /// <summary>
        /// In how many years the tree will give fruits
        /// </summary>
        public override double MaxFruitliness { get; set; } = 10;

    }
}

