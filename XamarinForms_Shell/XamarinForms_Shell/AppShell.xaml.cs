using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace _03.ShellTest
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Shell.SetTabBarIsVisible(this, false);//隱藏頁籤
        }

        private async void MenuItem_Clicked(object sender, EventArgs e)
        {
            await Launcher.OpenAsync("https://www.tpisoftware.com/");
        }
    }
}
