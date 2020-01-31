using System.Windows.Controls;

namespace Its.Onix.Ui.Client.Commons.Forms
{
    public abstract class FormBase : IForm
    {
        private readonly UFormContainer container;
        private readonly UserControl content;

        protected abstract UserControl CreateContent();
        protected abstract void SetupContainerSize(UFormContainer container);

        protected DockPanel Panel { get; set; }

        public UserControl Parent { get; set; }

        public string Caption 
        {
            get
            {
                return container.Caption;
            }

            set
            {
                container.Caption = value;
            }
        }

        public FormBase(DockPanel placeHolder)
        {
            Panel = placeHolder;

            content = CreateContent();
            container = new UFormContainer();

            container.AddContent(content);

            SetupContainerSize(container);
        }

        public void Show()
        {
            Panel.Children.Clear();
            Panel.Children.Add(container);
        }

        public void Close()
        { 
        }        
    }
}
