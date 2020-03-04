using GitHub.Domain.Interfaces;
using GitHub.Domain.Models;
using GitHub.Shared.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GitHub.Domain.Implementation
{
    public class GitHubService : IRepoService
    {
        private readonly HttpClient _httpClient;
        public GitHubService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<RepositoryEntity>> GetRepoByUser(string user)
        {
            var response = await _httpClient.GetAsync($"users/{user}/repos");

            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();
            var model = JsonConvert.DeserializeObject<IEnumerable<GitHubResponseModel>>(responseString);
            if (model.Any())
            {
                return model.Select(x => new RepositoryEntity
                {
                    RepoName = x.name,
                    StarCount = x.stargazers_count,
                    SubscriberCount = x.watchers_count,
                    UserInfo = new User
                    {
                        UserName = user,
                        AvatarUrl = x.owner?.avatar_url ?? string.Empty
                    }
                });
            }
            return new List<RepositoryEntity>();
       
        }
    }
}
