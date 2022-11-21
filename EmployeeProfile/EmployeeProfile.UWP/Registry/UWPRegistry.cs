using Autofac;
using EmployeeProfile.Registry;


namespace EmployeeProfile.UWP.Registry
{
    public class UWPRegistry :Module
    {
        protected override void Load(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterModule(new CoreRegistry());
        }
    }
}
