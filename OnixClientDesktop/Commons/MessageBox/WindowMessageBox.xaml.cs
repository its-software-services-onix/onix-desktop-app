using System;
using System.Windows;
using Its.Onix.Ui.Client.Commons.Factories;
using Its.Onix.Ui.Client.Commons.Forms;

namespace Its.Onix.Ui.Client.Commons.MessageBox
{
    public partial class WindowMessageBox : Window
    {
        private readonly string titleText = "";
        private readonly MessageBoxImage icon;
        private readonly MessageBoxButton buttons;
        private readonly string messageText = "";

        public WindowMessageBox(string text, string title, MessageBoxButton buttons, MessageBoxImage icon)
        {
            titleText = title;
            messageText = text;
            this.icon = icon;
            this.buttons = buttons;

            InitializeComponent();
        }

        public MessageBoxResult Result { get; set; }

        public WindowMessageBox()
        {
            InitializeComponent();
        }

        private void PopupFormLoaded(object sender, EventArgs e)
        {
        }

        private void PopupFormClosed(object sender, EventArgs e)
        {
            Result = (MessageBoxResult) (e as FormClosedEventArgs).ClosedParam;
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
