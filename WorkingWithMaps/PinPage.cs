using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace WorkingWithMaps {
    public class PinPage: ContentPage {
        Map map;
        public PinPage() {
            map = new Map {
                IsShowingUser = true,
                HeightRequest = 100,
                WidthRequest = 960,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            map.MapType = MapType.Hybrid;
            map.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(40.390507, -3.628356), Distance.FromMeters(500)));
            var position = new Position(40.390547, -3.628390); 
            var pin = new Pin {
                Type = PinType.Place,
                Position = position,
                Label = "AICU",
                Address = "Universidad Politécnica de Madrid, Carretera Valencia, km 7, 28030 Madrid"
            };
            map.Pins.Add(pin);
            var morePins = new Button { Text = "Add more pins" };
            morePins.Clicked += (sender, e) => {
                map.Pins.Add(new Pin {
                    Position = new Position(40.3905529, -3.6269338),
                    Label = "Library"
                });
                map.Pins.Add(new Pin {
                    Position = new Position(40.3877973, -3.6315805),
                    Label = "INSIA"
                });
                map.MoveToRegion(MapSpan.FromCenterAndRadius(
                    new Position(40.3886121, -3.6308447), Distance.FromMeters(200)));
            };
            var reLocate = new Button { Text = "Re-center" };
            reLocate.Clicked += (sender, e) => {
                map.MoveToRegion(MapSpan.FromCenterAndRadius(
                    new Position(40.3886121, -3.6308447), Distance.FromMeters(200)));
            };
            var buttons = new StackLayout {
                Orientation = StackOrientation.Horizontal,
                Children = {
                    morePins, reLocate
                }
            };
            Content = new StackLayout {
                Spacing = 0,
                Children = {
                    map,
                    buttons
                }
            };
        }
    }
}