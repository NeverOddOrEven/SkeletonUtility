using Machine.Specifications;

namespace SkeletonUtility.Tests
{
    /// <summary>
    /// Just a template for a generic mpsec test
    /// </summary>
    public class When_running_mspec_test
    {
        private static int _testValue = -715;

        public Establish Context = () =>
        {
            _testValue = 700;
        };

        public Because Of = () =>
        {

        };

        public Cleanup After = () =>
        {

        };

        public It Should = () =>
        {
            _testValue.ShouldEqual(700);
        };
    }
}
