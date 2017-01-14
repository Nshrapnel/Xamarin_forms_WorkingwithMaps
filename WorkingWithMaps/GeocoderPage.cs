using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace WorkingWithMaps {
    public class GeocoderPage: ContentPage {
        Geocoder geoCoder;
        Label l = new Label();
        public GeocoderPage() {
            geoCoder = new Geocoder();
            var b1 = new Button { Text = "Reverse geocode '40.390507, -3.628356'" };
            b1.Clicked += async (sender, e) => {
                var CampusPosition = new Position(40.390507, -3.628356);
                var possibleAddresses = await geoCoder.GetAddressesForPositionAsync(CampusPosition);
                foreach (var a in possibleAddresses) {
                    l.Text += a + "\n";
                }
            };
            var b2 = new Button { Text = "Geocode 'Universidad Politécnica de Madrid: Escuela Técnica Superior de Ingeniería de Sistemas Informáticos'" };
            b2.Clicked += async (sender, e) => {
                var xamarinAddress = "Universidad Politécnica de Madrid: Escuela Técnica Superior de Ingeniería de Sistemas Informáticos";
                var approximateLocation = await geoCoder.GetPositionsForAddressAsync(xamarinAddress);
                foreach (var p in approximateLocation) {
                    l.Text += p.Latitude + ", " + p.Longitude + "\n";
                }
            };
            Content = new StackLayout {
                Padding = new Thickness(0, 20, 0, 0),
                Children = {
                    b2,
                    b1,
                    l
                }
            };
        }
    }
}