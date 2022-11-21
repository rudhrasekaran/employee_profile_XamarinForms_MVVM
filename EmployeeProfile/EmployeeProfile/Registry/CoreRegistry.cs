using Autofac;
using EmployeeProfile.Interface;
using EmployeeProfile.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeProfile.Registry
{
    public class CoreRegistry :Module
    {
        protected override void Load(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<EmployeeDB>().As<IEmployeeDB>().SingleInstance();
        }
    }
}
