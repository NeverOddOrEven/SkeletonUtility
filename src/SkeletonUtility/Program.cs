using log4net;
using Ninject;
using System;
using System.Reflection;

namespace SkeletonUtility
{
    class Program
    {
        private static ILog Log = LogManager.GetLogger(typeof(Program).Name);

        static int Main(string[] args)
        {
            var service = IoC.Container.Get<ISkeletonApp>();

            try {
                service.Run();
            }
            catch (Exception ex)
            {
                Log.Error(ex);
                return -1;
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();

            return 0;
        }
    }
}
