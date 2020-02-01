﻿using Its.Onix.Ui.Client.Commons.ViewModels;
using Its.Onix.Ui.Client.Skeleton.MainMenu;

namespace Its.Onix.Ui.Client
{
    public class ScrWinMain : ObservableScreen
    {
        private MainMenuGeneric mainMenu = new MainMenuGeneric();
        private string currentUser;
        private string url;
        private string version;
        private bool isNoPopup = true;

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

        public bool IsNoPopup
        {
            get
            {
                return isNoPopup;
            }

            set
            {
                isNoPopup = value;
                OnPropertyChanged("IsNoPopup");
            }
        }
    }
}
