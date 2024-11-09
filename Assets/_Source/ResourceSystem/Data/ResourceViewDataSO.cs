using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ResourceSystem
{
    [CreateAssetMenu(fileName = "ResourceViewDataSO", menuName = "SO/New Resource View Data")]
    public class ResourceViewDataSO : ScriptableObject
    {
        [field:SerializeField] public List<ResourceViewData> ResourceViewData {  get; private set; }

        public bool TryGetEnabledIcon(ResourceType resourceType, out Sprite icon)
        {
            icon = null;
            foreach (var viewData in ResourceViewData)
            {
                if (viewData.ResourceType == resourceType)
                {
                    icon = viewData.EnabledStateIcon;
                    return true;
                }
            }
            return false; 
        }

        public bool TryGetDisabledIcon(ResourceType resourceType, out Sprite icon)
        {
            icon = null;
            foreach (var viewData in ResourceViewData)
            {
                if (viewData.ResourceType == resourceType)
                {
                    icon = viewData.DisabledStateIcon;
                    return true;
                }
            }
            return false;
        }
    }
}