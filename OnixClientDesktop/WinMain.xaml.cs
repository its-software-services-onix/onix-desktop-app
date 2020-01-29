using System;
using System.Windows;
using Its.Onix.Ui.Client.Skeleton.Screens;

namespace Its.Onix.Ui.Client
{
    public partial class WinMain : Window
    {
        private ScrWinMain screen = new ScrWinMain();

        public WinMain()
        {
            screen.Version = "1.0.1";
            screen.Url = "https://onix-web-api-dev-phjesaf3ha-an.a.run.app";
            screen.CurrentUser = "ADMIN";

            DataContext = screen;

            InitializeComponent();
        }
    }
}
