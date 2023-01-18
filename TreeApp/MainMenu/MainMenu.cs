using TreeApp.Service;

namespace TreeApp.MainMenu
{
    public sealed class MainMenu
    {
        private readonly MenuService mn = new MenuService();

        /// <summary>
        /// Printing the main menu.
        /// </summary>
        public void PrintMenu()
        {
            mn.ShowMenu();
        }
    }
  }


