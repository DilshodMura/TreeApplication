using TreeApp.Models;

namespace TreeApp.Interfaces
{
    public interface ISortsObjects
    {
        public void AddSorts(List<IBaseTree> baseTrees, IUserInput user);
    }
}
