using Its.Onix.Ui.Client.Commons;

namespace Its.Onix.Ui.Client.Skeleton.MainMenu
{
    public class MenuCategoryItem : ObservableObject
    {
        private string caption;

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
