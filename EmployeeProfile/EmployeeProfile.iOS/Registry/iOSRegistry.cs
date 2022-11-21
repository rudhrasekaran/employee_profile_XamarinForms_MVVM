using Autofac;
using EmployeeProfile.Registry;


namespace EmployeeProfile.iOS.Registry
{
    public class iOSRegistry :Module
    {
        protected override void Load(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterModule(new CoreRegistry());
        }
    }
}