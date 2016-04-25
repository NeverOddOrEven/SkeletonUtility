using SkeletonUtility.Repository.Base;

namespace SkeletonUtility.Repository.Models
{
    public class Test : Entity
    {
        public Test(string result)
        {
            TestString = result;
        }

        public long Id { get; set; }
        public string TestString { get; set; }
    }
}
