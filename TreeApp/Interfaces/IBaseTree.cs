using TreeApp.Enums;

namespace TreeApp.Interfaces
{
    public interface IBaseTree
    {
        /// <summary>
		/// Gets the max height of the tree
		/// </summary>
		public double MaxHeight { get; }

        /// <summary>
        /// Gets tax Square of the tree
        /// </summary>
        public double MaxSquare { get; }

        /// <summary>
        /// Gets in how many years the tree will give fruits
        /// </summary>
        public double MaxFruitliness { get; }

        /// <summary>
        /// Gets the tree sort type
        /// </summary>
        public TreeSorts SortName { get; }

        /// <summary>
        /// Gets default type for particalar tree
        /// </summary>
        public TreeTypes TreeTypes { get; }
    }
}
