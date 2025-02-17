using Reflectis.CreatorKit.Worlds.Core.Placeholders;
using Reflectis.SDK.Core.Utilities;

using UnityEngine;

namespace Reflectis.CreatorKit.Worlds.Placeholders
{
    public class DashboardPlaceholder : SceneComponentPlaceholderBase, IAddressablePlaceholder
    {
        public enum DashboardFilter
        {
            Environment,
            Category,
            Tag,
            None
        }

        [SerializeField] private string addressableKey = "EnvironmentalDashboard";

        [Header("DashboardData")]
        [SerializeField, Tooltip("Choose the type on information you want to show on the dashboard")]
        private DashboardFilter filter;
        [SerializeField, Tooltip("Write the name of the category, environment or tag present in the backoffice that you want to show on the dashboard ")]
        private string dashboardNameFilter;
        [SerializeField]
        private Transform panTransform;

        [SerializeField, /*Range(0.5f, 10),*/ Tooltip("The width of the screen.")]
        [OnChangedCall(nameof(OnWidthChanged))]
        private float dashboardWidth = 3f;

        [SerializeField, /*Range(0.5f, 10),*/ Tooltip("The height of the screen.")]
        [OnChangedCall(nameof(OnHeightChanged))]
        private float dashboardHeight = 2f;

        public string DashboardNameFilter => dashboardNameFilter;
        public DashboardFilter Filter => filter;
        public Transform PanTransform => panTransform;

        public float DashboardWidth => dashboardWidth;
        public float DashboardHeight => dashboardHeight;

        public string AddressableKey => addressableKey;

        public void OnWidthChanged()
        {
            transform.localScale = new Vector3(dashboardWidth, transform.localScale.y, transform.localScale.z);
        }

        public void OnHeightChanged()
        {
            transform.localScale = new Vector3(transform.localScale.x, dashboardHeight, transform.localScale.z);
        }
    }
}
