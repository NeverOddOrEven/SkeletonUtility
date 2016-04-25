using SkeletonUtility.Repository.Base;
using SkeletonUtility.Repository.Models;

namespace SkeletonUtility.Repository
{
    public interface ITestRepository : IRepository<Test>
    {

    }

    public class TestRepository : Repository<Test>, ITestRepository
    {
    }
}
