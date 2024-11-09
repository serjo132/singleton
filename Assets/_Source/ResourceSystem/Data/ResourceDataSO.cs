using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ResourceSystem
{
    [CreateAssetMenu(fileName = "ResourceDataSO", menuName = "SO/New Resource Data")]
    public class NewBehaviourScript : ScriptableObject
    {
        [field: SerializeField] public List<ResourceData> ResourceViewData { get; private set; }
    }
}
