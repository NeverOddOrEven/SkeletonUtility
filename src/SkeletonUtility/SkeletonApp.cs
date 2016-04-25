using log4net;
using SkeletonUtility.Services;

namespace SkeletonUtility
{
    public interface ISkeletonApp
    {
        void Run();
    }

    public class SkeletonApp : ISkeletonApp
    {
        private ILog Log = LogManager.GetLogger(typeof(SkeletonApp).Name);
        private IAdditionService _firstService;
        private IServiceThatUsesFakeDataPersistence _serviceThatUsesFakeDataPersistence;

        public SkeletonApp(IAdditionService firstService, 
            IServiceThatUsesFakeDataPersistence serviceThatUsesFakeDataPersistence) 
        {
            _firstService = firstService;
            _serviceThatUsesFakeDataPersistence = serviceThatUsesFakeDataPersistence;
        }

        public void Run()
        {
            int first = 10, second = 20;

            // Use the Fake Data Service
            _serviceThatUsesFakeDataPersistence.SaveResult("One");
            _serviceThatUsesFakeDataPersistence.SaveResult("Two");
            var results = _serviceThatUsesFakeDataPersistence.GetResults();

            // Use the Addition Service
            Log.InfoFormat("{0} + {1} = {2}", first, second, _firstService.Add(10,20));

            // Show retrieval from the Fake Data Service
            Log.Info("Saved Results: ");
            foreach(var result in results)
            {
                Log.InfoFormat("{0}", result);
            }
        }
    }
}
