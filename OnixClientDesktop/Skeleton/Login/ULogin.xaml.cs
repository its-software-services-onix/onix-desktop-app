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
            NotifyParentToClose();
        }
    }
}
