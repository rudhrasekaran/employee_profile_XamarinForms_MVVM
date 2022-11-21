using Autofac;
using EmployeeProfile.UWP.Registry;
using System;
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

namespace EmployeeProfile.UWP
{
    public sealed partial class MainPage
    {
        ContainerBuilder _containerBuilder;
        public MainPage()
        {
            this.InitializeComponent();
            _containerBuilder = new ContainerBuilder();
            _containerBuilder.RegisterModule(new UWPRegistry());
            LoadApplication(new EmployeeProfile.App(_containerBuilder));
        }
    }
}
