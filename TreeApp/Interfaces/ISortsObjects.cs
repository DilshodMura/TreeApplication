
namespace TreeApp.Interfaces
{
    public interface ISortsObjects
    {
        /// <summary>
        /// Providing the sorts of trees to the user
        /// </summary>
        public void AddSorts(List<IBaseTree> baseTrees, IUserInput user);
    }
}
