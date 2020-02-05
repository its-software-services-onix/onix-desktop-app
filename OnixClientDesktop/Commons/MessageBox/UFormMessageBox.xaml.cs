using Its.Onix.Ui.Client.Commons.Forms;

namespace Its.Onix.Ui.Client.Commons.MessageBox
{
    public partial class UFormMessageBox : UserControlBase
    {
        public UFormMessageBox(UserControlBase parent) : base (parent)
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NotifyParentToClose();
        }
    }
}
