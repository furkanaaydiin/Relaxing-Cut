using System;
using UnityEngine;

namespace Player
{
    public class PropellerController : PropellerBase
    {
        public static PropellerController Instance;


        private void Awake()
        {
            Instance = this;
        }

        public override void Move(Vector2 movementJoystickDirection)
        {
            base.Move(movementJoystickDirection);
            var localPosition = transform.localPosition;
            localPosition = Vector3.Lerp(localPosition,
                localPosition + new Vector3(movementJoystickDirection.x, 0, movementJoystickDirection.y),
                Time.deltaTime * Speed);
            transform.localPosition = localPosition;
        }
    }
    
    
    
}
