﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Devices.Geolocation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Sportinder
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Wall : Page
    {
        public Wall()
        {
            this.InitializeComponent();
        }
        private async void refreshButton_Click(object sender, RoutedEventArgs e)
        {
            var position = await LocationManager.GetPosition();
            textBox_Copy.Text = position.Coordinate.Latitude.ToString();
            textBox.Text = position.Coordinate.Longitude.ToString();
        }
    }
}
