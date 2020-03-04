using GitHub.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GitHub.Domain.Interfaces
{
    public interface IRepoService
    {
        Task<IEnumerable<RepositoryEntity>> GetRepoByUser(string user);
    }
}
