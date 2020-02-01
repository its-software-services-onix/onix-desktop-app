using System.Windows.Controls;
using Its.Onix.Ui.Client.Commons.Forms;

namespace Its.Onix.Ui.Client.Skeleton.Login
{
    public class FormLogin : FormBase
    {
        public FormLogin(DockPanel panel) : base(panel)
        { 
        }

        protected override void SetupContainerSize(UFormContainer container)
        {
            double h = Panel.ActualHeight;
            double w = Panel.ActualWidth;

            container.FormWidth = w / 2;
            container.FormHeight = h / 2;

            //container.FormWidth = Panel.Width;
            //container.FormHeight = Panel.Height;
        }

        protected override UserControl CreateContent(UFormContainer container)
        {
            ULogin content = new ULogin(container);
            return content;
        }
    }
}
