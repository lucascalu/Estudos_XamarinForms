﻿using System;
using Xamarin.Forms;

namespace XF_NavigationPage3
{
    public partial class MainPage1 : ContentPage
    {
        public MainPage1()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage2());
        }
    }
}
