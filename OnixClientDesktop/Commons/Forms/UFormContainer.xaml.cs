using System.Windows;
using System.Windows.Controls;

namespace Its.Onix.Ui.Client.Commons.Forms
{
    public partial class UFormContainer : UserControlBase
    {
        public static readonly DependencyProperty FormWidthProperty =
            DependencyProperty.Register("FormWidth", typeof(double), typeof(UFormContainer),
            new UIPropertyMetadata(500.00, new PropertyChangedCallback(OnFormWidthChanged)), ValidateFormWidthValue);

        public static readonly DependencyProperty FormHeightProperty =
            DependencyProperty.Register("FormHeight", typeof(double), typeof(UFormContainer),
            new UIPropertyMetadata(400.00, new PropertyChangedCallback(OnFormHeightChanged)), ValidateFormHeightValue);

        public static readonly DependencyProperty CaptionProperty =
            DependencyProperty.Register("Caption", typeof(string), typeof(UFormContainer),
            new UIPropertyMetadata("", new PropertyChangedCallback(OnCaptionChanged)));


        #region FormWidth
        private static void OnFormWidthChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
        }

        private static bool ValidateFormWidthValue(object value)
        {
            return (true);
        }

        public double FormWidth
        {
            get 
            { 
                return (double) GetValue(FormWidthProperty); 
            }

            set 
            { 
                SetValue(FormWidthProperty, value); 
            }
        }
        #endregion FormWidth


        #region FormHeight
        private static void OnFormHeightChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
        }

        private static bool ValidateFormHeightValue(object value)
        {
            return (true);
        }

        public double FormHeight
        {
            get
            {
                return (double)GetValue(FormHeightProperty);
            }

            set
            {
                SetValue(FormHeightProperty, value);
            }
        }
        #endregion FormHeight

        #region Caption
        private static void OnCaptionChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
        }

        public string Caption
        {
            get
            {
                return (string) GetValue(CaptionProperty);
            }

            set
            {
                SetValue(CaptionProperty, value);
            }
        }
        #endregion Caption

        public UFormContainer(UserControlBase parent) : base(parent)
        {
            DataContext = this;
            InitializeComponent();
        }

        public void AddContent(UserControl content)
        {
            if (content != null)
            {
                grdMain.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(100, GridUnitType.Star) });
                grdMain.SetValue(Grid.RowProperty, 0);
                grdMain.SetValue(Grid.ColumnProperty, 0);

                grdMain.Children.Add(content);
            }
        }

        protected override void Close(object param)
        {
            FormWrapper.Close(param);
        }
    }
}
