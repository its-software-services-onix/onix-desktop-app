using System;
using System.Collections;
using System.Reflection;
using System.Windows.Controls;

using Its.Onix.Ui.Client.Commons.Forms;

namespace Its.Onix.Ui.Client.Commons.Factories
{
    public static class FormFactory
    {
        private static Hashtable classMaps = new Hashtable();

        static FormFactory()
        {
            InitClassMap();
        }

        private static void AddItem(string name, string fqdn)
        {
            classMaps.Add(name, fqdn);
        }

        private static void InitClassMap()
        {
            AddItem("FormLogin", "Its.Onix.Ui.Client.Skeleton.Login.FormLogin");
            AddItem("FormMessageBox", "Its.Onix.Ui.Client.Commons.MessageBox.FormMessageBox");
        }

        public static IForm CreateFormObject(DockPanel pnl, string name)
        {
            string className = (string)classMaps[name];
            if (className == null)
            {
                throw new ArgumentNullException(String.Format("Class not found [{0}]", name));
            }
            
            Assembly asm = Assembly.GetExecutingAssembly();
            Type t = asm.GetType(className);

            var obj = (IForm) Activator.CreateInstance(t, pnl);

            return (obj);
        }
    }
}
