
using TreeApp.Enums;
using TreeApp.Models;

namespace TreeApp.Interfaces
{
    public interface ITreeTypesFactory
    {
        /// <summary>
        /// Interface helper for generating the objects for trees.
        /// </summary>
        public List<TreeSorts> GetTreeSorts(IUserInput userInput);
    }
}
