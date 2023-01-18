
using TreeApp.Enums;

namespace TreeApp.Interfaces
{
    public interface IUserInput
    {
        public int FarmArea { get; set; }
        public int NumberOfTrees { get; set; }
        public List<TreeTypes> treeTypes { get; set; }

        public List<TreeSorts> sorts { get; set; }
    }
}
