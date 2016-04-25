using System;
using SkeletonUtility.Repository;
using System.Collections.Generic;
using SkeletonUtility.Repository.Models;
using System.Linq;

namespace SkeletonUtility.Services
{
    public interface IServiceThatUsesFakeDataPersistence
    {
        void SaveResult(string result);
        IList<string> GetResults();
    }

    public class ServiceThatUsesFakeDataPersistence : IServiceThatUsesFakeDataPersistence
    {
        private ITestRepository _testRepository;
        public ServiceThatUsesFakeDataPersistence(ITestRepository testRepository)
        {
            _testRepository = testRepository;
        }

        public IList<string> GetResults()
        {
            return _testRepository.Get(Int32.MaxValue).Select(x => x.TestString).ToList();
        }

        public void SaveResult(string result)
        {
            _testRepository.Add(new Test(result));
        }
    }
}
