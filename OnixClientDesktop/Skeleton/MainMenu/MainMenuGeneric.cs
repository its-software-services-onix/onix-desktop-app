using System.Collections.ObjectModel;
using Its.Onix.Ui.Client.Commons;

namespace Its.Onix.Ui.Client.Skeleton.MainMenu
{
    public class MainMenuGeneric : ObservableObject
    {
        protected ObservableCollection<MenuCategory> categories = new ObservableCollection<MenuCategory>();

        private void PopulateGenericMenu()
        {
            MenuCategoryItem genericCustomer = new MenuCategoryItem() { Caption = "CUSTOMERS" };
            MenuCategoryItem genericSupplier = new MenuCategoryItem() { Caption = "SUPPLIERS" };

            var items = new ObservableCollection<MenuCategoryItem>();
            items.Add(genericCustomer);
            items.Add(genericSupplier);

            MenuCategory genericMenu = new MenuCategory() { Caption = "GENERIC" };
            genericMenu.ChildItems = items;

            categories.Add(genericMenu);
        }

        private void PopulateProgramMenu()
        {
            MenuCategoryItem programPasswd = new MenuCategoryItem() { Caption = "CHANGE PASSWORD" };
            MenuCategoryItem programLogOUt = new MenuCategoryItem() { Caption = "LOGOUT" };
            MenuCategoryItem programExit = new MenuCategoryItem() { Caption = "EXIT" };

            var items = new ObservableCollection<MenuCategoryItem>();
            items.Add(programPasswd);
            items.Add(programLogOUt);
            items.Add(programExit);

            MenuCategory programMenu = new MenuCategory() { Caption = "PROGRAM" } ;
            programMenu.ChildItems = items;

            categories.Add(programMenu);
        }

        public virtual void PopulateCategories()
        {
            PopulateProgramMenu();
            PopulateGenericMenu();
            MenuCategories = categories;
        }

        public ObservableCollection<MenuCategory> MenuCategories
        {
            get
            {
                return categories;
            }

            set
            {
                categories = value;
                OnPropertyChanged("MenuCategories");
            }
        }

    }
}
