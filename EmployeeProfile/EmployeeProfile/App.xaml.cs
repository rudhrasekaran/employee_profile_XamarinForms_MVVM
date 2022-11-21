using Autofac;
using Autofac.Extras.CommonServiceLocator;
using CommonServiceLocator;
using EmployeeProfile.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EmployeeProfile
{
    public partial class App : Application
    {
        public App(ContainerBuilder containerBuilder)
        {
            BuildContainer(containerBuilder);
            InitializeComponent();
            MainPage = new ProfilePage();
        }
        public void BuildContainer(ContainerBuilder containerBuilder)
        {
            var container = containerBuilder.Build();
            var autofacServiceLocator = new AutofacServiceLocator(container);
            ServiceLocator.SetLocatorProvider(() => autofacServiceLocator);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
