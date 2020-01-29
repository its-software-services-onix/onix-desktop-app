using System.Collections.ObjectModel;
using Its.Onix.Ui.Client.Commons;
using Its.Onix.Ui.Client.Skeleton.MainMenu;

namespace Its.Onix.Ui.Client.Skeleton.Screens
{
    public class ScrWinMain : ObservableScreen
    {
        private MainMenuGeneric mainMenu = new MainMenuGeneric();
        private string currentUser;
        private string url;
        private string version;

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

        public string CurrentUser
        {
            get
            {
                return currentUser;
            }

            set
            {
                currentUser = value;
                OnPropertyChanged("CurrentUser");
            }
        }

        public string Url
        {
            get
            {
                return url;
            }

            set
            {
                url = value;
                OnPropertyChanged("Url");
            }
        }

        public string Version
        {
            get
            {
                return version;
            }

            set
            {
                version = value;
                OnPropertyChanged("Version");
            }
        }
    }
}
