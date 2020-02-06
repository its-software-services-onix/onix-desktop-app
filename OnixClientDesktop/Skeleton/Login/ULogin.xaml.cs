using System.Windows;
using Its.Onix.Ui.Client.Commons.Forms;

namespace Its.Onix.Ui.Client.Skeleton.Login
{
    public partial class ULogin : UserControlBase
    {
        public ULogin(UserControlBase parent) : base (parent)
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NotifyParentToClose(null);
        }

        private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
            MessageBoxResult result = Commons.MessageBox.CMessageBox.Show("");
        }
    }
}
