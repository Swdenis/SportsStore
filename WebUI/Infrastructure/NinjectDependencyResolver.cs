using System;
using Ninject;
using System.Collections.Generic;
using System.Linq;
using Moq;
using Domain.Abstract;
using Domain.Entities;


namespace WebUI.Infrastructure
{
    public class NinjectDependencyResolver

    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        private void AddBindings()
        {
            Mock<IProductsRepository> mock = new Mock<IProductsRepository>();
            mock.Setup(m=> m.Products).Returns(new List<Product> {
                new Product { Name = "Football", Price = 25 },
                new Product { Name = " Surf board", Price = 179 },
                new Product { Name = "Running shoes", Price = 95 }
                });
            kernel.Bind<IProductsRepository>().ToConstant(mock.Object);
        }
    }
}
