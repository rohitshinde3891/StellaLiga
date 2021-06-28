using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StellaLiga
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var assembly = typeof(MainPage);
            logo.Source = ImageSource.FromResource("StellaLiga.Assets.Images.logo.png", assembly);
            
        }
    }
}
