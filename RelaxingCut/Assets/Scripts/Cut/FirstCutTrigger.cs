using System;
using UnityEngine;
using EzySlice;
using DG.Tweening;
using Money;

namespace Cut
{
    public class FirstCutTrigger : CutBase
    {
       [SerializeField] private CurrencyBase currencyPrefab;


        private void OnTriggerEnter(Collider other)
        {

            if (other.gameObject.CompareTag("Cuttable"))
            {
                cutGameObject = other.gameObject;
                AfterCutting();
                Instantiate(currencyPrefab, null).Initialize(cutGameObject.transform.position);
            }
        }
        public void AfterCutting()
        {
            if (cutGameObject != null )
            {
                SlicedHull cutOff = Cut(cutGameObject, material);
                var cutOffUp = cutOff.CreateUpperHull(cutGameObject, material);
                AfterCuttingAddComponentUp(cutOffUp,cutOffUp.transform.position);
                var  cutOffDown = cutOff.CreateLowerHull(cutGameObject, material);
                AfterCuttingAddComponentDown(cutOffDown);
                
                Destroy(cutGameObject);
            }
            
        }
        
        private void AfterCuttingAddComponentUp(GameObject cutOffUp , Vector3 endPosition)
        {
            cutOffUp.AddComponent<BoxCollider>(); 
            cutOffUp.AddComponent<Rigidbody>();
            cutOffUp.transform.DOJump(endPosition, 1, 1, 0.1f);
            Destroy(cutOffUp ,2f);
        }

        private void AfterCuttingAddComponentDown(GameObject cutOffDown)
        {
            cutOffDown.AddComponent<BoxCollider>(); 
            cutOffDown.AddComponent<Rigidbody>();
            Destroy(cutOffDown,4f);
        }


       
        
        
    }
}