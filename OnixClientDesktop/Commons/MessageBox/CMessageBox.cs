using System;
using System.Windows;

namespace Its.Onix.Ui.Client.Commons.MessageBox
{
    public static class CMessageBox
    {
        public static MessageBoxResult Show(string text)
        {
            return Show(text, "Message Box", MessageBoxButton.OK, MessageBoxImage.None);
        }

        public static MessageBoxResult Show(string text, string title)
        {
            return Show(text, title, MessageBoxButton.OK, MessageBoxImage.None);
        }

        public static MessageBoxResult Show(string text, string title, MessageBoxButton buttons)
        {
            return Show(text, title, buttons, MessageBoxImage.None);
        }

        public static MessageBoxResult Show(string text, MessageBoxButton buttons, MessageBoxImage imgs)
        {
            return Show(text, "Message Box", buttons, MessageBoxImage.None);
        }

        public static MessageBoxResult Show(String txt, String title, MessageBoxButton buttons, MessageBoxImage imgs)
        {
            WindowMessageBox msg = new WindowMessageBox(txt, title, buttons, imgs);
            msg.ShowDialog();
            MessageBoxResult result = msg.Result;

            return result;
        }
    }
}
