using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;

namespace Its.Onix.Ui.Client.Commons.Localization
{
    public static class LocalizationProvider
    {
        private readonly static List<DependencyObject> contentObjs;

        public static DependencyProperty ContentIDProperty = 
            DependencyProperty.RegisterAttached("ContentID", typeof(string), typeof(LocalizationProvider), 
                new FrameworkPropertyMetadata(null, 
                    FrameworkPropertyMetadataOptions.AffectsArrange, 
                    new PropertyChangedCallback(OnContentIDChanged)));

        static LocalizationProvider()
        {
            contentObjs = new List<DependencyObject>();
        }

        private static void OnContentIDChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            if (obj == null)
            {
                return;
            }

            ContentControl cctrl = obj as ContentControl;
            cctrl.SetValue(ContentControl.ContentProperty, "USER"); //TODO : Replace with actual value
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
