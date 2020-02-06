using System;
using System.Windows;
using System.Windows.Controls;
using Its.Onix.Ui.Client.Commons.Factories;
using Its.Onix.Ui.Client.Commons.Forms;
using Its.Onix.Ui.Client.Commons.MessageBox;
using Its.Onix.Ui.Client.Skeleton.Login;
using Its.Onix.Ui.Client.Skeleton.MainMenu;

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
        }

        private void PopupFormClosed(object sender, EventArgs e)
        {
            screen.IsNoPopup = true;
        }

        private void PopupFormLoaded(object sender, EventArgs e)
        {
            screen.IsNoPopup = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MenuItem mi = sender as MenuItem;
            MenuCategoryItem item = (MenuCategoryItem) mi.DataContext;

            if (item.NeedConfirm)
            {
                CMessageBox.Show("");
            }

            DockPanel pnl = pnlSystem;
            if (item.IsModal)
            {
                pnl = pnlPopup;
            }

            FormBase frm = (FormBase) FormFactory.CreateFormObject(pnl, item.FormName);

            if (item.IsModal)
            {
                frm.OnFormClosed += PopupFormClosed;
                frm.OnFormLoaded += PopupFormLoaded;
            }

            frm.Caption = item.Caption;
            frm.Show();
        }
    }
}
