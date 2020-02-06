using System;
using System.Windows.Controls;

namespace Its.Onix.Ui.Client.Commons.Forms
{
    public abstract class FormBase : IForm
    {
        private readonly UFormContainer container;
        private readonly UserControl content;

        protected abstract UserControl CreateContent(UFormContainer container);
        protected abstract void SetupContainerSize(UFormContainer container);

        public event EventHandler OnFormClosed;
        public event EventHandler OnFormLoaded;

        protected DockPanel Panel { get; set; }

        public UserControl Parent { get; set; }
        public bool IsModal { get; set; }

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
            IsModal = true;
            Panel = placeHolder;

            container = new UFormContainer(null)
            {
                FormWrapper = this
            };

            content = CreateContent(container);            
            container.AddContent(content);

            SetupContainerSize(container);
        }

        public void Show()
        {
            Panel.Children.Clear();
            Panel.Children.Add(container);

            OnFormLoaded?.Invoke(this, null);
        }

        public void Close(object param)
        {
            Panel.Children.Clear();
            FormClosedEventArgs e = new FormClosedEventArgs();
            e.ClosedParam = param;
            OnFormClosed?.Invoke(this, e);
        }        
    }
}
