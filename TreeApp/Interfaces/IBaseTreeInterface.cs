
namespace TreeApp.Interfaces
{
    public interface IBaseTreeInterface
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
    }
}
