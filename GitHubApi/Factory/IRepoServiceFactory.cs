using GitHub.Domain.Implementation;
using GitHub.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GitHubApi.Factory
{
    public interface IRepoServiceFactory
    {
        IRepoService GetRepoService(string serviceName);
    }
    public class RepositoryFactory : IRepoServiceFactory
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public RepositoryFactory(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public IRepoService GetRepoService(string serviceName)
        {
            switch (serviceName)
            {
                case "GitHub":
                    var client = _httpClientFactory.CreateClient("gitHub");
                    return new GitHubService(client);
                default:
                    throw new NotImplementedException($"Service Type {serviceName} is not available");
            }
        }
    }
}
