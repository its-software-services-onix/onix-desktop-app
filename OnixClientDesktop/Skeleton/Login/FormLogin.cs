using System;
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

            container.FormWidth = w/2;
            container.FormHeight = h/2;
        }

        protected override UserControl CreateContent()
        {
            ULogin content = new ULogin();
            return content;
        }
    }
}
