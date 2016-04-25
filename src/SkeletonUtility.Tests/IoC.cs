using Ninject;
using System;
using Ninject.Extensions.Conventions;
using SkeletonUtility.Services;

namespace SkeletonUtility.Tests
{
    public class IoC
    {
        public static IKernel Container { get { return NInjectKernel.Value; } }

        private static Lazy<IKernel> NInjectKernel = new Lazy<IKernel>(() =>
        {
            var kernel = new StandardKernel();
            kernel.Bind(x => x.FromAssemblyContaining(typeof(IAdditionService))
                .SelectAllClasses()
                .BindDefaultInterfaces());
            return kernel;
        });
    }
}
