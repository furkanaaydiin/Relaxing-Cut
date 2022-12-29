using System;
using UnityEngine;

namespace Data
{
    public class DataManager  : MonoBehaviour
    {
        private static int _money;
        public static int Money
        {
            get => _money;
            set
            {
                _money = value;
                if (_money < 0)
                    _money = 0;
                OnMoneyChanged?.Invoke(_money);
            }
        }
        public static Action<int> OnMoneyChanged;
    }
}