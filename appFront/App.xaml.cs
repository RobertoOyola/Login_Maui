﻿using appFront.LogIn;

namespace appFront
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new LoginPage();
        }
    }
}