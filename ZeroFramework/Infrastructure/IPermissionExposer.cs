using System.Collections.Generic;

namespace ZeroFramework.Infrastructure
{
    public interface IPermissionExposer
    {
        Dictionary<string, List<PermissionDto>> Expose();
    }
}