using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;
using System.Resources;
using System.Reflection;
using System.Globalization;
using System.Collections;

namespace Its.Onix.Ui.Client.Commons.Localization
{
    public static class LocalizationProvider
    {
        private static string currentLocale = "";
        private static Hashtable resourceMap = new Hashtable();

        private readonly static List<DependencyObject> contentObjs;

        public static DependencyProperty ContentIDProperty = 
            DependencyProperty.RegisterAttached("ContentID", typeof(string), typeof(LocalizationProvider), 
                new FrameworkPropertyMetadata(null, 
                    FrameworkPropertyMetadataOptions.AffectsArrange, 
                    new PropertyChangedCallback(OnContentIDChanged)));

        static LocalizationProvider()
        {
            contentObjs = new List<DependencyObject>();

            var asm = Assembly.GetExecutingAssembly();

            resourceMap["TH"] = new ResourceManager("Its.Onix.Ui.Client.Resources.Languages.TH", asm);
            resourceMap["EN"] = new ResourceManager("Its.Onix.Ui.Client.Resources.Languages.EN", asm);

            currentLocale = "EN";
        }

        private static void OnContentIDChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            if (obj == null)
            {
                return;
            }

            ContentControl cctrl = obj as ContentControl;
            UpdateControlContent(cctrl);

            if (!contentObjs.Contains(cctrl))
            {
                contentObjs.Add(cctrl);
            }
        }

        private static void UpdateControlContent(DependencyObject ctrl)
        {
            string key = ctrl.GetValue(ContentIDProperty) as string;
            var resman = (ResourceManager) resourceMap[currentLocale];
            string value = resman.GetString(key);

            if (string.IsNullOrEmpty(value))
            {
                value = "ERROR!";
            }

            ctrl.SetValue(ContentControl.ContentProperty, value);
        }

        public static void SetCurrentLocale(string code)
        {
            currentLocale = code;
            foreach (DependencyObject obj in contentObjs)
            {
                if (obj != null)
                {
                    UpdateControlContent(obj);
                }
            }
        }

        public static string GetContentID(DependencyObject obj)
        {
            return (string) obj.GetValue(ContentIDProperty);
        }

        public static void SetContentID(DependencyObject obj, string value)
        {
            obj.SetValue(ContentIDProperty, value);
        }
    }
}
