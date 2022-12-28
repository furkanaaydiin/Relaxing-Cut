using System;
using Money;
using TMPro;
using UnityEngine;

namespace Player
{
    public class PropellerIdleView : MonoBehaviour
    {
        [SerializeField] private Joystick movementJoystick;
        [SerializeField] private InputController inputController;
        

        private void Update()
        {
            inputController.SetInput(movementJoystick.Direction);
            
            
        }
    }
}
