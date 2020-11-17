using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace karusel
{
    public partial class MainPage : CarouselPage
    {
        public MainPage()
        {
            var redContentPage = new ContentPage

            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "red",
                            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center

                        },

                        new BoxView
                        {
                            Color = Color.Red,
                            WidthRequest = 200,
                            HeightRequest = 200,
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.CenterAndExpand
                        }


                    }
                }

            };
            //------------------------------
            var blackContentPage = new ContentPage
            {
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Black",
                            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center

                        },

                        new BoxView
                        {
                            Color = Color.Black,
                            WidthRequest = 200,
                            HeightRequest = 200,
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.CenterAndExpand
                        }

                    }
                    }
                

                };


            //-----------------
            var blackContentPage = new ContentPage
            {
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "Black",
                            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center

                        },

                        new BoxView
                        {
                            Color = Color.Black,
                            WidthRequest = 200,
                            HeightRequest = 200,
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.CenterAndExpand
                        }

                    }
                    }
                    };
                    Children.Add(redContentPage);
                    Children.Add(blackContentPage);
            Children.Add(purpleContentPage);
                }
    }
}
    }







