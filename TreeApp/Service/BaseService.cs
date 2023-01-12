using System;

namespace TreeApp.Service
{
	public class BaseService
	{
		private double result;
		/// <summary>
		/// Caclulate if the given area will fit the amount of trees to plant.
		/// </summary>
		/// <returns></returns>
		public  double isEnoughCap(List<BaseTree> bs, int cap)
		{
			foreach (var item in bs)
			{
				 result =+ (bs.Count() * item.MaxSquare);
            }
			result = cap / result;
			if (result > 1)
				return result;
			else
				return 0;
		}

		/// <summary>
		/// Caculate the average height of the trees in the given amount.
		/// </summary>
		/// <returns></returns>
		public double AverageMaxHeight(List<BaseTree> bs, int cap)
		{
			var count = bs.Count();
            foreach (var item in bs)
            {
				result = item.MaxHeight/count;
            }
			return result;
		}

		/// <summary>
		/// Calculate in how many years the trees will give fruits.
		/// </summary>
		/// <returns></returns>
		public double Fruitfulness(List<BaseTree>bs)
		{
            return bs.Select(x => x.MaxFruitliness).Max();
        }
	}
}

