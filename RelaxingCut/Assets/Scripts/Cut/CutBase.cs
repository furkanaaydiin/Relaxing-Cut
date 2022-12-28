using System;
using UnityEngine;
using EzySlice;


namespace Cut
{
    public class CutBase : MonoBehaviour
    {
       [SerializeField] protected Material material;
        protected GameObject cutGameObject;

        protected SlicedHull Cut(GameObject obj, Material crossSectionMaterial )
        {
            var transform1 = transform;
            return obj.Slice(transform1.position, transform1.up, crossSectionMaterial);
        }
        
    }
}
