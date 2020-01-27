using System;
using System.Windows;
using Its.Onix.Ui.Client.Skeleton.Screens;

namespace Its.Onix.Ui.Client
{
    public partial class WinMain : Window
    {
        private ScrWinMain screen = new ScrWinMain();

        public WinMain()
        {
            DataContext = screen;
            InitializeComponent();
        }
    }
}
