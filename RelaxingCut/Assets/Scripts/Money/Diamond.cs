using DG.Tweening;
using UnityEngine;

namespace Money
{
    public class Diamond : CurrencyBase
    {
        protected override void OnTriggerEnter(Collider other)
        {
            transform.DOScale(Vector3.zero, 1)
                .OnComplete(DestroyCurrency);
            
        }
    }
}