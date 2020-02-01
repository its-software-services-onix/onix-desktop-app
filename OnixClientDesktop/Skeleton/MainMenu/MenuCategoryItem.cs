using Its.Onix.Ui.Client.Commons.ViewModels;

namespace Its.Onix.Ui.Client.Skeleton.MainMenu
{
    public class MenuCategoryItem : ObservableObject
    {
        private bool isModal = false;
        private bool needConfirm = false;
        private string caption;        
        private string formName;

        public bool NeedConfirm
        {
            get
            {
                return needConfirm;
            }

            set
            {
                if (needConfirm != value)
                {
                    needConfirm = value;
                    OnPropertyChanged("NeedConfirm");
                }
            }
        }

        public string FormName
        {
            get
            {
                return formName;
            }

            set
            {
                if (formName != value)
                {
                    formName = value;
                    OnPropertyChanged("FormName");
                }
            }
        }

        public bool IsModal
        {
            get
            {
                return isModal;
            }

            set
            {
                if (isModal != value)
                {
                    isModal = value;
                    OnPropertyChanged("IsModal");
                }
            }
        }

        public string Caption
        {
            get 
            {
                return caption; 
            }

            set
            {
                if (caption != value)
                {
                    caption = value;
                    OnPropertyChanged("Caption");
                }
            }
        }
    }
}
