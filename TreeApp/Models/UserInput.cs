using TreeApp.Enums;
using TreeApp.Interfaces;

namespace TreeApp.Models
{
    public sealed class UserInput: IUserInput
    {
        public int FarmArea { get; set; }
        public int NumberOfTrees { get; set; }
        public List<TreeTypes> treeTypes { get ; set; }
        public List<TreeSorts> sorts { get ; set ; }
    }
}
