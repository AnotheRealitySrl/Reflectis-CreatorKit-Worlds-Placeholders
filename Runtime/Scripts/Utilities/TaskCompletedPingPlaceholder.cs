using Reflectis.CreatorKit.Worlds.Core.Placeholders;

using UnityEngine;

namespace Reflectis.CreatorKit.Worlds.Placeholders
{
    public enum TasksToPing { MacroTasksOnly, AllTasks }

    public class TaskCompletedPingPlaceholder : SceneComponentPlaceholderBase
    {
        [SerializeField]
        private TasksToPing taskToPingSetting;

        public TasksToPing TaskToPingSetting { get => taskToPingSetting; }
    }
}
