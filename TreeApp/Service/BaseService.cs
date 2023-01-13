using TreeApp.Interfaces;

namespace TreeApp.Service
{
	public sealed class BaseService
	{
		/// <summary>
		/// Caclulate if the given area will fit the amount of trees to plant.
		/// </summary>
		/// <returns></returns>
		public double isEnoughCap(IEnumerable<IBaseTree> baseTree, int farmArea)
		{
		   var result = baseTree.Sum(t => t.MaxSquare) - farmArea;
			if(result < 0)
				return result;
			return 0;
		}

		/// <summary>
		/// Caculate the average height of the trees in the given amount.
		/// </summary>
		/// <returns></returns>
		public double AverageMaxHeight(IEnumerable<IBaseTree> baseTree)
		{
			return baseTree.Average(t => t.MaxHeight); ;
		}

		/// <summary>
		/// Calculate in how many years the trees will give fruits.
		/// </summary>
		/// <returns></returns>
		public double Fruitfulness(IEnumerable<IBaseTree> baseTree)
		{
			return baseTree.Max(x => x.MaxFruitliness);
		}
	}
}

