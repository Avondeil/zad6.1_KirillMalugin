using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace zad4_KirillMalugin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var welcomeLabel = new Label
            {
                StyleId = "header",
                Text = "Добро пожаловать",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };

            var usernameEntry = new Entry
            {
                Placeholder = "Username",
                HorizontalOptions = LayoutOptions.FillAndExpand,
                StyleId = "styleforzad5"

            };

            var passwordEntry = new Entry
            {
                Placeholder = "Password",
                IsPassword = true,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                StyleId = "styleforzad5"
            };

            var rememberMeRadioButton = new RadioButton
            {
                Content = "Запомнить меня",
                HorizontalOptions = LayoutOptions.Start,
                BackgroundColor = Color.White,

            };

            var signInButton = new Button
            {
                Text = "Войти",
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            var signInLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children =
                {
                    rememberMeRadioButton,
                    signInButton,
                    new Label{ Text = "Я забыл!", HorizontalOptions = LayoutOptions.End }
                }
            };

            var errorMessageLabel = new Label
            {
                TextColor = Color.Red,
                HorizontalOptions = LayoutOptions.Center
            };
            var moneyBut = new Button
            {
                Text = "Деньги",
                HorizontalOptions = LayoutOptions.FillAndExpand,

            };

            moneyBut.Clicked += (sender, e) =>
            {
                string username = usernameEntry.Text;
                Navigation.PushAsync(new Page2());
            };

            signInButton.Clicked += (sender, e) =>
            {

                if (string.IsNullOrWhiteSpace(usernameEntry.Text) || string.IsNullOrWhiteSpace(passwordEntry.Text))
                {
                    errorMessageLabel.Text = "Введите логин и пароль";
                }
                else
                {

                    string username = usernameEntry.Text;
                    string password = passwordEntry.Text;


                    Navigation.PushAsync(new Page1(username));
                }
            };


            var stackLayout = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Padding = new Thickness(30),
                Children =
                {
                    welcomeLabel,
                    usernameEntry,
                    passwordEntry,
                    signInButton,
                    errorMessageLabel,
                    rememberMeRadioButton,
                    signInLayout,
                    moneyBut


                }
            };


            Content = stackLayout;



        }
    }
}