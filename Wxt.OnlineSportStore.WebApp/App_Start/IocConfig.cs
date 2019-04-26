using Autofac;
using Autofac.Integration.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Wxt.OnlineSportStore.Domain.Abstract;
using Wxt.OnlineSportStore.Domain.Entities;

namespace Wxt.OnlineSportStore.WebApp
{
    public class IocConfig
    {
        public static void Register()
        {
            var MyProductsRepository = new Mock<IProductsRepository>();
            MyProductsRepository.Setup(m => m.Products).Returns(new List<Product>
            {
                new Product { Id = 1, Name = "p1", Category = "c1", Description = "p1 in c1", Price = 1.35m},
                new Product { Id = 2, Name = "p2", Category = "c1", Description = "p2 in c1", Price = 8.65m},
                new Product { Id = 3, Name = "p3", Category = "c2", Description = "p3 in c2", Price = 7m},
                new Product { Id = 4, Name = "p4", Category = "c3", Description = "p4 in c3", Price = 10.18m}
            });

            var builder = new ContainerBuilder();
            builder.RegisterControllers(AppDomain.CurrentDomain.GetAssemblies()).PropertiesAutowired();
            builder.RegisterInstance<IProductsRepository>(MyProductsRepository.Object).PropertiesAutowired();

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}