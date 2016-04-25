using Ninject;
using System;
using Ninject.Extensions.Conventions;

namespace SkeletonUtility
{
    public class IoC
    {
        public static IKernel Container { get { return NInjectKernel.Value; } }

        private static Lazy<IKernel> NInjectKernel = new Lazy<IKernel>(() =>
        {
            var kernel = new StandardKernel();
            kernel.Bind(x => x.FromThisAssembly()
                .SelectAllClasses()
                .BindDefaultInterfaces());
            return kernel;
        });
    }
}
