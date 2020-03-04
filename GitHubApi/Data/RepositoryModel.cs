using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GitHubApi.Data
{
    public class RepositoryModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string  RepositoryService { get; set; }
    }
}
