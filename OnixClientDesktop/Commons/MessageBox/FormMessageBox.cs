using System.Windows.Controls;
using Its.Onix.Ui.Client.Commons.Forms;

namespace Its.Onix.Ui.Client.Commons.MessageBox
{
    public class FormMessageBox : FormBase
    {
        public FormMessageBox(DockPanel panel) : base(panel)
        { 
        }

        protected override void SetupContainerSize(UFormContainer container)
        {
            double h = Panel.ActualHeight;
            double w = Panel.ActualWidth;

            container.FormWidth = Panel.ActualWidth;
            container.FormHeight = Panel.ActualHeight;
        }

        protected override UserControl CreateContent(UFormContainer container)
        {
            UFormMessageBox content = new UFormMessageBox(container);
            return content;
        }
    }
}
