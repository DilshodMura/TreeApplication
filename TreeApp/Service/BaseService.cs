using TreeApp.Interfaces;

namespace TreeApp.Service
{
	public sealed class BaseService
	{
		/// <summary>
		/// Caclulate if the given area will fit the amount of trees to plant.
		/// </summary>
		/// <returns></returns>
		public double isEnoughCap(IUserInput user)
		{
			
		   var result = user.FarmArea - user.treeList.Sum(t => t.MaxSquare);
			if(result > 0)
				return result;
			Console.WriteLine(new Exception("Not enough space to plant trees"));
			return 0;
		}

		/// <summary>
		/// Caculate the average height of the trees in the given amount.
		/// </summary>
		/// <returns></returns>
		public double AverageMaxHeight(IUserInput user)
		{
			if(user.treeList.Count> 0)
			{
                return user.treeList.Average(t => t.MaxHeight);
            }
			else
				Console.WriteLine("Please check the number of trees!");
			return 0;
        }

		/// <summary>
		/// Calculate in how many years the trees will give fruits.
		/// </summary>
		/// <returns></returns>
		public double Fruitfulness(IUserInput user)
		{

            if (user.treeList.Count > 0)
            {
				return user.treeList.Max(x => x.MaxFruitliness);
            }
            else
                Console.WriteLine("Please check the number of trees!");
            return 0;
		}
	}
}

