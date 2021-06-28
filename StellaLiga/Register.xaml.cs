using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace StellaLiga
{
    public partial class Register : ContentPage
    {
        public Register()
        {
            InitializeComponent();

            var assembly = typeof(Register);
            logo.Source = ImageSource.FromResource("StellaLiga.Assets.Images.siteIcon.png", assembly);
        }
    }
}
