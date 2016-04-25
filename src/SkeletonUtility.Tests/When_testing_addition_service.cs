using Machine.Specifications;
using Ninject;
using SkeletonUtility.Services;

namespace SkeletonUtility.Tests
{
    public class When_testing_addition_service
    {
        private static int expected = 30;
        private static int result = -1;
        private static IAdditionService additionService;

        public Establish Context = () =>
        {
            additionService = IoC.Container.Get<IAdditionService>();
        };

        public Because Of = () =>
        {
            result = additionService.Add(10, 20);
        };

        public It Should_return_30_when_adding_10_and_20 = () =>
        {
            result.ShouldEqual(expected);
        };
    }
}
