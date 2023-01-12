using System;
namespace TreeApp
{
	public abstract class BaseTree
	{
		/// <summary>
		/// The max height of the tree
		/// </summary>
		public virtual double MaxHeight { get; set; }

		/// <summary>
		/// The Max Square of the tree
		/// </summary>
		public virtual double MaxSquare { get; set; }

		/// <summary>
		/// In how many years the tree will give fruits
		/// </summary>
		public virtual double MaxFruitliness { get; set; }
	}
}

