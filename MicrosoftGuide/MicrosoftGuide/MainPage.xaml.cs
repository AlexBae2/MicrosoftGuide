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
        public const string HEADER = "Xamarin";

        public static double staticVar = 28;
        public MainPage()
        {
            InitializeComponent();
            Label header = new Label() { Text = "Xamarin Forms in Arial" };
            header.FontFamily = "Arial";
        }
        void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            valueLabel.Text = args.NewValue.ToString("F3");
        }

        void OnButtonClicked(object sender, EventArgs args)
        {
            string xaml = "<Label Text=\"Xamarin Forms\" FontSize=\"24\" />";
            valueLabel.LoadFromXaml(xaml);
        }
    }
}
