using Its.Onix.Ui.Client.Commons.Forms;
using Its.Onix.Ui.Client.Commons.MessageBox;

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
            NotifyParentToClose();
        }

        private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
            MessageBox.Show("");
        }
    }
}
