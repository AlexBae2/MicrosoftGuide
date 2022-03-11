using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MicrosoftGuide
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Container : ContentPage
    {
        public Container()
        {
            InitializeComponent();
            StackLayout stackLayout = new StackLayout();
            for (int i = 1; i < 25; i++)
            {
                Label label = new Label
                {
                    Text = "Привет я метка #" + i,
                    FontSize = 20
                };
                stackLayout.Children.Add(label);
            }
            ScrollView scrollView = new ScrollView();
            scrollView.Content = stackLayout;
            
            //this.Content = scrollView;

            RelativeLayout relativeLayout = new RelativeLayout();
            BoxView blueBox = new BoxView { BackgroundColor = Color.Blue };
            relativeLayout.Children.Add(blueBox,
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Width * 0.5 - 50;  // установка координаты X
                        }),
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Height * 0.5 - 50; // установка координаты Y
                        }),
                Constraint.Constant(100), // установка ширины
                Constraint.Constant(100)  // установка высоты
            );

            //this.Content = relativeLayout;

            Grid grid = new Grid
            {
                RowDefinitions =
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) }
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
                }
            };

                for (int j = 0;j < 2; j++) { 
                    for(int k = 0;k < 2; k++)
                    {
                        grid.Children.Add(new BoxView { Color = Color.Red}, k, j);
                    }
                }
            
            this.Content = grid; 
        }
    }
}