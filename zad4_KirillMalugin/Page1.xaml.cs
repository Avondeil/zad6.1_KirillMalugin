using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zad4_KirillMalugin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1(string username)
        {
            InitializeComponent();

            Slider slider1 = new Slider { Minimum = 0, Maximum = 100 , MinimumTrackColor=Color.LightSkyBlue};
            Slider slider2 = new Slider { Minimum = 0, Maximum = 100, MinimumTrackColor = Color.LightSkyBlue };
            Slider slider3 = new Slider { Minimum = 0, Maximum = 100,MinimumTrackColor = Color.LightSkyBlue };
            Slider slider4 = new Slider { Minimum = 0, Maximum = 100 ,MinimumTrackColor = Color.LightSkyBlue };

            Button button1 = new Button { Text = "Button", WidthRequest = 140, BorderRadius = 30, StyleId = "Button-1" };
            Button button2 = new Button { Text = ">", WidthRequest = 60, HeightRequest = 60, BorderRadius = 30, StyleId = "Button-1" };
            Button button3 = new Button { Text = "+", WidthRequest = 60, HeightRequest = 60, BorderRadius = 30, StyleId = "Button-1" };
            Button button4 = new Button { Text = "▶", WidthRequest = 60, HeightRequest = 60, BorderRadius = 30, StyleId = "Button-1" };
            Button button5 = new Button { Text = "✓", WidthRequest = 60, HeightRequest = 60, BorderRadius = 30, StyleId = "Button-1" };
            Button button6 = new Button { Text = "Button", WidthRequest = 140, BorderRadius = 30, StyleId = "Button-2" };
            Button button7 = new Button { Text = ">", WidthRequest = 60, HeightRequest = 60, BorderRadius = 30, StyleId = "Button-2" };
            Button button8 = new Button { Text = "+", WidthRequest = 60, HeightRequest = 60, BorderRadius = 30, StyleId = "Button-2" };
            Button button9 = new Button { Text = "▶", WidthRequest = 60, HeightRequest = 60, BorderRadius = 30, StyleId = "Button-2" };
            Button button10 = new Button { Text = "✓", WidthRequest = 60, HeightRequest = 60, BorderRadius = 30, StyleId = "Button-2" };
            Button button11 = new Button { Text = "Button", WidthRequest = 140, BorderRadius = 30, StyleId = "Button-3" };
            Button button12 = new Button { Text = ">", WidthRequest = 60, HeightRequest = 60, BorderRadius = 30, StyleId = "Button-3" };
            Button button13 = new Button { Text = "+", WidthRequest = 60, HeightRequest = 60, BorderRadius = 30, StyleId = "Button-3" };
            Button button14 = new Button { Text = "▶", WidthRequest = 60, HeightRequest = 60, BorderRadius = 30, StyleId = "Button-3" };
            Button button15 = new Button { Text = "✓", WidthRequest = 60, HeightRequest = 60, BorderRadius = 30, StyleId = "Button-3" };
            Button button16 = new Button { Text = "Button", WidthRequest = 140, BorderRadius = 30, StyleId = "Button-4" };
            Button button17 = new Button { Text = ">", WidthRequest = 60, HeightRequest = 60, BorderRadius = 30, StyleId = "Button-4" };
            Button button18 = new Button { Text = "+", WidthRequest = 60, HeightRequest = 60, BorderRadius = 30, StyleId = "Button-4" };
            Button button19 = new Button { Text = "▶", WidthRequest = 60, HeightRequest = 60, BorderRadius = 30, StyleId = "Button-4" };
            Button button20 = new Button { Text = "✓", WidthRequest = 60, HeightRequest = 60, BorderRadius = 30, StyleId = "Button-4" };
            RadioButton RadioButton = new RadioButton
            {
                HorizontalOptions = LayoutOptions.Start
            };

            CheckBox checkBox = new CheckBox();
            {
                checkBox.Color = Color.LightSkyBlue;
            };


            Switch switch1 = new Switch
            {
                ThumbColor = Color.LightGray,
                OnColor = Color.LightSkyBlue
            };
            Switch switch2 = new Switch
            {
                ThumbColor = Color.LightGray,
                OnColor = Color.LightSkyBlue
            };
            Switch switch3 = new Switch
            {
                ThumbColor = Color.LightGray,
                OnColor=Color.LightSkyBlue
            };

            StackLayout sliderLayout = new StackLayout
            {
                Children = { slider1, slider2, slider3, slider4 }
            };

            StackLayout buttonLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = { button1, button2, button3, button4, button5 }
            };

            StackLayout buttonLayout2 = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = { button6, button7, button8, button9, button10 }
            };

            StackLayout buttonLayout3 = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = { button11, button12, button13, button14, button15 }
            };

            StackLayout buttonLayout4 = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = { button16, button17, button18, button19, button20 }
            };

            StackLayout switchLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = { switch1, switch2, switch3 }
            };
            StackLayout buttonLayout5 = new StackLayout
            {
                Children = { RadioButton, checkBox}
            };
            StackLayout mainLayout = new StackLayout
            {
                Children = { sliderLayout, buttonLayout, buttonLayout2, buttonLayout3, buttonLayout4, switchLayout , buttonLayout5}
            };

            Content = mainLayout;
        }

        private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
