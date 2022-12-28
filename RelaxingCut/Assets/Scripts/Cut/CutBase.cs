using System;
using UnityEngine;
using EzySlice;
using Player;

namespace Cut
{
    public class CutBase : MonoBehaviour
    {
        private Material material;
        private GameObject cutGameObject;
       


        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.layer == LayerMask.NameToLayer("Cuttable"))
            {
                material = other.GetComponent<MeshRenderer>().material;
                cutGameObject = other.gameObject;
                
               
               
                
                
                

            }
        }

        private void Update()
        {
            AfterCutting();
        }

        public void AfterCutting()
        {
            if (Input.GetKey(KeyCode.V) && cutGameObject != null )
            {
                SlicedHull cutOff = Cut(cutGameObject, material);
                
                var cutOffUp = cutOff.CreateUpperHull(cutGameObject, material);
                cutOffUp.AddComponent<BoxCollider>();  //    .convex = true; // başka secenek bakılacak 
                cutOffUp.AddComponent<Rigidbody>();
               // Destroy(cutOffUp,2f);
               // cutOffUp.layer = LayerMask.NameToLayer("Cuttable"); // kaldırılacak 
                var  cutOffDown = cutOff.CreateLowerHull(cutGameObject, material);
                cutOffDown.AddComponent<BoxCollider>(); //.convex = true;// başka secenek bakılacak 
                cutOffDown.AddComponent<Rigidbody>();
               // Destroy(cutOffDown,2f);
              //  cutOffDown.layer = LayerMask.NameToLayer("Cuttable"); // kaldırılacak 
                Destroy(cutGameObject);
            }
            
        }

        public SlicedHull Cut(GameObject obj, Material crossSectionMaterial = null)
        {
            return obj.Slice(transform.position, transform.up, crossSectionMaterial);
        }
        
    }
}
