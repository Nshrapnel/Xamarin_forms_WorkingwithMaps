using System;
using Xamarin.Forms;

namespace WorkingWithMaps {
    public class MapAppPage: ContentPage {
        
        public MapAppPage() {
            var l = new Label {
                Text = "These buttons leave the current app and open the built-in Maps app for the platform"
            };

            var openLocation = new Button {
                Text = "Open location using built-in Maps app"
            };
            openLocation.Clicked += (sender, e) => {
                if (Device.OS == TargetPlatform.iOS) {
                    Device.OpenUri(new Uri("http://maps.apple.com/?q=Universidad+Politécnica+de+Madrid:+Escuela+Técnica+Superior+de+Ingeniería+de+Sistemas+Informáticos"));
                } else if (Device.OS == TargetPlatform.Android) {
                    Device.OpenUri(new Uri("http://maps.google.com/?daddr=Universidad+Politécnica+de+Madrid:+Escuela+Técnica+Superior+de+Ingeniería+de+Sistemas+Informáticos"));
                } else if (Device.OS == TargetPlatform.Windows || Device.OS == TargetPlatform.WinPhone) {
                    Device.OpenUri(new Uri("bingmaps:?where=UPM Campus Sur ETSITGC"));
                }
            };

            var openDirections = new Button {
                Text = "Get directions using built-in Maps app"
            };
            openDirections.Clicked += (sender, e) => {
                if (Device.OS == TargetPlatform.iOS) {
                    Device.OpenUri(new Uri("http://maps.apple.com/?daddr=Universidad+Politécnica+de+Madrid:+Escuela+Técnica+Superior+de+Ingeniería+de+Sistemas+Informáticos&saddr=Madrid+La+Gavia"));
                } else if (Device.OS == TargetPlatform.Android) {
                    Device.OpenUri(new Uri("http://maps.google.com/?daddr=Universidad+Politécnica+de+Madrid:+Escuela+Técnica+Superior+de+Ingeniería+de+Sistemas+Informáticos&saddr=Madrid+La+Gavia"));
                } else if (Device.OS == TargetPlatform.Windows) {
                    Device.OpenUri(new Uri("bingmaps:?rtp=UPM Campus Sur ETSITGC~adr. Centro Comercial la Gavia"));
                }
            };
            Content = new StackLayout {
                Padding = new Thickness(5, 20, 5, 0),
                HorizontalOptions = LayoutOptions.Fill,
                Children = {
                    l,
                    openLocation,
                    openDirections
                }
            };
        }
    }
}