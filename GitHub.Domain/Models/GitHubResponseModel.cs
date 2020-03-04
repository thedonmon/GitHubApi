using System;
using System.Collections.Generic;
using System.Text;

namespace GitHub.Domain.Models
{
    public class GitHubResponseModel
    {
        public int id { get; set; }
        public string node_id { get; set; }
        public string name { get; set; }
        public string full_name { get; set; }
        public int stargazers_count { get; set; }
        public int watchers_count { get; set; }
        public GitHubUserModel owner { get; set; }
    }
    public class GitHubUserModel
    {
        public string login { get; set; }
        public int id { get; set; }
        public string node_id { get; set; }
        public string avatar_url { get; set; }
    }
}
