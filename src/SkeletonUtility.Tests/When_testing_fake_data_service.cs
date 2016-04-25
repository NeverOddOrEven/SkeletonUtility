using Machine.Specifications;
using Ninject;
using SkeletonUtility.Services;

namespace SkeletonUtility.Tests
{
    public class When_testing_fake_data_service
    {
        private static IServiceThatUsesFakeDataPersistence _serviceThatUsesFakeDataPersistence;

        public Establish Context = () =>
        {
            _serviceThatUsesFakeDataPersistence = IoC.Container.Get<IServiceThatUsesFakeDataPersistence>();
        };

        public Because Of = () =>
        {
            _serviceThatUsesFakeDataPersistence.SaveResult("Result 1");
            _serviceThatUsesFakeDataPersistence.SaveResult("Result 2");
            _serviceThatUsesFakeDataPersistence.SaveResult("Result 3");
        };

        public It Should_save_the_three_requested_results = () =>
        {
            _serviceThatUsesFakeDataPersistence.GetResults().Count.ShouldEqual(3);
        };

        public It Should_match_the_saved_values = () =>
        {
            _serviceThatUsesFakeDataPersistence.GetResults().ShouldContain("Result 1", "Result 2", "Result 3");
        };
    }
}
