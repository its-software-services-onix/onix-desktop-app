using System;
using System.Windows;
using Its.Onix.Ui.Client.Skeleton.Login;

namespace Its.Onix.Ui.Client
{
    public partial class WinMain : Window
    {
        private readonly ScrWinMain screen = new ScrWinMain();

        public WinMain()
        {
            screen.Version = "1.0.1";
            screen.Url = "https://onix-web-api-dev-phjesaf3ha-an.a.run.app";
            screen.CurrentUser = "ADMIN";

            DataContext = screen;

            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var frmLogin = new FormLogin(pnlContent);
            frmLogin.Show();
            frmLogin.Caption = "LOGIN";
        }
    }
}
