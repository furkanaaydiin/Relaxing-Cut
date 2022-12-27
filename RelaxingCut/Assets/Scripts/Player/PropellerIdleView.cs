using System;
using UnityEngine;

namespace Player
{
    public class PropellerIdleView : MonoBehaviour
    {
        [SerializeField] private Joystick movementJoystick;
        [SerializeField] private InputController inputController;

        private void FixedUpdate()
        {
            inputController.SetInput(movementJoystick.Direction);
        }
    }
}
