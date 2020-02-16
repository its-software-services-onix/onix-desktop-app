using System.Collections.ObjectModel;
using Its.Onix.Ui.Client.Commons.ViewModels;

namespace Its.Onix.Ui.Client.Skeleton.MainMenu
{
    public class MainMenuGeneric : ObservableObject
    {
        protected ObservableCollection<MenuCategory> categories = new ObservableCollection<MenuCategory>();

        private void PopulateGenericMenu()
        {
            MenuCategoryItem genericCustomer = new MenuCategoryItem() { Caption = "MenuCustomer" };
            MenuCategoryItem genericSupplier = new MenuCategoryItem() { Caption = "MenuSupplier" };

            var items = new ObservableCollection<MenuCategoryItem>();
            items.Add(genericCustomer);
            items.Add(genericSupplier);

            MenuCategory genericMenu = new MenuCategory() { Caption = "MenuGeneric" };
            genericMenu.ChildItems = items;

            categories.Add(genericMenu);
        }

        private void PopulateProgramMenu()
        {
            MenuCategoryItem programPasswd = new MenuCategoryItem() { Caption = "MenuChangePassword" };
            MenuCategoryItem programLogOUt = new MenuCategoryItem() 
            { 
                Caption = "MenuLogout",
                FormName = "FormLogin",
                NeedConfirm = true,
                IsModal = true
            };
            MenuCategoryItem programExit = new MenuCategoryItem() { Caption = "MenuExit" };

            var items = new ObservableCollection<MenuCategoryItem>();
            items.Add(programPasswd);
            items.Add(programLogOUt);
            items.Add(programExit);

            MenuCategory programMenu = new MenuCategory() { Caption = "MenuProgram" } ;
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
