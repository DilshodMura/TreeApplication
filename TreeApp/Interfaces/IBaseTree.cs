
namespace TreeApp.Interfaces
{
    public interface IBaseTree
    {
        /// <summary>
		/// The max height of the tree
		/// </summary>
		public double MaxHeight { get; }

        /// <summary>
        /// The Max Square of the tree
        /// </summary>
        public double MaxSquare { get; }

        /// <summary>
        /// In how many years the tree will give fruits
        /// </summary>
        public double MaxFruitliness { get; }

        /// <summary>
        /// Gets the tree sort type
        /// </summary>
        public string SortName { get; }
    }
}
