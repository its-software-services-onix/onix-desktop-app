using System;
using System.Windows.Controls;

namespace Its.Onix.Ui.Client.Commons.Forms
{
    public interface IForm
    {
        void Show();
        void Close(object param);
        string Caption { get; set; }
    }
}
