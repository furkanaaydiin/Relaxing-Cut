using System;
using UnityEngine;
using DG.Tweening;
using TMPro;


namespace Money
{
    public class NewMoney : MoneyBase
    {
        public override void  NewMoneyInstance(Transform cut , Vector3 endPosition)
        {
            Instantiate(moneyPrefab,cut.transform.position, Quaternion.identity );
            moneyPrefab.transform.DOJump(endPosition, 1, 1, 0.1f);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                collectedMoney++;
                // moneyText.text = "" + collectedMoney;
                Destroy(gameObject);
                
              
            }
        }
        
      
    }
}