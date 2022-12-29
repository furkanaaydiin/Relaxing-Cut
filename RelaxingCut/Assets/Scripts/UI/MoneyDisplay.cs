using Data;
using TMPro;
using UnityEngine;

namespace UI
{
    public class MoneyDisplay : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI moneyText;
        private void Awake()
        {
            DataManager.OnMoneyChanged += OnMoneyChanged;
        }

        private void OnMoneyChanged(int moneyAmount)
        {
            SetText(moneyAmount);
        }

        private void SetText(int moneyAmount)
        {
            moneyText.text = $"{moneyAmount}$";
        }
    }
}