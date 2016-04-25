using System;

namespace SkeletonUtility.Services
{
    public interface IAdditionService
    {
        int Add(int first, int second);
    }

    public class AdditionService : IAdditionService
    {
        public int Add(int first, int second)
        {
            return first + second;
        }
    }
}
