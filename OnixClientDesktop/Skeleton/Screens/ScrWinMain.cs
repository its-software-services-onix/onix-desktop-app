using System.Collections.ObjectModel;
using Its.Onix.Ui.Client.Commons;
using Its.Onix.Ui.Client.Skeleton.MainMenu;

namespace Its.Onix.Ui.Client.Skeleton.Screens
{
    public class ScrWinMain : ObservableScreen
    {
        private MainMenuGeneric mainMenu = new MainMenuGeneric();

        public ScrWinMain()
        {
            mainMenu.PopulateCategories();
        }

        public MainMenuGeneric MainMenu
        {
            get 
            {
                return mainMenu; 
            }

            set
            {
                mainMenu = value;
                OnPropertyChanged("MainMenu");
            }
        }
    }
}
