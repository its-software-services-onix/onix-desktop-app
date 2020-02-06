using System.Windows;
using Its.Onix.Ui.Client.Commons.Forms;

namespace Its.Onix.Ui.Client.Commons.MessageBox
{
    public partial class UFormMessageBox : UserControlBase
    {
        public UFormMessageBox(UserControlBase parent) : base (parent)
        {
            InitializeComponent();
        }

        private void ButtonYes_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NotifyParentToClose(MessageBoxResult.Yes);
        }

        private void ButtonNo_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NotifyParentToClose(MessageBoxResult.No);
        }

        private void ButtonOk_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NotifyParentToClose(MessageBoxResult.OK);
        }
    }
}
