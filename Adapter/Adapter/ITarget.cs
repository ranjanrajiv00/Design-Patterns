using System.Collections.Generic;

namespace Adapter
{
    /// <summary>
    /// Adapter Interface - IAdapter
    /// </summary>
    public interface ITarget
    {
        List<string> GetPatiens();
    }
}