using System;
using System.Windows;
using Its.Onix.Ui.Client.Skeleton.MainMenu;

namespace Its.Onix.Ui.Client
{
    public partial class WinMain : Window
    {
        private MainMenuGeneric mainMenu = new MainMenuGeneric();

        public WinMain()
        {
            mainMenu.PopulateCategories();
            DataContext = mainMenu;

            InitializeComponent();

            //mnuMain.ItemsSource = mainMenu.MenuCategories;
        }
    }
}
