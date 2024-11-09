using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

namespace ResourceSystem.View
{
    public class ResourceButton : MonoBehaviour
    {
        [SerializeField] private ResourceType resourceType;
        [SerializeField] private Image resourceIcon;

        private void Awake()
        {
            ResourceViewService.Instance.SetEnabledIcon(resourceIcon, resourceType);
        }

        private void Update()
        {
            ProcessResource();
        }

        private void ProcessResource()
        {
            //resource processing with time data
        }
    }
}
