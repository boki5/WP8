using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Maps.Controls;
using System.Device.Location;

namespace labJMMWP8
{
    public partial class MapaLokacija : PhoneApplicationPage
    {
        public MapaLokacija()
        {
            InitializeComponent();
            Map MyMap = new Map();
            MyMap.Center = new GeoCoordinate(41.987998, 21.431385);
            MyMap.ZoomLevel = 17;
            ContentPanel.Children.Add(MyMap);
        }
    }
}