using ResourceSystem;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ResourceSystem
{
    [Serializable]
    public class ResourceData
    {
        [field: SerializeField] public ResourceType ResourceType { get; private set; }

        [field: SerializeField] public float EnabledTime { get; private set; }
        [field: SerializeField] public float DisabledTime { get; private set; }
    }
}