
using Autofac;
using EmployeeProfile.Registry;


namespace EmployeeProfile.Droid.Registry
{
    public class AndroidRegistry : Module
    {
        protected override void Load(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterModule(new CoreRegistry());
        }
    }
}