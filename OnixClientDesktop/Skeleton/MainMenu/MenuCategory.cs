using System.Collections.ObjectModel;
using Its.Onix.Ui.Client.Commons;

namespace Its.Onix.Ui.Client.Skeleton.MainMenu
{
    public class MenuCategory : ObservableObject
    {
        private string caption;

        private ObservableCollection<MenuCategoryItem> childItems = new ObservableCollection<MenuCategoryItem>();

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

        public ObservableCollection<MenuCategoryItem> ChildItems
        {
            get
            {
                return childItems;
            }

            set
            {
                childItems = value;
                OnPropertyChanged("ChildItems");
            }
        }
    }
}
