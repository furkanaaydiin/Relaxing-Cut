using System;
using Player;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Money
{
    public class MoneyBase : MonoBehaviour
    {
        [SerializeField] protected GameObject moneyPrefab;
        [SerializeField] protected TextMeshProUGUI moneyText;
        public int collectedMoney = 10;


        private void Update()
        {
            moneyText.text = collectedMoney.ToString();
            
        }

        public virtual void NewMoneyInstance(Transform cut, Vector3 endPosition )
        {
            
        }
        
        public  void  MoneyEarn( int amount )
        {
            collectedMoney++;
            collectedMoney += amount;
            
        }
        
        
        public  void MoneySpent(int amount)
        {
            collectedMoney -= amount;
        }
        
    }
}
