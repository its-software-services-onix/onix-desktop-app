using System;
using System.Windows;
using Its.Onix.Ui.Client.Commons.Factories;
using Its.Onix.Ui.Client.Commons.Forms;

namespace Its.Onix.Ui.Client.Commons.MessageBox
{
    public partial class WindowMessageBox : Window
    {
        private string titleText = "";

        public WindowMessageBox(string text, string title, MessageBoxButton buttons, MessageBoxImage icon)
        {
            titleText = title;
            InitializeComponent();
        }

        public WindowMessageBox()
        {
            InitializeComponent();
        }

        private void PopupFormLoaded(object sender, EventArgs e)
        {
        }

        private void PopupFormClosed(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FormBase frm = (FormBase) FormFactory.CreateFormObject(pnlPopup, "FormMessageBox");
            frm.OnFormClosed += PopupFormClosed;
            frm.OnFormLoaded += PopupFormLoaded;

            frm.Caption = titleText;
            frm.Show();
        }
    }
}
