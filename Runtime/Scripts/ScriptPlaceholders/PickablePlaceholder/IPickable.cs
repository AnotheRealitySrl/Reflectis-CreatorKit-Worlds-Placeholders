using Reflectis.CreatorKit.Worlds.Core.Placeholders;
using System.Threading.Tasks;
using UnityEngine;

namespace Reflectis.CreatorKit.Worlds.Placeholders
{
    public interface IPickable
    {
        Task Init(SceneComponentPlaceholderBase placeholder);

    }
}
