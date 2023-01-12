﻿using System;
namespace TreeApp.Models.ChildModels
{
	public sealed class OklandCherry:CherryTree
	{
        /// <summary>
        /// The max height of the tree
        /// </summary>
        public override double MaxHeight { get; set; } = 3.5;

        /// <summary>
        /// The Max Square of the tree
        /// </summary>
        public override double MaxSquare { get; set; } = 4.1;

        /// <summary>
        /// In how many years the tree will give fruits
        /// </summary>
        public override double MaxFruitliness { get; set; } = 8;

    }
}

