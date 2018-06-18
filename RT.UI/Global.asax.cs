using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.Mvc;
namespace RT.UI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            

            ContainerBuilder builder0 = new ContainerBuilder();
            var Container = builder0.Build();


            Type baseType = typeof(Model.IDependency);
            System.Reflection.Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies().ToArray(); //获取已加载到此应用程序域的执行上下文中的程序集。

            Type[] dependencyTypes = assemblies
                .SelectMany(s => s.GetTypes())
                .Where(p => baseType.IsAssignableFrom(p) && p != baseType).ToArray(); //得到接口和实现类
            //RegisterDependencyTypes(dependencyTypes); //第一步：注册类型

            Autofac.ContainerBuilder builder = new Autofac.ContainerBuilder();

            //builder.RegisterType<DbContextScopeFactory>()
            //    .As<IDbContextScopeFactory>()
            //    .AsSelf()
            //    .AsImplementedInterfaces()
            //    .InstancePerLifetimeScope()
            //    .PropertiesAutowired();

            builder.RegisterTypes(dependencyTypes)
                .AsSelf()
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope()
                .PropertiesAutowired();//PropertiesAutowired注册为属性注入类型，所有实现IDependency的注册为InstancePerLifetimeScope生命周期
            builder.Update(Container);

            //SetResolver(assemblies); //第二步：

            ContainerBuilder builder2 = new ContainerBuilder();
            builder2.RegisterControllers(assemblies)
                .AsSelf()
                .InstancePerLifetimeScope()
                .PropertiesAutowired();
            builder2.Update(Container);
            DependencyResolver.SetResolver(new AutofacDependencyResolver(Container));
        }
    }
}
