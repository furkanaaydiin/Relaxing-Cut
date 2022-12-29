using System;
using Data;
using Player;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using Random = UnityEngine.Random;

namespace Money
{
    public class CurrencyBase : MonoBehaviour
    {
        public void Initialize(Vector3 spawnPosition)
        {
            transform.position =spawnPosition;
            transform.DOJump(spawnPosition + Vector3.forward * Random.Range(-2,2) + Vector3.left * Random.Range(-2,2), 1, 1, 0.1f);
        }
      
        private void MoneyEarn()
        {
            DataManager.Money += 1;
        }
        protected virtual void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                DestroyCurrency();
            }
        }

        protected void DestroyCurrency()
        {
            MoneyEarn();
            Destroy(gameObject);
        }

      
    }
}
