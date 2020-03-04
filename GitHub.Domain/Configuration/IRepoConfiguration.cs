using System;
using System.Collections.Generic;
using System.Text;

namespace GitHub.Domain.Configuration
{
    /// <summary>
    /// Idea is that some repository services may need more configuration, username, pass etc
    /// Can pass this interface to a new implementation and register it appropriately in the startup
    /// </summary>
    public interface IRepoConfiguration
    {

    }
}
