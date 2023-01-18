
using TreeApp.Enums;
using TreeApp.Models;

namespace TreeApp.Interfaces
{
    public interface ITreeTypesFactory
    {
        public List<TreeSorts> GetTreeSorts(IUserInput userInput);
    }
}
