using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MicrosoftGuide
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            button.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new Container());
            };
            button1.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new Controls());
            };
            StackLayout stackLayout = new StackLayout()
            {
                Children = { button,button1 }
            };
            Content = stackLayout;
        }
    }
}
