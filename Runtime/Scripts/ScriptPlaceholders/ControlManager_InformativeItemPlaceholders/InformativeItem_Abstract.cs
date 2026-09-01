using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Scripting.APIUpdating;

namespace Virtuademy.CreatorKit.Worlds.Placeholders
{
    [MovedFrom(false, "Reflectis.CreatorKit.Worlds.Placeholders", "Reflectis.CreatorKit.Worlds.Placeholders")]
    public abstract class InformativeItem_Abstract : MonoBehaviour
    {
        public UnityEvent onTaskStart;
        public UnityEvent onTaskEnd;
        public UnityEvent onHover;
        public UnityEvent onSelect;
        public UnityEvent OnUnselect;
        public UnityEvent OnUnHover;

        public virtual void StartTask()
        {
            onTaskStart?.Invoke();
        }

        public virtual void CompleteTask()
        {
            onTaskEnd?.Invoke();
        }

        public virtual void Hover(bool value)
        {
            if(value)
                onHover?.Invoke();
            else
                OnUnHover?.Invoke();
        }

        public virtual void Select(bool value)
        {
            if(value)
                onSelect?.Invoke();
            else
                OnUnselect?.Invoke();
        }
    }
}
